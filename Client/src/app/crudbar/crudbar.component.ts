import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-crudbar',
  templateUrl: './crudbar.component.html',
  styleUrls: ['./crudbar.component.scss']
})
export class CrudbarComponent implements OnInit {
  @Output() editWasClicked = new EventEmitter<boolean>();
  

  constructor() { }

  ngOnInit() {
  }

  editBtnClicked() : void{
    this.editWasClicked.emit(true);
  }
}
