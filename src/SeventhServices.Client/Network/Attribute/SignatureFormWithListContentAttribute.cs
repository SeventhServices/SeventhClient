using System;
using SeventhServices.Client.Common;
using System.Collections.Generic;
using System.Linq;
using WebApiClient.Attributes;

namespace SeventhServices.Client.Network.Attribute
{
    internal sealed class SignatureFormWithListContentAttribute : FormContentAttribute
    {
        protected override IEnumerable<KeyValuePair<string, string>> HandleForm(
            IEnumerable<KeyValuePair<string, string>> form)
        {
            var formList = form.ToList();

            var list = formList.Where(p => p.Key.Contains("List")).ToArray();
            if (list.Any())
            {
                formList.RemoveAll(p => p.Key.Contains("List"));
                var listItemName = list.FirstOrDefault().Key.Replace("List", string.Empty);
                formList.Add( new KeyValuePair<string,string>(listItemName,Signature.GetListParamSignatureData(
                    list.Select( l => l.Value))));
                var apiName = formList.Find(p => p.Key == "apiName");
                var uuid = formList.Find(p => p.Key == "uuid");
                formList.Remove(apiName);
                formList.Remove(uuid);
                formList.Add(new KeyValuePair<string, string>("sig",
                    new Signature(formList, apiName.Value, uuid.Value).ToString()));
                var listItem = formList.Find(p => p.Key == listItemName);
                formList.Remove(listItem);
                listItemName += "[]";
                formList.AddRange(list.Select(i => new KeyValuePair<string, string>(listItemName, i.Value)));
            }
            else
            {
                var apiName = formList.Find(p => p.Key == "apiName");
                var uuid = formList.Find(p => p.Key == "uuid");
                formList.Remove(apiName);
                formList.Remove(uuid);
                formList.Add(new KeyValuePair<string, string>("sig",
                    new Signature(formList, apiName.Value, uuid.Value).ToString()));
            }

            return base.HandleForm(formList);
        }


    }
}