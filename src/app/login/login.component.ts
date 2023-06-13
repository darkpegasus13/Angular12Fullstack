import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup
  constructor(private fb: FormBuilder) {
    this.loginForm = this.fb.group({
      userName: ["", Validators.required],
      password: ["", [Validators.required, this.PasswordValidator]]
    })
  }
  ngOnInit() {
  }

  PasswordValidator(control: AbstractControl) {
    if (control.value.startsWith('Jayesh')) {
      return { invalidPassword: true };
    }
    return null;
  }

  OnSubmit() {
    console.log(this.loginForm);
  }

}
