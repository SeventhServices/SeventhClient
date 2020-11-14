using System.Collections.Generic;
using System.Linq;
using Seventh.Client.Common;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Seventh.Client.Network.Attribute
{
    internal sealed class SignatureFormContentAttribute : FormContentAttribute
    {
        protected override IEnumerable<KeyValue> SerializeToKeyValues(ApiParameterContext context)
        {
            var keyValues = base.SerializeToKeyValues(context);
            var formList = keyValues.ToList();
            var apiName = formList.Find(p => p.Key == "apiName");
            var uuid = formList.Find(p => p.Key == "uuid");
            formList.Remove(apiName);
            formList.Remove(uuid);
            formList.Add(new KeyValue("sig",
                new Signature(formList, apiName.Value, uuid.Value).ToString()));
            return formList;
        }
    }
}