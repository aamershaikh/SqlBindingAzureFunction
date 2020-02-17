using Microsoft.Azure.WebJobs.Host.Config;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDwBinding
{
    public class SqlDwConfiguration : IExtensionConfigProvider
    {
        void IExtensionConfigProvider.Initialize(ExtensionConfigContext context)
        {
            // Converting our custom object to a JObject, and back again - used for JavaScript / Java functions using this binding
            context.AddConverter<JObject, SqlDwMessage>(input => input.ToObject<SqlDwMessage>());
            context.AddConverter<SqlDwMessage, JObject>(input => JObject.FromObject(input));

            context.AddBindingRule<SqlDwAttribute>()
                .BindToCollector<SqlDwMessage>(attr => new SqlDwAsyncCollector(this, attr));

            var rule = context.AddBindingRule<SqlDwAttribute>();
            rule.BindToInput<SqlDwMessage>(BuildItemFromAttribute);
        }

        private SqlDwMessage BuildItemFromAttribute(SqlDwAttribute arg)
        {
            // input binding - this is where we get the 'thing' to hand to the function
            // For now we'll hand a hardcoded object
            return new SqlDwMessage { Id = "foo", Name = "bar" };
        }
    }
}