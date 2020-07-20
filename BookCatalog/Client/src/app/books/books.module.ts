import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookComponent } from './book/book.component';
import { Create } from './create.book/create.book.component';
import { Edit } from './edit.book/edit.book.component';
import { Delete } from './delete.book/delete.book.component';
import { All } from './all.books/all.books.component';



@NgModule({
  declarations: [BookComponent, Create.BookComponent, Edit.BookComponent, Delete.BookComponent, All.BooksComponent],
  imports: [
    CommonModule
  ]
})
export class BooksModule { }
