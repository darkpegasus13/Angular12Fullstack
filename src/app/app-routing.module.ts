import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { LoginComponent } from './login/login.component';
import { CanActivateRouteGuardService } from './Services/can-activate-route-guard.service';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'home', component: LandingPageComponent, canActivate: [CanActivateRouteGuardService] },
  { path: 'landing-page-lazy', loadChildren: () => import('./landing-page-lazy-loading/landing-page-lazy-loading.module').then(m => m.LandingPageLazyLoadingModule) }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
