import { Component, OnInit } from '@angular/core';
import { Employee } from '@Models/Employee'

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss']
})
export class EmployeesComponent implements OnInit {
  isEditing : boolean;
  employee : Employee = new Employee("ExLastName", "ExFirstName", "ExEmail", "+41 88 99 44 66", new Date(19890564), "ExUsername");




  constructor() { 
    this.isEditing = false;
  }

  ngOnInit() {
  }



  onEditStateChanged($event) : void{
    this.isEditing = $event;
  }
}
