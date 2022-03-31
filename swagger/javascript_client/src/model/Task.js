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
import {ApiClient} from '../ApiClient';
import {Event} from './Event';

/**
 * The Task model module.
 * @module model/Task
 * @version 0.0.1
 */
export class Task {
  /**
   * Constructs a new <code>Task</code>.
   * @alias module:model/Task
   * @class
   * @param name {String} 
   */
  constructor(name) {
    this.name = name;
  }

  /**
   * Constructs a <code>Task</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Task} obj Optional instance to populate.
   * @return {module:model/Task} The populated <code>Task</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new Task();
      if (data.hasOwnProperty('id'))
        obj.id = ApiClient.convertToType(data['id'], 'Number');
      if (data.hasOwnProperty('name'))
        obj.name = ApiClient.convertToType(data['name'], 'String');
      if (data.hasOwnProperty('projectIds'))
        obj.projectIds = ApiClient.convertToType(data['projectIds'], ['Number']);
      if (data.hasOwnProperty('priority'))
        obj.priority = ApiClient.convertToType(data['priority'], 'String');
      if (data.hasOwnProperty('stepNum'))
        obj.stepNum = ApiClient.convertToType(data['stepNum'], 'Number');
      if (data.hasOwnProperty('expectedStartTime'))
        obj.expectedStartTime = ApiClient.convertToType(data['expectedStartTime'], 'Date');
      if (data.hasOwnProperty('expectedFinishTime'))
        obj.expectedFinishTime = ApiClient.convertToType(data['expectedFinishTime'], 'Date');
      if (data.hasOwnProperty('expectedTimeDuration'))
        obj.expectedTimeDuration = ApiClient.convertToType(data['expectedTimeDuration'], 'String');
      if (data.hasOwnProperty('state'))
        obj.state = ApiClient.convertToType(data['state'], 'String');
      if (data.hasOwnProperty('recurRule'))
        obj.recurRule = ApiClient.convertToType(data['recurRule'], 'String');
      if (data.hasOwnProperty('events'))
        obj.events = ApiClient.convertToType(data['events'], [Event]);
      if (data.hasOwnProperty('assignedUser'))
        obj.assignedUser = ApiClient.convertToType(data['assignedUser'], 'Number');
    }
    return obj;
  }
}

/**
 * @member {Number} id
 */
Task.prototype.id = undefined;

/**
 * @member {String} name
 */
Task.prototype.name = undefined;

/**
 * @member {Array.<Number>} projectIds
 */
Task.prototype.projectIds = undefined;

/**
 * Allowed values for the <code>priority</code> property.
 * @enum {String}
 * @readonly
 */
Task.PriorityEnum = {
  /**
   * value: "notAnalysed"
   * @const
   */
  notAnalysed: "notAnalysed",

  /**
   * value: "high"
   * @const
   */
  high: "high",

  /**
   * value: "medium"
   * @const
   */
  medium: "medium",

  /**
   * value: "low"
   * @const
   */
  low: "low"
};
/**
 * @member {module:model/Task.PriorityEnum} priority
 */
Task.prototype.priority = undefined;

/**
 * @member {Number} stepNum
 */
Task.prototype.stepNum = undefined;

/**
 * @member {Date} expectedStartTime
 */
Task.prototype.expectedStartTime = undefined;

/**
 * @member {Date} expectedFinishTime
 */
Task.prototype.expectedFinishTime = undefined;

/**
 * [ISO_8601](https://en.wikipedia.org/wiki/ISO_8601#Durations)
 * @member {String} expectedTimeDuration
 */
Task.prototype.expectedTimeDuration = undefined;

/**
 * Allowed values for the <code>state</code> property.
 * @enum {String}
 * @readonly
 */
Task.StateEnum = {
  /**
   * value: "queued"
   * @const
   */
  queued: "queued",

  /**
   * value: "started"
   * @const
   */
  started: "started",

  /**
   * value: "blocked"
   * @const
   */
  blocked: "blocked",

  /**
   * value: "completed"
   * @const
   */
  completed: "completed",

  /**
   * value: "abandoned"
   * @const
   */
  abandoned: "abandoned"
};
/**
 * @member {module:model/Task.StateEnum} state
 */
Task.prototype.state = undefined;

/**
 * @member {String} recurRule
 */
Task.prototype.recurRule = undefined;

/**
 * @member {Array.<module:model/Event>} events
 */
Task.prototype.events = undefined;

/**
 * @member {Number} assignedUser
 */
Task.prototype.assignedUser = undefined;
