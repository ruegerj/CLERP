/* tslint:disable */

/**
 * Response dto for country data inside a request targeting the warehouse controller
 */
export interface WarehouseCountryResponse {
  id?: string;
  name?: string;

  /**
   * The abbrevation of the country e.g. Switzerland =&gt; CHE
   * Three digit country codes
   */
  abbrevation?: string;
}
