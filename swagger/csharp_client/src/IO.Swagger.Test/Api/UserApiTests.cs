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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserApi
            //Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User body = null;
            //instance.CreateUser(body);
            
        }
        /// <summary>
        /// Test CreateUsersWithArrayInput
        /// </summary>
        [Test]
        public void CreateUsersWithArrayInputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<User> body = null;
            //instance.CreateUsersWithArrayInput(body);
            
        }
        /// <summary>
        /// Test CreateUsersWithListInput
        /// </summary>
        [Test]
        public void CreateUsersWithListInputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<User> body = null;
            //instance.CreateUsersWithListInput(body);
            
        }
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.DeleteUser(username);
            
        }
        /// <summary>
        /// Test GetUserByName
        /// </summary>
        [Test]
        public void GetUserByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetUserByName(username);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        /// <summary>
        /// Test LoginUser
        /// </summary>
        [Test]
        public void LoginUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //var response = instance.LoginUser(username, password);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test LogoutUser
        /// </summary>
        [Test]
        public void LogoutUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.LogoutUser();
            
        }
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User body = null;
            //string username = null;
            //instance.UpdateUser(body, username);
            
        }
    }

}
