/* tslint:disable */
import { ValidationError } from './validation-error';

/**
 * Represents the summary of all validation errors
 * Data-Format that will be returned after a failed validation
 */
export interface ValidationFailedResponse {
  message?: string;
  validationErrors?: Array<ValidationError>;
}
