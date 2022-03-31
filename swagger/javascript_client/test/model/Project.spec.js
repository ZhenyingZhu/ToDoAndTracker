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
    describe('Project', function() {
      beforeEach(function() {
        instance = new ToDoAndTracker.Project();
      });

      it('should create an instance of Project', function() {
        // TODO: update the code to test Project
        expect(instance).to.be.a(ToDoAndTracker.Project);
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

      it('should have the property createDate (base name: "createDate")', function() {
        // TODO: update the code to test the property createDate
        expect(instance).to.have.property('createDate');
        // expect(instance.createDate).to.be(expectedValueLiteral);
      });

      it('should have the property deadlineDate (base name: "deadlineDate")', function() {
        // TODO: update the code to test the property deadlineDate
        expect(instance).to.have.property('deadlineDate');
        // expect(instance.deadlineDate).to.be(expectedValueLiteral);
      });

      it('should have the property projectNote (base name: "projectNote")', function() {
        // TODO: update the code to test the property projectNote
        expect(instance).to.have.property('projectNote');
        // expect(instance.projectNote).to.be(expectedValueLiteral);
      });

      it('should have the property tasks (base name: "tasks")', function() {
        // TODO: update the code to test the property tasks
        expect(instance).to.have.property('tasks');
        // expect(instance.tasks).to.be(expectedValueLiteral);
      });

      it('should have the property tags (base name: "tags")', function() {
        // TODO: update the code to test the property tags
        expect(instance).to.have.property('tags');
        // expect(instance.tags).to.be(expectedValueLiteral);
      });

      it('should have the property category (base name: "category")', function() {
        // TODO: update the code to test the property category
        expect(instance).to.have.property('category');
        // expect(instance.category).to.be(expectedValueLiteral);
      });

      it('should have the property involvedUsers (base name: "involvedUsers")', function() {
        // TODO: update the code to test the property involvedUsers
        expect(instance).to.have.property('involvedUsers');
        // expect(instance.involvedUsers).to.be(expectedValueLiteral);
      });

      it('should have the property isArchieved (base name: "isArchieved")', function() {
        // TODO: update the code to test the property isArchieved
        expect(instance).to.have.property('isArchieved');
        // expect(instance.isArchieved).to.be(expectedValueLiteral);
      });

    });
  });

}));