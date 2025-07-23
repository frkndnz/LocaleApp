var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.LocaleApp_WebAPI>("localeapp-webapi");

builder.Build().Run();
