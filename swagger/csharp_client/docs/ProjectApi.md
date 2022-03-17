# IO.Swagger.Api.ProjectApi

All URIs are relative to *https://zhenying.io/api/beta*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProject**](ProjectApi.md#addproject) | **POST** /projects | Add a new project
[**DeleteProject**](ProjectApi.md#deleteproject) | **DELETE** /projects/{pid} | Deletes a project
[**GetProjectById**](ProjectApi.md#getprojectbyid) | **GET** /projects/{pid} | Find project by ID
[**GetProjects**](ProjectApi.md#getprojects) | **GET** /projects | Get all the projects the user involves in
[**UpdateProject**](ProjectApi.md#updateproject) | **PUT** /projects/{pid} | Updates a project with form data. Can add a task

<a name="addproject"></a>
# **AddProject**
> Project AddProject (Project body, string apiKey = null)

Add a new project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectApi();
            var body = new Project(); // Project | 
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Add a new project
                Project result = apiInstance.AddProject(body, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.AddProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Project**](Project.md)|  | 
 **apiKey** | **string**|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproject"></a>
# **DeleteProject**
> void DeleteProject (long? pid, string apiKey = null)

Deletes a project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectApi();
            var pid = 789;  // long? | Project id to delete
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Deletes a project
                apiInstance.DeleteProject(pid, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.DeleteProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | **long?**| Project id to delete | 
 **apiKey** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprojectbyid"></a>
# **GetProjectById**
> Project GetProjectById (long? pid, string apiKey = null)

Find project by ID

Returns a single project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProjectByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectApi();
            var pid = 789;  // long? | ID of project to return
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Find project by ID
                Project result = apiInstance.GetProjectById(pid, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjectById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | **long?**| ID of project to return | 
 **apiKey** | **string**|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprojects"></a>
# **GetProjects**
> List<Project> GetProjects (string apiKey = null)

Get all the projects the user involves in

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectApi();
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Get all the projects the user involves in
                List&lt;Project&gt; result = apiInstance.GetProjects(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.GetProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | [optional] 

### Return type

[**List<Project>**](Project.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproject"></a>
# **UpdateProject**
> void UpdateProject (Project body, long? pid, string apiKey = null)

Updates a project with form data. Can add a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectApi();
            var body = new Project(); // Project | 
            var pid = 789;  // long? | ID of the project that needs to be updated
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Updates a project with form data. Can add a task
                apiInstance.UpdateProject(body, pid, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.UpdateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Project**](Project.md)|  | 
 **pid** | **long?**| ID of the project that needs to be updated | 
 **apiKey** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
