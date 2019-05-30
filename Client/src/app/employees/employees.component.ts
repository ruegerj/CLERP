import { Component, OnInit } from '@angular/core';
import { Employee } from '@_models'
import { NgbDateAdapter, NgbDateNativeAdapter } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeService } from '@_generated/services';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeesComponent implements OnInit {
  isEditing: boolean;
  submitted: boolean = false;
  employee: Employee = new Employee("ExLastName", "ExFirstName", "ExEmail@mail.com", "+41 55 644 44 66", new Date("January 31 1988 12:30"), "ExUsername");
  // backupEmployee: Employee;

  employeeForm: FormGroup;

  //validation vars
  minNameLength: number = 2;
  maxNameLength: number = 100;
  minUsernameLength: number = 5;
  maxUsernameLength: number = 15;
  minPasswordLength: number = 10;
  maxPasswordLength: number = 50;



  constructor(
    private employeeService: EmployeeService,
    private formBuilder: FormBuilder
  ) {
    this.isEditing = false;
    // this.backupEmployee = Object.assign({}, this.employee);
  }


  ngOnInit() {
    this.employeeForm = this.formBuilder.group({
      firstName: [{ value: this.employee.FirstName, disabled: !this.isEditing }, [Validators.required, Validators.minLength(this.minNameLength), Validators.maxLength(this.maxNameLength)]],
      lastName: [{ value: this.employee.LastName, disabled: !this.isEditing }, [Validators.required, Validators.minLength(this.minNameLength), Validators.maxLength(this.maxNameLength)]],
      email: [{ value: this.employee.Email, disabled: !this.isEditing }, [Validators.required, Validators.email]],
      phoneNumber: [{ value: this.employee.PhoneNr, disabled: !this.isEditing }, [Validators.required, Validators.pattern('^([\+][0-9]{1,3}([ \.\-])?)?([\(]{1}[0-9]{3}[\)])?([0-9A-Z \.\-]{1,32})((x|ext|extension)?[0-9]{1,4}?)$')]],
      birthday: [{ value: this.employee.Birthday, disabled: !this.isEditing }, Validators.required],
      username: [{ value: this.employee.Username, disabled: !this.isEditing }, [Validators.required, Validators.minLength(this.minUsernameLength), Validators.maxLength(this.maxUsernameLength)]],
      password: [{ value: this.employee.Password, disabled: !this.isEditing }, [Validators.required, Validators.minLength(this.minPasswordLength), Validators.maxLength(this.maxPasswordLength)]]
    }
    )
  }


  // convenience getter for easy access to form fields
  get f() { return this.employeeForm.controls; }


  /** event methods for crudbar **/
  onEditStarted(): void {
    this.submitted = false;
    this.employeeForm.enable();
  }

  onEditCanceled(): void {
    this.submitted = false;
    this.employeeForm.disable();
    this.employeeForm.setValue({
      firstName: this.employee.FirstName,
      lastName: this.employee.LastName,
      email: this.employee.Email,
      phoneNumber: this.employee.PhoneNr,
      birthday: this.employee.Birthday,
      username: this.employee.Username,
      password: this.employee.Password
    })
    // this.employee = Object.assign({}, this.backupEmployee);
  }

  onEditSaved(): void {
    this.submitted = true;
    
    if(this.employeeForm.invalid){
      return;
    }

    this.employeeForm.disable();

    this.employeeService.CreateEmployee({
      firstname: this.f.firstName.value, lastname: this.f.lastName.value, email: this.f.email.value, "phone-number": this.f.phoneNumber.value,
      birthday: this.f.birthday.value, username: this.f.username.value, password: this.f.password.value
    }).subscribe(data => {
      console.log(data);
    })
  }

  onEditNew(): void {
    this.submitted = false;
    this.employeeForm.enable();
    // this.employee = <Employee>{};
    this.employeeForm.reset();
  }
}
