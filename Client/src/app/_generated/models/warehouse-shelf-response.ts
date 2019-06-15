/* tslint:disable */
import { WarehouseCompartmentResponse } from './warehouse-compartment-response';

/**
 * Response dto for shelf data inside a request targeting the warehouse controller
 */
export interface WarehouseShelfResponse {
  id?: string;

  /**
   * Designation of the shelf e.g. shelf 7A
   */
  designation?: string;
  warehouseId?: string;
  compartments?: Array<WarehouseCompartmentResponse>;
}
