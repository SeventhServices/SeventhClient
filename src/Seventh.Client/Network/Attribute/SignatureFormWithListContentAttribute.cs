using System.Collections.Generic;
using System.Linq;
using Seventh.Client.Common;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Seventh.Client.Network.Attribute
{
    internal sealed class SignatureFormWithListContentAttribute : FormContentAttribute
    {
        protected override IEnumerable<KeyValue> SerializeToKeyValues(ApiParameterContext context)
        {
            var form = base.SerializeToKeyValues(context);
            var formList = form.ToList();

            var list = formList.Where(p => p.Key.Contains("List")).ToArray();
            if (list.Any())
            {
                formList.RemoveAll(p => p.Key.Contains("List"));
                var listItemName = list.FirstOrDefault().Key.Replace("List", string.Empty);
                formList.Add( new KeyValue(listItemName,Signature.GetListParamSignatureData(
                    list.Select( l => l.Value))));
                var apiName = formList.Find(p => p.Key == "apiName");
                var uuid = formList.Find(p => p.Key == "uuid");
                formList.Remove(apiName);
                formList.Remove(uuid);
                formList.Add(new KeyValue("sig",
                    new Signature(formList, apiName.Value, uuid.Value).ToString()));
                var listItem = formList.Find(p => p.Key == listItemName);
                formList.Remove(listItem);
                listItemName += "[]";
                formList.AddRange(list.Select(i => new KeyValue(listItemName, i.Value)));
            }
            else
            {
                var apiName = formList.Find(p => p.Key == "apiName");
                var uuid = formList.Find(p => p.Key == "uuid");
                formList.Remove(apiName);
                formList.Remove(uuid);
                formList.Add(new KeyValue("sig",
                    new Signature(formList, apiName.Value, uuid.Value).ToString()));
            }

            return formList;
        }


    }
}