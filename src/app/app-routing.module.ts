import { CommonModule } from '@angular/common';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { LoggingInterceptor } from './logging.interceptor';
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
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: LoggingInterceptor, multi: true }],
  exports: [RouterModule]
})
export class AppRoutingModule { }
