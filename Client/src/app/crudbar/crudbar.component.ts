import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-crudbar',
  templateUrl: './crudbar.component.html',
  styleUrls: ['./crudbar.component.scss']
})
export class CrudbarComponent implements OnInit {
  isEditing : boolean;
  @Output() editStateChanged = new EventEmitter<boolean>();   

  constructor() { 
    this.isEditing = false;
  }

  ngOnInit() {
  }

  editBtnClicked() : void{
    this.isEditing = !this.isEditing;
    this.editStateChanged.emit(this.isEditing);
  }

  cancelBtnClicked() : void {
    console.log("not implemented yet");
  }

  saveBtnClicked() : void {
    console.log("not implemented yet");
  }

  newBtnClicked() : void {
    console.log("not implemented yet");
  }
}
