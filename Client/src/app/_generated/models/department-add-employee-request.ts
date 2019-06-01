/* tslint:disable */
export interface DepartmentAddEmployeeRequest {

  /**
   * Id of the department which the employee should be added to
   */
  departmentId?: string;

  /**
   * Id of the employee which should be added to the department
   */
  employeeId?: string;
}
