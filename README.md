![68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f6175746f6d61707065722f6c6f676f2e706e67](https://user-images.githubusercontent.com/21302583/68099418-6ad93b80-fee8-11e9-936b-c75b2dcb4ba9.png)


### What is AutoMapper?

AutoMapper is a simple little library built to solve a deceptively complex problem - getting rid of code that mapped one object to another. This type of code is rather dreary and boring to write, so why not invent a tool to do it for us?

This is the main repository for AutoMapper, but there's more:

* [EF6 Extensions](https://github.com/AutoMapper/AutoMapper.EF6)
* [IDataReader/Record Extensions](https://github.com/AutoMapper/AutoMapper.Data)
* [Collection Extensions](https://github.com/AutoMapper/AutoMapper.Collection)
* [Microsoft DI Extensions](https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection)
* [Expression Mapping](https://github.com/AutoMapper/AutoMapper.Extensions.ExpressionMapping)

## Create Project

01. First Create Project File->New->Project
02. Select ASP.NET Core Web Aplication Named `AutoMapperSample`

![project](https://user-images.githubusercontent.com/21302583/68111111-69256d00-ff14-11e9-8b60-d596badbb3a9.PNG)

03. Select Web Application(Model-View-Controller)

![MVC](https://user-images.githubusercontent.com/21302583/68111356-f1a40d80-ff14-11e9-92f6-a1a5afa11c97.PNG)

`Keep Remember to Untick Configure For Https`

04. Go to Tools->Nuget Package Manager->Manage Nuget Packages For Soluation and Install AutoMapper.Extensions.Microsoft.DependencyInjection

![automapper depencies injecttion](https://user-images.githubusercontent.com/21302583/68111675-b48c4b00-ff15-11e9-861a-22e7eb0d1eb7.PNG)

05. Add new project Class libarary(.NET Core) as `Entity`

06. Create Folder Named Domain and Create Customer.cs Class File Like This

```csharp
namespace Entity.Domain
{
    public class Customer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isActive { get; set; }
    }
}
```

07. Add new project Class libarary(.NET Core) as `DTO`

![DTO](https://user-images.githubusercontent.com/21302583/68112017-6deb2080-ff16-11e9-910d-44e8acda51c3.PNG)

08.Install Automapper to `DTO` Libarary

![DTOAutomapper](https://user-images.githubusercontent.com/21302583/68112412-45175b00-ff17-11e9-96f8-15d257b54caa.PNG)

09.In DTO Libarary Create Two folders `DTOLibarary` and `MappingProfiles`

10. Add

10. Create DTOLibarary-> `CustomerDTO.cs` Like This

```csharp
namespace DTO.DTOLibary
{
    public class CustomerDTO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isActive { get; set; }
    }
}
```
09.Create MappingProfiles->`DomainToDTOMapping` and `DTOToDomainMapping`

```csharp
```

```csharp
```


