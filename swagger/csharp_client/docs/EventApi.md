# IO.Swagger.Api.EventApi

All URIs are relative to *https://zhenying.io/api/beta*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEvent**](EventApi.md#deleteevent) | **DELETE** /tasks/{tid}/events/{eid} | Deletes an event
[**GetEventById**](EventApi.md#geteventbyid) | **GET** /tasks/{tid}/events/{eid} | Get an event by id
[**UpdateEvent**](EventApi.md#updateevent) | **PUT** /tasks/{tid}/events/{eid} | Update an event by id

<a name="deleteevent"></a>
# **DeleteEvent**
> void DeleteEvent (long? tid, long? eid, string apiKey = null)

Deletes an event

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEventExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var tid = 789;  // long? | Task id to delete
            var eid = 789;  // long? | ID of the event to return
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Deletes an event
                apiInstance.DeleteEvent(tid, eid, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.DeleteEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **long?**| Task id to delete | 
 **eid** | **long?**| ID of the event to return | 
 **apiKey** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="geteventbyid"></a>
# **GetEventById**
> ModelEvent GetEventById (long? tid, long? eid, string apiKey = null)

Get an event by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var tid = 789;  // long? | ID of the task to return event
            var eid = 789;  // long? | ID of the event to return
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Get an event by id
                ModelEvent result = apiInstance.GetEventById(tid, eid, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.GetEventById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **long?**| ID of the task to return event | 
 **eid** | **long?**| ID of the event to return | 
 **apiKey** | **string**|  | [optional] 

### Return type

[**ModelEvent**](ModelEvent.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateevent"></a>
# **UpdateEvent**
> ModelEvent UpdateEvent (long? tid, long? eid, string apiKey = null)

Update an event by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateEventExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");
            // Configure OAuth2 access token for authorization: todotracker_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var tid = 789;  // long? | ID of the task to return event
            var eid = 789;  // long? | ID of the event to return
            var apiKey = apiKey_example;  // string |  (optional) 

            try
            {
                // Update an event by id
                ModelEvent result = apiInstance.UpdateEvent(tid, eid, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.UpdateEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **long?**| ID of the task to return event | 
 **eid** | **long?**| ID of the event to return | 
 **apiKey** | **string**|  | [optional] 

### Return type

[**ModelEvent**](ModelEvent.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
