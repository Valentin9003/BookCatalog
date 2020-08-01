import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookComponent } from './book/book.component';
import { AllBooksComponent } from './all.books/all.books.component';



@NgModule({
  declarations: [BookComponent, AllBooksComponent],
  imports: [
    CommonModule
  ]
})
export class BooksModule { }
