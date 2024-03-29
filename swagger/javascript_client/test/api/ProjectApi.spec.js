/*
 * ToDo and Tracker
 * For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * OpenAPI spec version: 0.0.1
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 3.0.33
 *
 * Do not edit the class manually.
 *
 */
(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.ToDoAndTracker);
  }
}(this, function(expect, ToDoAndTracker) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new ToDoAndTracker.ProjectApi();
  });

  describe('(package)', function() {
    describe('ProjectApi', function() {
      describe('addProject', function() {
        it('should call addProject successfully', function(done) {
          // TODO: uncomment, update parameter values for addProject call and complete the assertions
          /*
          var opts = {};

          instance.addProject(body, opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(ToDoAndTracker.Project);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('deleteProject', function() {
        it('should call deleteProject successfully', function(done) {
          // TODO: uncomment, update parameter values for deleteProject call
          /*
          var opts = {};

          instance.deleteProject(pid, opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('getProjectById', function() {
        it('should call getProjectById successfully', function(done) {
          // TODO: uncomment, update parameter values for getProjectById call and complete the assertions
          /*
          var opts = {};

          instance.getProjectById(pid, opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(ToDoAndTracker.Project);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('getProjects', function() {
        it('should call getProjects successfully', function(done) {
          // TODO: uncomment, update parameter values for getProjects call and complete the assertions
          /*
          var opts = {};

          instance.getProjects(opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            let dataCtr = data;
            expect(dataCtr).to.be.an(Array);
            expect(dataCtr).to.not.be.empty();
            for (let p in dataCtr) {
              let data = dataCtr[p];
              expect(data).to.be.a(ToDoAndTracker.Project);
            }

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('updateProject', function() {
        it('should call updateProject successfully', function(done) {
          // TODO: uncomment, update parameter values for updateProject call
          /*
          var opts = {};

          instance.updateProject(body, pid, opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
    });
  });

}));
