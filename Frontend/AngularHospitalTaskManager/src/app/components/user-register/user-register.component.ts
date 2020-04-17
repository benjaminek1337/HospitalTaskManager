import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {

  constructor(public service: UserService) { }

  ngOnInit(): void {
  }

  onSubmit(){
    this.service.register().subscribe(
      (response:any) =>{
        if(response.succeeded){
          this.service.formModel.reset();
        }
        else{
          response.errors.forEach(element => {
            switch (element.code) {
              case "DuplicateUserName":
                break;

                default:
            }
          })
        }
      },
      error => {
        console.log(error);
      }
    )

  }

}
