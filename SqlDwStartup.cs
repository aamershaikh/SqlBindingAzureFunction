using SqlDwBinding;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: WebJobsStartup(typeof(SqlDwStartup))]
namespace SqlDwBinding
{
    public class SqlDwStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<SqlDwConfiguration>();
        }
    }
}