# SeventhServices.Client
[![Build Status](https://dev.azure.com/SeventhServices/SeventhServices.Client/_apis/build/status/SeventhServices.Client-Github?branchName=master)](https://dev.azure.com/SeventhServices/SeventhServices.Client/_build/latest?definitionId=2&branchName=master)
[![Actions Status](https://github.com/SeventhServices/SeventhServices.Client/workflows/Build/badge.svg)](https://github.com/SeventhServices/SeventhServices.Client/actions)
[![GitHub](https://img.shields.io/github/license/SeventhServices/SeventhServices.Client)](https://github.com/SeventhServices/SeventhServices.Client/blob/master/LICENSE)

An api client for seventh project.

## Status
It is now be developing, you can use the develop version.

## Useage
This client package is depended on 
[WebApiClient](https://github.com/dotnetcore/WebApiClient) and provide a `ISeventhApiClient`.

#### 1. First, you can set the default `pid` and `uuid` at static class RequsetParams. ####
```csharp
RequestParams.Pid = (default pid);
RequestParams.Uuid = (default uuid);
RequestParams.Version = (the lastest version, like "7.0.0");
RequestParams.Rev = (the lastest version, like 300);
```
#### 2. And then, you can use the api like this. ####
* Register 

You will need register this only once.
```csharp
HttpApi.Register<ISeventhApiClient>().ConfigureHttpApiConfig(config =>
{
    config.FormatOptions.UseCamelCase = true;
});
```
or use `RegisterSeventhClient()` in this package.
```csharp
HttpApiExtension.RegisterSeventhClient();
```
* Use
```csharp
var apiClient = HttpApi.Resolve<ISeventhApiClient>();
var response = await apiClient.Inspection(new InspectionRequest());
```

You can find other useage at 
[WebApiClient Wiki](https://github.com/dotnetcore/WebApiClient/wiki).

## Packages
| Package Name                   | Develop (MyGet) |
|--------------------------------|-----------------|
| `SeventhServices.Client`       | [![MyGet tenant](https://img.shields.io/seventhservices.myget/seventhservices/v/SeventhServices.Client?label=Version)](https://www.myget.org/feed/seventhservices/package/nuget/SeventhServices.Client)|
| `SeventhServices.Client.Extensions.DependencyInjection` | [![MyGet tenant](https://img.shields.io/seventhservices.myget/seventhservices/v/SeventhServices.Client.Extensions.DependencyInjection?label=Version)](https://www.myget.org/feed/seventhservices/package/nuget/SeventhServices.Client.Extensions.DependencyInjection) |
| `SeventhServices.Client.Extensions.HttpClientFactory` | [![MyGet tenant](https://img.shields.io/seventhservices.myget/seventhservices/v/SeventhServices.Client.Extensions.HttpClientFactory?label=Version)](https://www.myget.org/feed/seventhservices/package/nuget/SeventhServices.Client.Extensions.HttpClientFactory) |
