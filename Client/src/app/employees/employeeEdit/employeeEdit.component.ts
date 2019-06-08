import { Component, OnInit, ViewChild, TemplateRef } from '@angular/core';
import { NgbDateAdapter, NgbDateNativeAdapter, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeService, DepartmentService, RoleService } from '@_generated/services';
import { FormGroup, FormBuilder, Validators, FormArray, FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeResponse, DepartmentResponse, RoleResponse } from '@_generated/models';
import { ValidationConstans } from '@_models';
import { forkJoin } from 'rxjs';

@Component({
  selector: 'app-employeeEdit',
  templateUrl: './employeeEdit.component.html',
  styleUrls: ['./employeeEdit.component.scss'],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }]
})
export class EmployeeEditComponent implements OnInit {
  /** properties **/
  public employee: EmployeeResponse;
  public isEditing: boolean;
  public submitted: boolean = false;
  public employeeForm: FormGroup;
  public id: string;
  public departments: Array<DepartmentResponse>;
  public roles: Array<RoleResponse>;

  @ViewChild('modalSuccessContent') private modalSuccessContent: TemplateRef<any>;
  @ViewChild('modalErrorContent') private modalErrorContent: TemplateRef<any>;


  constructor(
    private employeeService: EmployeeService,
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private modalService: NgbModal,
    private departmentService: DepartmentService,
    private roleService: RoleService
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
      department: [''],
      roles: new FormArray([])
    });


    let getAllDepartements = this.departmentService.GetAllDepartments();
    let getAllRoles = this.roleService.GetAllRoles();
    let getEmployee = this.employeeService.GetEmployeeById(this.id);


    this.route.params.subscribe(params => {
      this.id = params.id;
      forkJoin([getAllDepartements, getAllRoles]).subscribe(results => {
        this.departments = results[0].departments;

        this.employeeService.GetEmployeeById(params.id).subscribe(data => {
          this.employee = data;
          console.log(this.employee);
          this.setFormValues(data);
        })

        this.roles = results[1].roles;
        this.addRoleCheckboxes();
      })
    });


    // this.departmentService.GetAllDepartments().subscribe(data => {
    //   this.departments = data.departments;
    // });

    // //Roles needed to build form
    // this.roleService.GetAllRoles().subscribe(data => {
    //   this.roles = data.roles;
    //   this.addRoleCheckboxes();
    // });



    // if (this.id) {
    //   this.employeeService.GetEmployeeById(this.id).subscribe(data => {
    //     this.employee = data;
    //     console.log(this.employee);
    //     this.setFormValues(data);
    //   })
    // }
  }


  // convenience getter for easy access to form fields
  get f() { return this.employeeForm.controls; }


  private addRoleCheckboxes() {
    this.roles.map(() => {
      const control = new FormControl(false);
      (this.employeeForm.controls.roles as FormArray).push(control);
    });
  }


  private setFormValues(e: EmployeeResponse) {
    this.employeeForm.patchValue({
      username: e.username,
      firstName: e.firstname,
      lastName: e.lastname,
      email: e.email,
      phoneNumber: e.phoneNumber,
      birthday: new Date(e.birthday),
      department: this.departments.find(d => { return d.id === e.department.id}),
      roles: this.roles.map(r => e.roles.map(r => r.id).includes(r.id))
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
