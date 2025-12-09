var builder = DistributedApplication.CreateBuilder(args);

var gateway = builder.AddProject<Projects.Nothing_Gateway_Api>("gateway");

builder.Build().Run();
