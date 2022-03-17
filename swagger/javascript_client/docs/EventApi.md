# ToDoAndTracker.EventApi

All URIs are relative to *https://zhenying.io/api/beta*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteEvent**](EventApi.md#deleteEvent) | **DELETE** /tasks/{tid}/events/{eid} | Deletes an event
[**getEventById**](EventApi.md#getEventById) | **GET** /tasks/{tid}/events/{eid} | Get an event by id
[**updateEvent**](EventApi.md#updateEvent) | **PUT** /tasks/{tid}/events/{eid} | Update an event by id

<a name="deleteEvent"></a>
# **deleteEvent**
> deleteEvent(tid, eid, opts)

Deletes an event

### Example
```javascript
import {ToDoAndTracker} from 'to_do_and_tracker';
let defaultClient = ToDoAndTracker.ApiClient.instance;

// Configure API key authorization: api_key
let api_key = defaultClient.authentications['api_key'];
api_key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api_key.apiKeyPrefix = 'Token';

// Configure OAuth2 access token for authorization: todotracker_auth
let todotracker_auth = defaultClient.authentications['todotracker_auth'];
todotracker_auth.accessToken = 'YOUR ACCESS TOKEN';

let apiInstance = new ToDoAndTracker.EventApi();
let tid = 789; // Number | Task id to delete
let eid = 789; // Number | ID of the event to return
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.deleteEvent(tid, eid, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **Number**| Task id to delete | 
 **eid** | **Number**| ID of the event to return | 
 **apiKey** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getEventById"></a>
# **getEventById**
> Event getEventById(tid, eid, opts)

Get an event by id

### Example
```javascript
import {ToDoAndTracker} from 'to_do_and_tracker';
let defaultClient = ToDoAndTracker.ApiClient.instance;

// Configure API key authorization: api_key
let api_key = defaultClient.authentications['api_key'];
api_key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api_key.apiKeyPrefix = 'Token';

// Configure OAuth2 access token for authorization: todotracker_auth
let todotracker_auth = defaultClient.authentications['todotracker_auth'];
todotracker_auth.accessToken = 'YOUR ACCESS TOKEN';

let apiInstance = new ToDoAndTracker.EventApi();
let tid = 789; // Number | ID of the task to return event
let eid = 789; // Number | ID of the event to return
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.getEventById(tid, eid, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **Number**| ID of the task to return event | 
 **eid** | **Number**| ID of the event to return | 
 **apiKey** | **String**|  | [optional] 

### Return type

[**Event**](Event.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateEvent"></a>
# **updateEvent**
> Event updateEvent(tid, eid, opts)

Update an event by id

### Example
```javascript
import {ToDoAndTracker} from 'to_do_and_tracker';
let defaultClient = ToDoAndTracker.ApiClient.instance;

// Configure API key authorization: api_key
let api_key = defaultClient.authentications['api_key'];
api_key.apiKey = 'YOUR API KEY';
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//api_key.apiKeyPrefix = 'Token';

// Configure OAuth2 access token for authorization: todotracker_auth
let todotracker_auth = defaultClient.authentications['todotracker_auth'];
todotracker_auth.accessToken = 'YOUR ACCESS TOKEN';

let apiInstance = new ToDoAndTracker.EventApi();
let tid = 789; // Number | ID of the task to return event
let eid = 789; // Number | ID of the event to return
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.updateEvent(tid, eid, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tid** | **Number**| ID of the task to return event | 
 **eid** | **Number**| ID of the event to return | 
 **apiKey** | **String**|  | [optional] 

### Return type

[**Event**](Event.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

