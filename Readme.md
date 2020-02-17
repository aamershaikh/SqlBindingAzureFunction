SQL Custom Input binding example.
Created in C#. 
Follwed github examples : 
    https://github.com/damoodamoo/azure-function-custom-binding
    https://github.com/ealsur/functions-extension-101

1) Uses dot net 2.1.*
2) Create a new project and run 'dotnet new console' in it. This will build some boiler plate code for hello world.

+++++++++Main code starts here+++++++
3) Define an attribute 
        - Contains parameters and configurations that are to be exposed to the consumer.
        Steps : 
                a) get the required directive 'dotnet add package Microsoft.Azure.WebJobs --version 3.0.14'
                b) TODO: add database name and container name to the SqlDwAttribute.


4) define connector(collector ???) or service




To Create a sln file and add a .csproj in it

https://andrewlock.net/creating-and-editing-solution-files-with-the-net-cli/
        - 