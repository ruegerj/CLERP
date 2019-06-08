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
      this.employees = data.employees.sort(function(a, b) {  
        var x = a.username.toLowerCase();
        var y = b.username.toLowerCase();
        if (x < y) {return -1;}
        if (x > y) {return 1;}
        return 0;});

      this.filteredEmployees = this.employees; 
    });
  }


  searchClicked(): void {
    var searchText = this.searchControl.value.toLowerCase();

    this.filteredEmployees = this.employees.filter(employee => {
      return (employee.firstname.toLowerCase().includes(searchText)
        || employee.lastname.toLowerCase().includes(searchText)
        || employee.username.toLowerCase().includes(searchText));
    })
  }


  deleteClicked(id: string) : void {
    this.employeeServcie.DeleteEmployee(id).subscribe( data => {
      alert("Employee with id: '" + id + "' was deleted succesfully");

      this.employeeServcie.GetAll().subscribe(data => { 
        this.employees = data.employees.sort(function(a, b) {  
          var x = a.username.toLowerCase();
          var y = b.username.toLowerCase();
          if (x < y) {return -1;}
          if (x > y) {return 1;}
          return 0;}); 

        this.filteredEmployees = this.employees; 
      });
    }, error => {
      alert("Could not delete employee")
    })
  }
}
