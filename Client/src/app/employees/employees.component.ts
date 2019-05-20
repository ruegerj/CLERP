import { Component, OnInit } from '@angular/core';
import { Employee } from '@Models/Employee'
import { NgbDateAdapter, NgbDateNativeAdapter } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss'],
  providers: [{provide: NgbDateAdapter, useClass: NgbDateNativeAdapter}]
})
export class EmployeesComponent implements OnInit {
  isEditing : boolean;
  employee : Employee = new Employee("ExLastName", "ExFirstName", "ExEmail", "+41 88 99 44 66", new Date("January 31 1988 12:30"), "ExUsername");
  backupEmployee : Employee;



  constructor() { 
    this.isEditing = false;
  }

  ngOnInit() {
  }



  onEditStarted($event) : void{
    this.isEditing = $event;
  }
}
