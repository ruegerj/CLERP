import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AuthenticationService } from '@/_services';
import { User, Roles } from '@_models';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
    constructor(
        private router: Router,
        private authenticationService: AuthenticationService,
        private modalService: NgbModal
    ) { }


    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        const currentUser = this.authenticationService.currentUserValue;
        if (currentUser) {
            // check if user has roles and if route is restricted by role
            if (!currentUser.Roles || (route.data.roles && !route.data.roles.some(x => currentUser.Roles.includes(x)))) {
                // role not authorised so redirect to home page
                alert("You do not posses the required role.\nRedirected to home page.");
                this.router.navigate(['/']);
                return false;
            }

            // authorised so return true
            return true;
        }

        // not logged in so redirect to home page with the return url
        alert("Not logged in.\nRedirected to home page.");
        this.router.navigate(['/'], { queryParams: { returnUrl: state.url } });
        return false;
    }
}