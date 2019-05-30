import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '@_services/authentication.service';
import { User, Roles } from '@_models';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  constructor(private router: Router,
    private authServie: AuthenticationService) {
    this.authServie.currentUser.subscribe(x => this.currentUser = x);
  }

  public username: string;
  public password: string;

  public currentUser: User;

  ngOnInit() {
  }

  get isAdmin() {
    return this.currentUser && this.currentUser.Roles && this.currentUser.Roles.includes(Roles.SysAdmin);
}

  loginClicked(): void {
    this.authServie.login(this.username, this.password);
  }

  logoutClicked(): void{
    this.authServie.logout();
    this.router.navigate(['/']);
  }
}
