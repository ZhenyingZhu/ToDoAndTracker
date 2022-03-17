# ToDoAndTracker.ProjectApi

All URIs are relative to *https://zhenying.io/api/beta*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addProject**](ProjectApi.md#addProject) | **POST** /projects | Add a new project
[**deleteProject**](ProjectApi.md#deleteProject) | **DELETE** /projects/{pid} | Deletes a project
[**getProjectById**](ProjectApi.md#getProjectById) | **GET** /projects/{pid} | Find project by ID
[**getProjects**](ProjectApi.md#getProjects) | **GET** /projects | Get all the projects the user involves in
[**updateProject**](ProjectApi.md#updateProject) | **PUT** /projects/{pid} | Updates a project with form data. Can add a task

<a name="addProject"></a>
# **addProject**
> Project addProject(body, opts)

Add a new project

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

let apiInstance = new ToDoAndTracker.ProjectApi();
let body = new ToDoAndTracker.Project(); // Project | 
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.addProject(body, opts, (error, data, response) => {
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
 **body** | [**Project**](Project.md)|  | 
 **apiKey** | **String**|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteProject"></a>
# **deleteProject**
> deleteProject(pid, opts)

Deletes a project

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

let apiInstance = new ToDoAndTracker.ProjectApi();
let pid = 789; // Number | Project id to delete
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.deleteProject(pid, opts, (error, data, response) => {
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
 **pid** | **Number**| Project id to delete | 
 **apiKey** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getProjectById"></a>
# **getProjectById**
> Project getProjectById(pid, opts)

Find project by ID

Returns a single project

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

let apiInstance = new ToDoAndTracker.ProjectApi();
let pid = 789; // Number | ID of project to return
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.getProjectById(pid, opts, (error, data, response) => {
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
 **pid** | **Number**| ID of project to return | 
 **apiKey** | **String**|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getProjects"></a>
# **getProjects**
> [Project] getProjects(opts)

Get all the projects the user involves in

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

let apiInstance = new ToDoAndTracker.ProjectApi();
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.getProjects(opts, (error, data, response) => {
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

[**[Project]**](Project.md)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateProject"></a>
# **updateProject**
> updateProject(body, pid, opts)

Updates a project with form data. Can add a task

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

let apiInstance = new ToDoAndTracker.ProjectApi();
let body = new ToDoAndTracker.Project(); // Project | 
let pid = 789; // Number | ID of the project that needs to be updated
let opts = { 
  'apiKey': "apiKey_example" // String | 
};
apiInstance.updateProject(body, pid, opts, (error, data, response) => {
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
 **body** | [**Project**](Project.md)|  | 
 **pid** | **Number**| ID of the project that needs to be updated | 
 **apiKey** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[api_key](../README.md#api_key), [todotracker_auth](../README.md#todotracker_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

