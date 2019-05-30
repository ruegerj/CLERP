import { Component, OnInit } from '@angular/core';
import { Employee } from '@_models'
import { NgbDateAdapter, NgbDateNativeAdapter } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeService } from '@_generated/services';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeesComponent implements OnInit {
  isEditing: boolean;
  employee: Employee = new Employee("ExLastName", "ExFirstName", "ExEmail", "+41 88 99 44 66", new Date("January 31 1988 12:30"), "ExUsername");
  backupEmployee: Employee;


  constructor(private employeeService: EmployeeService) {
    this.isEditing = false;
    this.backupEmployee = Object.assign({}, this.employee);
  }

  ngOnInit() {
  }



  onEditStarted($event): void {
    this.isEditing = $event;
  }

  onEditCanceled($event): void {
    this.isEditing = $event;
    this.employee = Object.assign({}, this.backupEmployee);
  }

  onEditSaved($event): void {
    this.isEditing = $event;

    this.employeeService.CreateEmployee({
      firstname: this.employee.FirstName, lastname: this.employee.LastName, email: this.employee.Email, "phone-number": this.employee.PhoneNr.replace(/\s/g, ""),
      birthday: this.employee.Birthday, username: this.employee.Username, password: this.employee.Password
    }).subscribe( data => {
      console.log(data);
    })
  }

  onEditNew($event): void {
    this.isEditing = $event;
    this.employee = <Employee>{};
  }
}
