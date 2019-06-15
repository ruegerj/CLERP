/* tslint:disable */

/**
 * Response dto for compartment data inside a request targeting the warehouse controller
 */
export interface WarehouseCompartmentResponse {
  id?: string;

  /**
   * The row number inside the compartment grid
   */
  row?: number;

  /**
   * The column number inside the compartment grid
   */
  column?: number;
  shelfId?: string;
}
