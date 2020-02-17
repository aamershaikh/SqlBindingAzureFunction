using Microsoft.Azure.WebJobs;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SqlDwBinding
{
    public class SqlDwAsyncCollector : IAsyncCollector<SqlDwMessage>
    {
        private SqlDwAttribute attr;
        private SqlDwConfiguration config;
        public SqlDwAsyncCollector(SqlDwConfiguration config, SqlDwAttribute attr)
        {
            this.config = config;
            this.attr = attr;
        }

        public async Task AddAsync(SqlDwMessage item, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Here's where we get the 'thing' from the function (via an output binding), and can choose where to send it on to
            // For now just log the input to the console
            Console.WriteLine($"I'm the binding, and I got........: {item.Id} :: {item.Name}!");
        }

        public Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.CompletedTask;
        }
    }
}