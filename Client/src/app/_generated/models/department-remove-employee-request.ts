/* tslint:disable */
export interface DepartmentRemoveEmployeeRequest {

  /**
   * Id of the department which the employee should be removed from
   */
  departmentId?: string;

  /**
   * Id of the employee which should be removed from the department
   */
  employeeId?: string;
}
