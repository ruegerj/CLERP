/* tslint:disable */
import { WarehouseShelfResponse } from './warehouse-shelf-response';
import { WarehouseAddressResponse } from './warehouse-address-response';

/**
 * Default response dto for a warehouse
 */
export interface WarehouseResponse {
  id?: string;
  name?: string;
  shelves?: Array<WarehouseShelfResponse>;
  address?: WarehouseAddressResponse;
}
