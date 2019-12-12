using SeventhServices.Client.Common;
using System.Collections.Generic;
using System.Linq;
using WebApiClient.Attributes;

namespace SeventhServices.Client.Network.Attribute
{
    internal sealed class SignatureFormContentAttribute : FormContentAttribute
    {
        protected override IEnumerable<KeyValuePair<string, string>> HandleForm(
            IEnumerable<KeyValuePair<string, string>> form)
        {
            var formList = form.ToList();
            var apiName = formList.Find(p => p.Key == "apiName");
            var uuid = formList.Find(p => p.Key == "uuid");
            formList.Remove(apiName);
            formList.Remove(uuid);
            formList.Add(new KeyValuePair<string, string>("sig",
                new Signature(formList, apiName.Value, uuid.Value).ToString()));
            return base.HandleForm(formList);
        }


    }
}