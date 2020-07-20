import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookComponent } from './book/book.component';
import { CreateBookComponent } from './create.book/create.book.component';
import { EditBookComponent } from './edit.book/edit.book.component';
import { DeleteBookComponent } from './delete.book/delete.book.component';
import { AllBooksComponent } from './all.books/all.books.component';



@NgModule({
  declarations: [BookComponent, CreateBookComponent, EditBookComponent, DeleteBookComponent, AllBooksComponent],
  imports: [
    CommonModule
  ]
})
export class BooksModule { }
