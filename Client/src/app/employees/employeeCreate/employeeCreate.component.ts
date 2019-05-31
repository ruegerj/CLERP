import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { EmployeeResponse } from '@_generated/models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EmployeeService } from '@_generated/services';
import { NgbDateAdapter, NgbDateNativeAdapter, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Router } from '@angular/router';

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

  /** validation vars **/
  private minNameLength: number = 2;
  private maxNameLength: number = 100;
  private minUsernameLength: number = 5;
  private maxUsernameLength: number = 15;
  private minPasswordLength: number = 10;
  private maxPasswordLength: number = 50;


  constructor(
    private employeeService: EmployeeService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal,
    private router: Router,
  ) { }


  ngOnInit() {
    this.employeeForm = this.formBuilder.group({
      firstName: ['', [Validators.required, Validators.minLength(this.minNameLength), Validators.maxLength(this.maxNameLength)]],
      lastName: ['', [Validators.required, Validators.minLength(this.minNameLength), Validators.maxLength(this.maxNameLength)]],
      email: ['', [Validators.required, Validators.email]],
      phoneNumber: ['', [Validators.required, Validators.pattern('^([\+][0-9]{1,3}([ \.\-])?)?([\(]{1}[0-9]{3}[\)])?([0-9A-Z \.\-]{1,32})((x|ext|extension)?[0-9]{1,4}?)$')]],
      birthday: ['', Validators.required],
      username: ['', [Validators.required, Validators.minLength(this.minUsernameLength), Validators.maxLength(this.maxUsernameLength)]],
      password: ['', [Validators.required, Validators.minLength(this.minPasswordLength), Validators.maxLength(this.maxPasswordLength)]]
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
      firstname: this.f.firstName.value, lastname: this.f.lastName.value, email: this.f.email.value, "phone-number": this.f.phoneNumber.value,
      birthday: this.f.birthday.value, username: this.f.username.value, password: this.f.password.value
    }).subscribe(data => {
      this.modalService.open(this.modalSuccessContent);
      this.router.navigate(['/employees']);
    }, (error) => {
      this.modalService.open(this.modalErrorContent);
    })
  }
}
