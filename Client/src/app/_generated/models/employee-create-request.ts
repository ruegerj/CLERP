/* tslint:disable */
export interface EmployeeCreateRequest {
  lastname: string;
  firstname: string;
  email: string;
  phoneNumber: string;
  username: string;

  /**
   * Plain password
   */
  password: string;
  birthday: string;
}
