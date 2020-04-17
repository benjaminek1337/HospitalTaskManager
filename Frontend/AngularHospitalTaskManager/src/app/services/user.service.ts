import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from "@angular/forms"
import { HttpClient } from "@angular/common/http"

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private fb: FormBuilder, private http:HttpClient) { }
  readonly baseUrl = "https://localhost:44336/api/";

  formModel = this.fb.group({
    UserName : ["", Validators.required],
    Email : ["", Validators.email],
    PasswordGroup : this.fb.group({
      Password : ["", [Validators.required, Validators.minLength(6)]],
      ConfirmPassword : ["", Validators.required]
    }, {validator: this.comparePasswords })
  });

  comparePasswords(fg: FormGroup ){
    let confirmPasswords = fg.get("ConfirmPassword");

    if(confirmPasswords.errors == null || "passwordMismatch" in confirmPasswords.errors){
      if(fg.get("Password").value != confirmPasswords.value){
        confirmPasswords.setErrors({passwordMismatch: true});
      }
      else{
        confirmPasswords.setErrors(null);
      }
    }
  }

  register(){
    var body = {
      UserName: this.formModel.value.UserName,
      Email: this.formModel.value.Email,
      Password: this.formModel.value.PasswordGroup.Password
    };
    return this.http.post(this.baseUrl + "Authentication/Register", body);

  }
}

