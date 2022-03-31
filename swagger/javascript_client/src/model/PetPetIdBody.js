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

/**
 * The PetPetIdBody model module.
 * @module model/PetPetIdBody
 * @version 0.0.1
 */
export class PetPetIdBody {
  /**
   * Constructs a new <code>PetPetIdBody</code>.
   * @alias module:model/PetPetIdBody
   * @class
   */
  constructor() {
  }

  /**
   * Constructs a <code>PetPetIdBody</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PetPetIdBody} obj Optional instance to populate.
   * @return {module:model/PetPetIdBody} The populated <code>PetPetIdBody</code> instance.
   */
  static constructFromObject(data, obj) {
    if (data) {
      obj = obj || new PetPetIdBody();
      if (data.hasOwnProperty('name'))
        obj.name = ApiClient.convertToType(data['name'], 'String');
      if (data.hasOwnProperty('status'))
        obj.status = ApiClient.convertToType(data['status'], 'String');
    }
    return obj;
  }
}

/**
 * Updated name of the pet
 * @member {String} name
 */
PetPetIdBody.prototype.name = undefined;

/**
 * Updated status of the pet
 * @member {String} status
 */
PetPetIdBody.prototype.status = undefined;
