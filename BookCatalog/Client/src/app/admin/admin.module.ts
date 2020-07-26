import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookComponent } from './book/book.component';
import { AuthorComponent } from './author/author.component';



@NgModule({
  declarations: [BookComponent, AuthorComponent],
  imports: [
    CommonModule
  ]
})
export class AdminModule { }
