import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-crudbar',
  templateUrl: './crudbar.component.html',
  styleUrls: ['./crudbar.component.scss']
})
export class CrudbarComponent implements OnInit {
  isEditing : boolean;
  @Output() EditStarted = new EventEmitter<boolean>();
  @Output() EditCanceled = new EventEmitter<boolean>();
  @Output() EditSaved = new EventEmitter<boolean>();
  @Output() EditNew = new EventEmitter<boolean>();

  constructor() { 
    this.isEditing = false;
  }

  ngOnInit() {
  }

  editBtnClicked() : void{
    this.isEditing = true;
    this.EditStarted.emit();
  }

  cancelBtnClicked() : void {
    this.isEditing = false;
    this.EditCanceled.emit();
  }

  saveBtnClicked() : void {
    this.isEditing = false;
    this.EditSaved.emit();  
  }

  newBtnClicked() : void {
    this.isEditing = true;
    this.EditNew.emit();  
  }
}
