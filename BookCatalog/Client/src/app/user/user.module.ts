import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BooksComponent } from './books/books.component';
import { AuthorComponent } from './author/author.component';
import { UserComponent } from './user/user.component';



@NgModule({
  declarations: [BooksComponent, AuthorComponent, UserComponent],
  imports: [
    CommonModule
  ]
})
export class UserModule { }
