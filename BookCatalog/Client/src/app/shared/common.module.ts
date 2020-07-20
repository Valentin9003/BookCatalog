import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';



@NgModule({
  declarations: [HomeComponent, NavbarComponent],
  imports: [
    CommonModule
  ]
})
export class SharedModule { }
