import { Component, OnInit } from '@angular/core';
import { Employee } from '@Models/Employee'

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss']
})
export class EmployeesComponent implements OnInit {
  private employee : Employee

  constructor() { }

  ngOnInit() {
  }

}
