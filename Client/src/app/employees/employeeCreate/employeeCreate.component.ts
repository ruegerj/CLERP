import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { EmployeeResponse } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EmployeeService } from '@_generated/services';
import { NgbDateAdapter, NgbDateNativeAdapter, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';
import { ValidationConstans } from '@_models';

@Component({
  selector: 'app-employeeCreate',
  templateUrl: './employeeCreate.component.html',
  styleUrls: ['./employeeCreate.component.css'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeeCreateComponent implements OnInit {
  /** properties **/
  employee: EmployeeResponse;
  submitted: boolean = false;
  employeeForm: FormGroup;
  
  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;


  constructor(
    private employeeService: EmployeeService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal,
    private router: Router,
  ) { }


  ngOnInit() {
    this.employeeForm = this.formBuilder.group({
      firstName: ['', [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      lastName: ['', [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      email: ['', [Validators.required, Validators.email]],
      phoneNumber: ['', [Validators.required, Validators.pattern(ValidationConstans.PhoneNumberRegex)]],
      birthday: ['', Validators.required],
      username: ['', [Validators.required, Validators.minLength(ValidationConstans.MinUsernameLength), Validators.maxLength(ValidationConstans.MaxUsernameLength)]],
      password: ['', [Validators.required, Validators.minLength(ValidationConstans.MinPasswordLength), Validators.maxLength(ValidationConstans.MaxPasswordLength)]]
    })
  }



  // convenience getter for easy access to form fields
  get f() { return this.employeeForm.controls; }


  /** click event methods for **/
  createClicked(): void {
    this.submitted = true;

    if (this.employeeForm.invalid) {
      return;
    }

    this.employeeService.CreateEmployee({
      firstname: this.f.firstName.value, lastname: this.f.lastName.value, email: this.f.email.value, phoneNumber: this.f.phoneNumber.value,
      birthday: this.f.birthday.value, username: this.f.username.value, password: this.f.password.value
    }).subscribe(data => {
      this.modalService.open(this.modalSuccessContent);
      this.router.navigate(['/employees']);
    }, (error) => {
      this.modalService.open(this.modalErrorContent);
    })
  }
}
