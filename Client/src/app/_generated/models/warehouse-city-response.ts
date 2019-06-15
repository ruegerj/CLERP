/* tslint:disable */
import { WarehouseCountryResponse } from './warehouse-country-response';

/**
 * Response dto for city data inside a request targeting the warehouse controller
 */
export interface WarehouseCityResponse {
  id?: string;
  name?: string;
  postalCode?: number;
  countryId?: string;
  country?: WarehouseCountryResponse;
}
