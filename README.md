![68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f6175746f6d61707065722f6c6f676f2e706e67](https://user-images.githubusercontent.com/21302583/68099418-6ad93b80-fee8-11e9-936b-c75b2dcb4ba9.png)

[![Build status](https://ci.appveyor.com/api/projects/status/9ia1fpge700cs0lg?svg=true)](https://ci.appveyor.com/project/Mahadenamuththa/automappersample-sxysn)

[![Build history](https://buildstats.info/appveyor/chart/Mahadenamuththa/automappersample-sxysn)](https://ci.appveyor.com/project/Mahadenamuththa/automappersample-sxysn/history)

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
02. Select ASP.NET Core Web Soluation Named `AutoMapperSample` and Name `MVC`

    ![project](https://user-images.githubusercontent.com/21302583/68183027-3c7b5f00-ffc1-11e9-821f-a50a3b9563b9.PNG)

03. Select Web Application(Model-View-Controller)

    ![MVC](https://user-images.githubusercontent.com/21302583/68183029-3d13f580-ffc1-11e9-9ce4-97a0a5fd8eb4.PNG)

`Keep Remember to Untick Configure For Https`

04. Go to Tools->Nuget Package Manager->Manage Nuget Packages For Soluation and Install AutoMapper.Extensions.Microsoft.DependencyInjection To MVC

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

08. Install Automapper to `DTO` Libarary

    ![DTOAutomapper](https://user-images.githubusercontent.com/21302583/68112412-45175b00-ff17-11e9-96f8-15d257b54caa.PNG)

09. In DTO Libarary Create Two folders `DTOLibarary` and `MappingProfiles`

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
11. Create MappingProfiles->`DomainToDTOMapping` and `DTOToDomainMapping`

    DomainToDTOMapping.cs
    ```csharp
    using AutoMapper;
    using DTO.DTOLibarary;
    using Entity.Domain;

    namespace DTO.MappingProfiles
    {
        public class DomainToDTOMapping : Profile
        {
            public DomainToDTOMapping()
            {
                CreateMap<CustomerDTO, Customer>();
            }
        }
    }

    ```

    DTOToDomainMapping.cs
    ```csharp
    using AutoMapper;
    using DTO.DTOLibarary;
    using Entity.Domain;

    namespace DTO.MappingProfiles
    {
        public class DTOToDomainMapping : Profile
        {
            public DTOToDomainMapping()
            {
                CreateMap<Customer, CustomerDTO>();
            }
        }
    }
    ```
12. Add Reference DTO and Entity Class Libararies to MVC

    ![References](https://user-images.githubusercontent.com/21302583/68182819-97f91d00-ffc0-11e9-9e5f-c1ba4a831f92.png)
    ![Reference 2](https://user-images.githubusercontent.com/21302583/68182910-da225e80-ffc0-11e9-9706-e41494a90e6f.png)

13. Modify MVC->Startup.cs->ConfigureServices()

    ```csharp
    //Automapper Configurations
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile(new DTOToDomainMapping());
        cfg.AddProfile(new DomainToDTOMapping());
    });
    var mapper = config.CreateMapper();
    services.AddSingleton(mapper);
    services.AddAutoMapper(typeof(Startup));
    ```

14. Now Change MVC->Controllers->HomeController.cs 

```csharp
    private IMapper _mapper;
    
    public HomeController(IMapper mapper)
    {
        this._mapper = mapper;
    }
    
    public IActionResult Index()
    {           
        var customer = new Customer()
        {
            id = 1,
            firstName = "Pasindu",
            lastName = "Umayanga",
            isActive = true
        };
        CustomerDTO customerDTO = _mapper.Map<CustomerDTO>(customer);
        return View();
    }
    ```


