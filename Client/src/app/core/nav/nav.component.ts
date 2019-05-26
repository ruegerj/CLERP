import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '@_services/authentication.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  constructor(private authServie : AuthenticationService) { }

  public username : string;
  public password : string;

  ngOnInit() {
  }

  loginClicked(): void
  {
    this.authServie.login(this.username, this.password);
  }
}
