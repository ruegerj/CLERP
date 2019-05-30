import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from '@_models';
import { EmployeeService } from '@_generated/services';
import { EmployeeLoginRequest, TokenResponse } from '@_generated/models';
import * as jwt_decode from 'jwt-decode';


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
      if(data.token)
      {
        var decoded = jwt_decode(data.token);
        var receivedUser = new User(decoded['sub'], decoded['eun'], decoded['role'], data.token);
        localStorage.setItem('currentUser', JSON.stringify(receivedUser));
        this.currentUserSubject.next(receivedUser);

        console.log(data.token);      
      }
      

    })
  }


  logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('currentUser');
    this.currentUserSubject.next(null);
}
}
