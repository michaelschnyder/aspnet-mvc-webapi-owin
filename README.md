# ASP.NET MVC Web API OWIN Sample

This sample solution shows how to integrated a Web API project into an existing ASP.NET MVC Application by using the OWIN-Pipeline. For details to OWIN, see: http://owin.org/

The solution is splitted into multiple projects to show this concept, configuration and related NuGet Packages

## MyProject.Web.Api
This is an almost empty Web API Project with one simple controller under `api/status`

## MyProject.Web.SefHost
A selfhost application (based on OWIN and HttpListener) to host the Web API in a console application

## MyProject.Web.WebHost
Similar to the Project "MyProject.Web.SelfHost" but hosted inside a ASP.NET Application. 
This shows the minimal setup to host a OWIN-based coponent (ASP.NET Web API in this case) in IIS

## MyProject.Web.WebApp
This is the combined MVC and Web API Project, together hosted in a single ASP.NET Application in IIS or IIS Express
