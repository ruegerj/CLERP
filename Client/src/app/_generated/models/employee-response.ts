/* tslint:disable */
import { EmployeeDepartmentResponse } from './employee-department-response';
import { EmployeeRoleResponse } from './employee-role-response';

/**
 * Default response dto for an employee
 */
export interface EmployeeResponse {
  id?: string;
  firstname?: string;
  lastname?: string;
  birthday?: string;
  email?: string;
  phoneNumber?: string;
  username?: string;
  department?: EmployeeDepartmentResponse;
  roles?: Array<EmployeeRoleResponse>;
}
