import { NgModule } from '@angular/core';
import { LocationDetailsComponent } from './location-details.component';
import { RouterModule, Routes } from '@angular/router';


//lazy loading location details module
const routes: Routes = [
  { path: 'location-details', component: LocationDetailsComponent }
]

@NgModule({
  declarations: [
  ],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class LocationDetailsModule { }
