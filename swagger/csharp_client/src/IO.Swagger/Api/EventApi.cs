/* 
 * ToDo and Tracker
 *
 * For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IEventApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Deletes an event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns></returns>
        void DeleteEvent (long? tid, long? eid, string apiKey = null);

        /// <summary>
        /// Deletes an event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEventWithHttpInfo (long? tid, long? eid, string apiKey = null);
        /// <summary>
        /// Get an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ModelEvent</returns>
        ModelEvent GetEventById (long? tid, long? eid, string apiKey = null);

        /// <summary>
        /// Get an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of ModelEvent</returns>
        ApiResponse<ModelEvent> GetEventByIdWithHttpInfo (long? tid, long? eid, string apiKey = null);
        /// <summary>
        /// Update an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ModelEvent</returns>
        ModelEvent UpdateEvent (long? tid, long? eid, string apiKey = null);

        /// <summary>
        /// Update an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of ModelEvent</returns>
        ApiResponse<ModelEvent> UpdateEventWithHttpInfo (long? tid, long? eid, string apiKey = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Deletes an event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEventAsync (long? tid, long? eid, string apiKey = null);

        /// <summary>
        /// Deletes an event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEventAsyncWithHttpInfo (long? tid, long? eid, string apiKey = null);
        /// <summary>
        /// Get an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ModelEvent</returns>
        System.Threading.Tasks.Task<ModelEvent> GetEventByIdAsync (long? tid, long? eid, string apiKey = null);

        /// <summary>
        /// Get an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse (ModelEvent)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelEvent>> GetEventByIdAsyncWithHttpInfo (long? tid, long? eid, string apiKey = null);
        /// <summary>
        /// Update an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ModelEvent</returns>
        System.Threading.Tasks.Task<ModelEvent> UpdateEventAsync (long? tid, long? eid, string apiKey = null);

        /// <summary>
        /// Update an event by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse (ModelEvent)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelEvent>> UpdateEventAsyncWithHttpInfo (long? tid, long? eid, string apiKey = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class EventApi : IEventApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class
        /// </summary>
        /// <returns></returns>
        public EventApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Deletes an event 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns></returns>
        public void DeleteEvent (long? tid, long? eid, string apiKey = null)
        {
             DeleteEventWithHttpInfo(tid, eid, apiKey);
        }

        /// <summary>
        /// Deletes an event 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEventWithHttpInfo (long? tid, long? eid, string apiKey = null)
        {
            // verify the required parameter 'tid' is set
            if (tid == null)
                throw new ApiException(400, "Missing required parameter 'tid' when calling EventApi->DeleteEvent");
            // verify the required parameter 'eid' is set
            if (eid == null)
                throw new ApiException(400, "Missing required parameter 'eid' when calling EventApi->DeleteEvent");

            var localVarPath = "/tasks/{tid}/events/{eid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tid != null) localVarPathParams.Add("tid", this.Configuration.ApiClient.ParameterToString(tid)); // path parameter
            if (eid != null) localVarPathParams.Add("eid", this.Configuration.ApiClient.ParameterToString(eid)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }
            // authentication (todotracker_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Deletes an event 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteEventAsync (long? tid, long? eid, string apiKey = null)
        {
             await DeleteEventAsyncWithHttpInfo(tid, eid, apiKey);

        }

        /// <summary>
        /// Deletes an event 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">Task id to delete</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEventAsyncWithHttpInfo (long? tid, long? eid, string apiKey = null)
        {
            // verify the required parameter 'tid' is set
            if (tid == null)
                throw new ApiException(400, "Missing required parameter 'tid' when calling EventApi->DeleteEvent");
            // verify the required parameter 'eid' is set
            if (eid == null)
                throw new ApiException(400, "Missing required parameter 'eid' when calling EventApi->DeleteEvent");

            var localVarPath = "/tasks/{tid}/events/{eid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tid != null) localVarPathParams.Add("tid", this.Configuration.ApiClient.ParameterToString(tid)); // path parameter
            if (eid != null) localVarPathParams.Add("eid", this.Configuration.ApiClient.ParameterToString(eid)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }
            // authentication (todotracker_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ModelEvent</returns>
        public ModelEvent GetEventById (long? tid, long? eid, string apiKey = null)
        {
             ApiResponse<ModelEvent> localVarResponse = GetEventByIdWithHttpInfo(tid, eid, apiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of ModelEvent</returns>
        public ApiResponse< ModelEvent > GetEventByIdWithHttpInfo (long? tid, long? eid, string apiKey = null)
        {
            // verify the required parameter 'tid' is set
            if (tid == null)
                throw new ApiException(400, "Missing required parameter 'tid' when calling EventApi->GetEventById");
            // verify the required parameter 'eid' is set
            if (eid == null)
                throw new ApiException(400, "Missing required parameter 'eid' when calling EventApi->GetEventById");

            var localVarPath = "/tasks/{tid}/events/{eid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tid != null) localVarPathParams.Add("tid", this.Configuration.ApiClient.ParameterToString(tid)); // path parameter
            if (eid != null) localVarPathParams.Add("eid", this.Configuration.ApiClient.ParameterToString(eid)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }
            // authentication (todotracker_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEventById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelEvent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelEvent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelEvent)));
        }

        /// <summary>
        /// Get an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ModelEvent</returns>
        public async System.Threading.Tasks.Task<ModelEvent> GetEventByIdAsync (long? tid, long? eid, string apiKey = null)
        {
             ApiResponse<ModelEvent> localVarResponse = await GetEventByIdAsyncWithHttpInfo(tid, eid, apiKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse (ModelEvent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelEvent>> GetEventByIdAsyncWithHttpInfo (long? tid, long? eid, string apiKey = null)
        {
            // verify the required parameter 'tid' is set
            if (tid == null)
                throw new ApiException(400, "Missing required parameter 'tid' when calling EventApi->GetEventById");
            // verify the required parameter 'eid' is set
            if (eid == null)
                throw new ApiException(400, "Missing required parameter 'eid' when calling EventApi->GetEventById");

            var localVarPath = "/tasks/{tid}/events/{eid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tid != null) localVarPathParams.Add("tid", this.Configuration.ApiClient.ParameterToString(tid)); // path parameter
            if (eid != null) localVarPathParams.Add("eid", this.Configuration.ApiClient.ParameterToString(eid)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }
            // authentication (todotracker_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEventById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelEvent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelEvent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelEvent)));
        }

        /// <summary>
        /// Update an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ModelEvent</returns>
        public ModelEvent UpdateEvent (long? tid, long? eid, string apiKey = null)
        {
             ApiResponse<ModelEvent> localVarResponse = UpdateEventWithHttpInfo(tid, eid, apiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of ModelEvent</returns>
        public ApiResponse< ModelEvent > UpdateEventWithHttpInfo (long? tid, long? eid, string apiKey = null)
        {
            // verify the required parameter 'tid' is set
            if (tid == null)
                throw new ApiException(400, "Missing required parameter 'tid' when calling EventApi->UpdateEvent");
            // verify the required parameter 'eid' is set
            if (eid == null)
                throw new ApiException(400, "Missing required parameter 'eid' when calling EventApi->UpdateEvent");

            var localVarPath = "/tasks/{tid}/events/{eid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tid != null) localVarPathParams.Add("tid", this.Configuration.ApiClient.ParameterToString(tid)); // path parameter
            if (eid != null) localVarPathParams.Add("eid", this.Configuration.ApiClient.ParameterToString(eid)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }
            // authentication (todotracker_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelEvent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelEvent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelEvent)));
        }

        /// <summary>
        /// Update an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ModelEvent</returns>
        public async System.Threading.Tasks.Task<ModelEvent> UpdateEventAsync (long? tid, long? eid, string apiKey = null)
        {
             ApiResponse<ModelEvent> localVarResponse = await UpdateEventAsyncWithHttpInfo(tid, eid, apiKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an event by id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tid">ID of the task to return event</param>
        /// <param name="eid">ID of the event to return</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse (ModelEvent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelEvent>> UpdateEventAsyncWithHttpInfo (long? tid, long? eid, string apiKey = null)
        {
            // verify the required parameter 'tid' is set
            if (tid == null)
                throw new ApiException(400, "Missing required parameter 'tid' when calling EventApi->UpdateEvent");
            // verify the required parameter 'eid' is set
            if (eid == null)
                throw new ApiException(400, "Missing required parameter 'eid' when calling EventApi->UpdateEvent");

            var localVarPath = "/tasks/{tid}/events/{eid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tid != null) localVarPathParams.Add("tid", this.Configuration.ApiClient.ParameterToString(tid)); // path parameter
            if (eid != null) localVarPathParams.Add("eid", this.Configuration.ApiClient.ParameterToString(eid)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", this.Configuration.ApiClient.ParameterToString(apiKey)); // header parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = this.Configuration.GetApiKeyWithPrefix("api_key");
            }
            // authentication (todotracker_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelEvent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelEvent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelEvent)));
        }

    }
}
