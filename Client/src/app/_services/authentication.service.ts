import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from '@_models';
import { HttpClient } from '@angular/common/http';
import { EmployeeService } from '@_generated/services';
import { EmployeeLoginRequest, TokenResponse } from '@_generated/models';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;
  
  private loginRequest: EmployeeLoginRequest;


  constructor(private employeeService: EmployeeService) {
    this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue(): User {
    return this.currentUserSubject.value;
  }

  login(username: string, password: string) {
    this.loginRequest = {username: username, password: password};
    
    this.employeeService.Login(this.loginRequest).subscribe(data => {
      console.log(data.token);      
    })
  }

}
