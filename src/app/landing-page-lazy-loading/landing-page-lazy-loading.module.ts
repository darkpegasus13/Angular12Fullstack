import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LandingPageLazyLoadingRoutingModule } from './landing-page-lazy-loading-routing.module';
import { LandingPageLazyLoadingComponent } from './landing-page-lazy-loading.component';


@NgModule({
  declarations: [
    LandingPageLazyLoadingComponent
  ],
  imports: [
    CommonModule,
    LandingPageLazyLoadingRoutingModule
  ]
})
export class LandingPageLazyLoadingModule { }
