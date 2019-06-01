import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { NgbDateAdapter, NgbDateNativeAdapter, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeService } from '@_generated/services';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeResponse } from '@_generated/models';
import { ValidationConstans } from '@_models';

@Component({
  selector: 'app-employeeEdit',
  templateUrl: './employeeEdit.component.html',
  styleUrls: ['./employeeEdit.component.scss'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeeEditComponent implements OnInit {
  /** properties **/
  employee: EmployeeResponse;
  isEditing: boolean;
  submitted: boolean = false;
  employeeForm: FormGroup;
  id: string;

  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;


  constructor(
    private employeeService: EmployeeService,
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private modalService: NgbModal
  ) {
    this.isEditing = false;
  }


  ngOnInit() {
    this.employeeForm = this.formBuilder.group({
      username: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstans.MinUsernameLength), Validators.maxLength(ValidationConstans.MaxUsernameLength)]],
      firstName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      lastName: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.minLength(ValidationConstans.MinNameLength), Validators.maxLength(ValidationConstans.MaxNameLength)]],
      email: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.email]],
      phoneNumber: [{ value: '', disabled: !this.isEditing }, [Validators.required, Validators.pattern(ValidationConstans.PhoneNumberRegex)]],
      birthday: [{ value: '', disabled: !this.isEditing }, Validators.required],
    });

    this.route.params.subscribe(params => this.id = params.id);

    if (this.id) {
      this.employeeService.GetEmployeeById(this.id).subscribe(data => {
        this.employee = data;
        this.setFormValues(data);
      })
    }
  }


  // convenience getter for easy access to form fields
  get f() { return this.employeeForm.controls; }

  private setFormValues(e: EmployeeResponse) {
    this.employeeForm.setValue({
      username: e.username,
      firstName: e.firstname,
      lastName: e.lastname,
      email: e.email,
      phoneNumber: e.phoneNumber,
      birthday: new Date(e.birthday),
    })
  }

  /** click event methods **/
  editClicked(): void {
    this.isEditing = true;
    this.submitted = false;
    this.employeeForm.enable();
  }

  cancelClicked(): void {
    this.isEditing = false;
    this.submitted = false;
    this.employeeForm.disable();
    this.setFormValues(this.employee);
  }

  updateClicked(modalSuccessContent): void {
    this.submitted = true;

    if (this.employeeForm.invalid) {
      return;
    }

    this.employeeService.UpdateEmployee({
      id: this.id, updateData: {
        username: this.f.username.value, firstname: this.f.firstName.value, lastname: this.f.lastName.value, email: this.f.email.value, phoneNumber: this.f.phoneNumber.value,
        birthday: this.f.birthday.value
      }
    }).subscribe(data => {
      this.modalService.open(this.modalSuccessContent);
      this.router.navigate(['/employees']);
    }, (error) => {
      this.modalService.open(this.modalErrorContent);
    }
    );
  }
}
