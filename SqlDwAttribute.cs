using Microsoft.Azure.WebJobs.Description;
using System;
using System.Collections.Generic;
using System.Text;

// TODO: add the database name and container name as attributes here.

namespace SqlDwBinding
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    [Binding]
    public class SqlDwAttribute : Attribute
    {
        [AppSetting]
        public string ConStr { get; set; }
    }
}