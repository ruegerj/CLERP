/* tslint:disable */
import { WarehouseCityResponse } from './warehouse-city-response';

/**
 * Response dto for adress data inside a request targeting the warehouse controller
 */
export interface WarehouseAddressResponse {
  id?: string;

  /**
   * The street name without the house-number
   */
  street?: string;

  /**
   * The housenumber , can be null if non existing
   */
  housenumber?: number;
  cityId?: string;
  city?: WarehouseCityResponse;
}
