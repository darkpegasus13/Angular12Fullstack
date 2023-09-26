import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingPageLazyLoadingComponent } from './landing-page-lazy-loading.component';

const routes: Routes = [{ path: '', component: LandingPageLazyLoadingComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LandingPageLazyLoadingRoutingModule { }
