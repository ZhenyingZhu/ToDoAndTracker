# ToDoAndTracker.TaskApi

All URIs are relative to *https://zhenying.io/api/beta*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addTask**](TaskApi.md#addTask) | **POST** /tasks | Add a new task
[**deleteTask**](TaskApi.md#deleteTask) | **DELETE** /tasks/{tid} | Deletes a task
[**getTaskById**](TaskApi.md#getTaskById) | **GET** /tasks/{tid} | Find task by ID
[**getTasks**](TaskApi.md#getTasks) | **GET** /tasks | Get all the tasks the user involves in
[**updateTask**](TaskApi.md#updateTask) | **PUT** /tasks/{tid} | Updates a task with form data. Can be used to add an event

<a name="addTask"></a>
# **addTask**
> Task addTask(body, opts)

Add a new task

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

let apiInstance = new ToDoAndTracker.TaskApi();
let body = new ToDoAndTracker.Task(); // Task | 
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.addTask(body, opts, (error, data, response) => {
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
 **body** | [**Task**](Task.md)|  | 
 **apiKey** | **String**|  | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteTask"></a>
# **deleteTask**
> deleteTask(tid, opts)

Deletes a task

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

let apiInstance = new ToDoAndTracker.TaskApi();
let tid = 789; // Number | Task id to delete
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.deleteTask(tid, opts, (error, data, response) => {
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
 **apiKey** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getTaskById"></a>
# **getTaskById**
> Task getTaskById(tid, opts)

Find task by ID

Returns a single task

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

let apiInstance = new ToDoAndTracker.TaskApi();
let tid = 789; // Number | ID of task to return
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.getTaskById(tid, opts, (error, data, response) => {
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
 **tid** | **Number**| ID of task to return | 
 **apiKey** | **String**|  | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getTasks"></a>
# **getTasks**
> [Task] getTasks(opts)

Get all the tasks the user involves in

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

let apiInstance = new ToDoAndTracker.TaskApi();
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.getTasks(opts, (error, data, response) => {
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
 **apiKey** | **String**|  | [optional] 

### Return type

[**[Task]**](Task.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateTask"></a>
# **updateTask**
> updateTask(body, tid, opts)

Updates a task with form data. Can be used to add an event

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

let apiInstance = new ToDoAndTracker.TaskApi();
let body = new ToDoAndTracker.Task(); // Task | 
let tid = 789; // Number | ID of the task that needs to be updated
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.updateTask(body, tid, opts, (error, data, response) => {
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
 **body** | [**Task**](Task.md)|  | 
 **tid** | **Number**| ID of the task that needs to be updated | 
 **apiKey** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

