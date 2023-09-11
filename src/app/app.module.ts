import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LocationService } from './Services/location.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { LocationClassComponent } from './location-class/location-class.component';
import { Routes, RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './login/login.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { InterceptorService } from './Services/interceptor.service';
import { AppRoutingModule } from './app-routing.module';
import { TempConverterPipe } from 'src/app/CustomPipes/TemperatureConverterPipe';
import { HoverDirective } from './CustomDirectives/hover.directive';
import { CanActivateRouteGuardService } from './Services/can-activate-route-guard.service';


@NgModule({
  declarations: [
    AppComponent,
    LandingPageComponent,
    LocationClassComponent,
    LoginComponent,
    NavBarComponent,
    TempConverterPipe,
    HoverDirective
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [LocationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
