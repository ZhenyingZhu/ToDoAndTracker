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
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class UserApiController : ControllerBase
    { 
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="body">Created user object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [Route("/api/beta/user")]
        [ValidateModelState]
        [SwaggerOperation("CreateUser")]
        public virtual IActionResult CreateUser([FromBody]User body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">List of user object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [Route("/api/beta/user/createWithArray")]
        [ValidateModelState]
        [SwaggerOperation("CreateUsersWithArrayInput")]
        public virtual IActionResult CreateUsersWithArrayInput([FromBody]List<User> body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <param name="body">List of user object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [Route("/api/beta/user/createWithList")]
        [ValidateModelState]
        [SwaggerOperation("CreateUsersWithListInput")]
        public virtual IActionResult CreateUsersWithListInput([FromBody]List<User> body)
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="username">The name that needs to be deleted</param>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpDelete]
        [Route("/api/beta/user/{username}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteUser")]
        public virtual IActionResult DeleteUser([FromRoute][Required]string username)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing. </param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/api/beta/user/{username}")]
        [ValidateModelState]
        [SwaggerOperation("GetUserByName")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "successful operation")]
        public virtual IActionResult GetUserByName([FromRoute][Required]string username)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(User));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"firstName\" : \"firstName\",\n  \"lastName\" : \"lastName\",\n  \"password\" : \"password\",\n  \"userStatus\" : 6,\n  \"phone\" : \"phone\",\n  \"id\" : 0,\n  \"email\" : \"email\",\n  \"username\" : \"username\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<User>(exampleJson)
                        : default(User);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Logs user into the system
        /// </summary>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username/password supplied</response>
        [HttpGet]
        [Route("/api/beta/user/login")]
        [ValidateModelState]
        [SwaggerOperation("LoginUser")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "successful operation")]
        public virtual IActionResult LoginUser([FromQuery][Required()]string username, [FromQuery][Required()]string password)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<string>(exampleJson)
                        : default(string);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Logs out current logged in user session
        /// </summary>
        /// <response code="0">successful operation</response>
        [HttpGet]
        [Route("/api/beta/user/logout")]
        [ValidateModelState]
        [SwaggerOperation("LogoutUser")]
        public virtual IActionResult LogoutUser()
        { 
            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Updated user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="body">Updated user object</param>
        /// <param name="username">name that need to be updated</param>
        /// <response code="400">Invalid user supplied</response>
        /// <response code="404">User not found</response>
        [HttpPut]
        [Route("/api/beta/user/{username}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateUser")]
        public virtual IActionResult UpdateUser([FromBody]User body, [FromRoute][Required]string username)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }
    }
}
