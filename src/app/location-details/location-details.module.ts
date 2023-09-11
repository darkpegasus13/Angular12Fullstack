import { NgModule } from '@angular/core';
import { LocationDetailsComponent } from './location-details.component';
import { RouterModule, Routes } from '@angular/router';
import { GoogleMapsModule } from '@angular/google-maps';

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
  exports: [RouterModule]
})
export class LocationDetailsModule { }
