using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Components;

namespace HCM.Client
{
    public class ItemModel : ComponentBase
    {
        public string Title => "Render Markdown";

        public string MarkdownContent { get; set; }

        protected override void OnInitialized()
        {
            MarkdownContent = GetInitialMarkdown();
        }

        private string GetInitialMarkdown()
        {
            var renderedMarkdown = "## Calling Web API with C#\r\n\r\nThe purpose of this document is to explain and exemplify, how to make calls to our NHS Web Api, using C# programming language.\r\n\r\nRestful APIs support different HTTP methods, like:\r\n\r\n- Get\r\n- Post\r\n- Put\r\n- Delete\r\n\r\nTo know more about these Rest Verbs, please check [here](https://restfulapi.net/http-methods/).\r\n\r\n### Get Method\r\n\r\nMost of our Web Api endpoints retrieve information using the Get Method.\r\n\r\nTo make a call to one of these endpoints, first we need to import `System.Net.Http` namespace:\r\n\r\n```csharp\r\nusing System.Net.Http;\r\n```\r\n\r\nThen we use an instance of the `HttpClient` to make an Http Request:\r\n\r\n```csharp\r\nvar client = new HttpClient();\r\n\r\n//Use the url and parameters required for the particular endpoint\r\nstring url = \"http://api.newhomesource.com/api/v2/detail/partner?partnerId=1&excludeBrands=1&excludeBuilders=1\";\r\n\r\n//Make the http request\r\nHttpResponseMessage response = await client.GetAsync(url);\r\n```\r\n\r\nTo parse the results to C# objects we provide a Nuget Package with all the Objects returned by the API or received in the Post Endpoints, you can find a documentation to install this Nuget package [here](https://builderhomesite.atlassian.net/wiki/spaces/BDXWEBAPI/pages/99320105/BDX+Web+API+Nuget+Package).\r\n\r\nJust as an example, the previous code snippet showed a call to the `api/v2/detail/partner` endpoint, so to parse this result we need an Object with all the properties that this endpoint return, or at least the ones we need in our application.\r\n\r\nIn this example we are retrieving partners, so, we will use the `ApiPartner` class from the `Bdx.Web.Api.Objects` [Nuget](https://www.nuget.org/). Which contains at least these properties:\r\n\r\n```csharp\r\nclass ApiPartner\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string SiteUrl { get; set; }\r\n    public string UsesMatchMaker { get; set; }\r\n    public short MaskIndex { get; set; }\r\n    public string PartnerLogo { get; set; }\r\n    public string AllowRegistration { get; set; }  \r\n    public string BrandPartnerName { get; set; }\r\n    public string FooterShowAboutUs { get; set; }\r\n}\r\n```\r\n\r\nMost of our API Endpoints wrap the results in an generic Object called `ApiResultModel`, which contains generic info like a Response `Status`, execution `Time`, and whether there was an `Error` or `ErrorMessage`.  And the API response itself in a property called `Result`.  This class is also in our `Bdx.Web.Api.Objects` Nuget, but here there\u2019s the source code for reference:\r\n\r\n```csharp\r\nclass ApiResultModel<T>\r\n{\r\n    public ApiResultModel()\r\n    {\r\n        Status = \"OK\";\r\n    }\r\n    \r\n    /// <summary>Response Time</summary>\r\n    public string Time { get; set; }\r\n\r\n    /// <summary>Errors found</summary>\r\n    public Exception Error { get; set; }\r\n\r\n    /// <summary>Error message</summary>\r\n    public string ErrorMessage { get; set; }\r\n\r\n    /// <summary>Status Code</summary>\r\n    public string Status { get; set; }\r\n\r\n    /// <summary>Server which sends the response</summary>\r\n    public string Server { get; set; }\r\n\r\n    /// <summary>Result showed</summary>\r\n    public T Result { get; set; }\r\n}\r\n```\r\n\r\nFinally, to de-serialize the JSON result as the expected object, we can use the `ReadAsAsync` extension method, from the`System.Net.Http.Formatting` assembly, and parse the result like this:\r\n\r\n```csharp\r\nApiResultModel<ApiPartner> apiResult;\r\n\r\nif (response.IsSuccessStatusCode)\r\n{\r\n    apiResult = await response.Content.ReadAsAsync<ApiResultModel<ApiPartner>>();\r\n\r\n    if(apiResult.Status == \"OK\")\r\n        return apiResult.Result;\r\n    else\r\n        //Process Error\r\n        return apiResult.Error;\r\n}\r\n```\r\n\r\n---------\r\n\r\n### Post Methods\r\n\r\n...";
            return renderedMarkdown;
        }
    }
}