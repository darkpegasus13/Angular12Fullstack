import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class CanActivateRouteGuardService implements CanActivate {
  constructor(private _router: Router) {
  }

  canActivate(route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): boolean {

    //check some condition  
    if (1) {
      alert('You are not allowed to view this page');
      //redirect to login/home page etc
      //return false to cancel the navigation
      return false;
    }
    return true;
  }
}
