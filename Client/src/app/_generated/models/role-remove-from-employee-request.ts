/* tslint:disable */
export interface RoleRemoveFromEmployeeRequest {

  /**
   * Ids of the roles which should be removed from the employee
   */
  roleIds?: Array<string>;

  /**
   * Id of the employee which the role should be removed from
   */
  employeeId?: string;
}
