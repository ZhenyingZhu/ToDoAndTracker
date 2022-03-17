# IO.Swagger.Api.TaskApi

All URIs are relative to *https://zhenying.io/api/beta*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTask**](TaskApi.md#addtask) | **POST** /tasks | Add a new task
[**DeleteTask**](TaskApi.md#deletetask) | **DELETE** /tasks/{tid} | Deletes a task
[**GetTaskById**](TaskApi.md#gettaskbyid) | **GET** /tasks/{tid} | Find task by ID
[**GetTasks**](TaskApi.md#gettasks) | **GET** /tasks | Get all the tasks the user involves in
[**UpdateTask**](TaskApi.md#updatetask) | **PUT** /tasks/{tid} | Updates a task with form data. Can be used to add an event

<a name="addtask"></a>
# **AddTask**
> Task AddTask (Task body, string apiKey = null)

Add a new task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddTaskExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskApi();
            var body = new Task(); // Task | 
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Add a new task
                Task result = apiInstance.AddTask(body, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.AddTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Task**](Task.md)|  | 
 **apiKey** | **string**|  | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetask"></a>
# **DeleteTask**
> void DeleteTask (long? tid, string apiKey = null)

Deletes a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskApi();
            var tid = 789;  // long? | Task id to delete
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Deletes a task
                apiInstance.DeleteTask(tid, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.DeleteTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **long?**| Task id to delete | 
 **apiKey** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettaskbyid"></a>
# **GetTaskById**
> Task GetTaskById (long? tid, string apiKey = null)

Find task by ID

Returns a single task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskApi();
            var tid = 789;  // long? | ID of task to return
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Find task by ID
                Task result = apiInstance.GetTaskById(tid, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.GetTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **long?**| ID of task to return | 
 **apiKey** | **string**|  | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettasks"></a>
# **GetTasks**
> List<Task> GetTasks (string apiKey = null)

Get all the tasks the user involves in

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskApi();
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Get all the tasks the user involves in
                List&lt;Task&gt; result = apiInstance.GetTasks(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.GetTasks: " + e.Message );
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

[**List<Task>**](Task.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetask"></a>
# **UpdateTask**
> void UpdateTask (Task body, long? tid, string apiKey = null)

Updates a task with form data. Can be used to add an event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskApi();
            var body = new Task(); // Task | 
            var tid = 789;  // long? | ID of the task that needs to be updated
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Updates a task with form data. Can be used to add an event
                apiInstance.UpdateTask(body, tid, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Task**](Task.md)|  | 
 **tid** | **long?**| ID of the task that needs to be updated | 
 **apiKey** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
