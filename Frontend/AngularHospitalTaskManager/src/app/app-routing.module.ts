import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserRegisterComponent } from './components/user-register/user-register.component';
import { ScheduleComponent } from './components/schedule/schedule.component';


const routes: Routes = [
  {path: "register", component:UserRegisterComponent},
  {path: "schedule", component:ScheduleComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routesComponent = [UserRegisterComponent, ScheduleComponent];
