/* tslint:disable */

/**
 * Represents a validation error, occured when validating an incoming model
 */
export interface ValidationError {
  field?: string;
  message?: string;
}
