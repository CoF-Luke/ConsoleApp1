var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Lab01__2_ApiService>("apiservice");

builder.AddProject<Projects.Lab01__2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
