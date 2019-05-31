import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {

  public searchControl: FormControl;


  constructor() { }

  ngOnInit() {
    this.searchControl = new FormControl({value: ''});
  }

}
