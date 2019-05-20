/* tslint:disable */

/**
 * Payload of a ConflictException
 */
export interface ConflictResponse {

  /**
   * Name of the property which caused the conflict
   */
  field?: string;

  /**
   * Message about the reason/background of the conflict
   */
  message?: string;
}
