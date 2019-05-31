import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { EmployeeService } from '@_generated/services';
import { EmployeeResponse } from '@_generated/models';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  public searchControl: FormControl = new FormControl('');
  public employees: Array<EmployeeResponse>;
  public filteredEmployees: Array<EmployeeResponse>;


  constructor(private employeeServcie: EmployeeService) { }

  ngOnInit() {
    this.employeeServcie.GetAll().subscribe(data => { 
      this.employees = data.employees; 
      this.filteredEmployees = this.employees; 
    });
  }


  searchClicked(): void {
    this.filteredEmployees = this.employees.filter(employee => {
      return (employee.firstname.toLowerCase().includes(this.searchControl.value.toLowerCase())
        || employee.lastname.toLowerCase().includes(this.searchControl.value.toLowerCase())
        || employee.username.toLowerCase().includes(this.searchControl.value.toLowerCase()));
    })
  }
}
