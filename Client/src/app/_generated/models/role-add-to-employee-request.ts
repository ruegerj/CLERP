/* tslint:disable */
export interface RoleAddToEmployeeRequest {

  /**
   * Ids of the roles which should be added to the employee
   */
  roleIds?: Array<string>;

  /**
   * Id of the employee which the role should be added to
   */
  employeeId?: string;
}
