import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
//import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LocationService } from './Services/location.service';
import { HttpClientModule } from '@angular/common/http';
import { LocationClassComponent } from './location-class/location-class.component';
import { Routes, RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './login/login.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'home', component: LandingPageComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    LandingPageComponent,
    LocationClassComponent,
    LoginComponent,
    NavBarComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    ReactiveFormsModule
  ],
  providers: [LocationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
