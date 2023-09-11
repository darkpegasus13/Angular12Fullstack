import { NgModule } from '@angular/core';
import { LocationDetailsComponent } from './location-details.component';
import { RouterModule, Routes } from '@angular/router';
import { GoogleMapsModule } from '@angular/google-maps';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { LoggingInterceptor } from '../logging.interceptor';

//lazy loading location details module
const routes: Routes = [
  { path: '', component: LocationDetailsComponent }
]

@NgModule({
  declarations: [
    LocationDetailsComponent
  ],
  imports: [
    RouterModule.forChild(routes),
    GoogleMapsModule
  ],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: LoggingInterceptor, multi: true }],
  exports: [RouterModule]
})
export class LocationDetailsModule { }
