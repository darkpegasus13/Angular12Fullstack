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


@NgModule({
  declarations: [
    AppComponent,
    LandingPageComponent,
    LocationClassComponent,
    LoginComponent,
    NavBarComponent,
    TempConverterPipe
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [LocationService, {
    provide: HTTP_INTERCEPTORS,
    useClass: InterceptorService,
multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
