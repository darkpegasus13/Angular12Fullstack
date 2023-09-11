import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LandingPageLazyLoadingRoutingModule } from './landing-page-lazy-loading-routing.module';
import { LandingPageLazyLoadingComponent } from './landing-page-lazy-loading.component';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { LoggingInterceptor } from '../logging.interceptor';


@NgModule({
  declarations: [
    LandingPageLazyLoadingComponent
  ],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: LoggingInterceptor, multi: true }],
  imports: [
    CommonModule,
    LandingPageLazyLoadingRoutingModule
  ]
})
export class LandingPageLazyLoadingModule { }
