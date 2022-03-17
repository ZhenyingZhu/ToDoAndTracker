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
    instance = new ToDoAndTracker.EventApi();
  });

  describe('(package)', function() {
    describe('EventApi', function() {
      describe('deleteEvent', function() {
        it('should call deleteEvent successfully', function(done) {
          // TODO: uncomment, update parameter values for deleteEvent call
          /*
          var opts = {};

          instance.deleteEvent(tid, eid, opts, function(error, data, response) {
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
      describe('getEventById', function() {
        it('should call getEventById successfully', function(done) {
          // TODO: uncomment, update parameter values for getEventById call and complete the assertions
          /*
          var opts = {};

          instance.getEventById(tid, eid, opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(ToDoAndTracker.Event);

            done();
          });
          */
          // TODO: uncomment and complete method invocation above, then delete this line and the next:
          done();
        });
      });
      describe('updateEvent', function() {
        it('should call updateEvent successfully', function(done) {
          // TODO: uncomment, update parameter values for updateEvent call and complete the assertions
          /*
          var opts = {};

          instance.updateEvent(tid, eid, opts, function(error, data, response) {
            if (error) {
              done(error);
              return;
            }
            // TODO: update response assertions
            expect(data).to.be.a(ToDoAndTracker.Event);

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
