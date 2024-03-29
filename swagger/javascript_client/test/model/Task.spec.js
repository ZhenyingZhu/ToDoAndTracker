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

  describe('(package)', function() {
    describe('Task', function() {
      beforeEach(function() {
        instance = new ToDoAndTracker.Task();
      });

      it('should create an instance of Task', function() {
        // TODO: update the code to test Task
        expect(instance).to.be.a(ToDoAndTracker.Task);
      });

      it('should have the property id (base name: "id")', function() {
        // TODO: update the code to test the property id
        expect(instance).to.have.property('id');
        // expect(instance.id).to.be(expectedValueLiteral);
      });

      it('should have the property name (base name: "name")', function() {
        // TODO: update the code to test the property name
        expect(instance).to.have.property('name');
        // expect(instance.name).to.be(expectedValueLiteral);
      });

      it('should have the property projectIds (base name: "projectIds")', function() {
        // TODO: update the code to test the property projectIds
        expect(instance).to.have.property('projectIds');
        // expect(instance.projectIds).to.be(expectedValueLiteral);
      });

      it('should have the property priority (base name: "priority")', function() {
        // TODO: update the code to test the property priority
        expect(instance).to.have.property('priority');
        // expect(instance.priority).to.be(expectedValueLiteral);
      });

      it('should have the property stepNum (base name: "stepNum")', function() {
        // TODO: update the code to test the property stepNum
        expect(instance).to.have.property('stepNum');
        // expect(instance.stepNum).to.be(expectedValueLiteral);
      });

      it('should have the property expectedStartTime (base name: "expectedStartTime")', function() {
        // TODO: update the code to test the property expectedStartTime
        expect(instance).to.have.property('expectedStartTime');
        // expect(instance.expectedStartTime).to.be(expectedValueLiteral);
      });

      it('should have the property expectedFinishTime (base name: "expectedFinishTime")', function() {
        // TODO: update the code to test the property expectedFinishTime
        expect(instance).to.have.property('expectedFinishTime');
        // expect(instance.expectedFinishTime).to.be(expectedValueLiteral);
      });

      it('should have the property expectedTimeDuration (base name: "expectedTimeDuration")', function() {
        // TODO: update the code to test the property expectedTimeDuration
        expect(instance).to.have.property('expectedTimeDuration');
        // expect(instance.expectedTimeDuration).to.be(expectedValueLiteral);
      });

      it('should have the property state (base name: "state")', function() {
        // TODO: update the code to test the property state
        expect(instance).to.have.property('state');
        // expect(instance.state).to.be(expectedValueLiteral);
      });

      it('should have the property recurRule (base name: "recurRule")', function() {
        // TODO: update the code to test the property recurRule
        expect(instance).to.have.property('recurRule');
        // expect(instance.recurRule).to.be(expectedValueLiteral);
      });

      it('should have the property events (base name: "events")', function() {
        // TODO: update the code to test the property events
        expect(instance).to.have.property('events');
        // expect(instance.events).to.be(expectedValueLiteral);
      });

      it('should have the property assignedUser (base name: "assignedUser")', function() {
        // TODO: update the code to test the property assignedUser
        expect(instance).to.have.property('assignedUser');
        // expect(instance.assignedUser).to.be(expectedValueLiteral);
      });

    });
  });

}));
