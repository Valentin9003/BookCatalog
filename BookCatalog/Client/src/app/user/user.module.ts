import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BooksComponent } from './books/books.component';
import { AuthorComponent } from './author/author.component';
import { UserComponent } from './user/user.component';
import { Book } from './book.list/book.list.component';
import { BookComponent } from './books/book/book.component';
import { Author } from './author/author.info/author.info.component';
import { Books } from './books/books.list/books.list.component';
import { Edit } from './books/edit.book/edit.book.component';
import { Add } from './books/add.book/add.book.component';



@NgModule({
  declarations: [BooksComponent, AuthorComponent, UserComponent, Book.ListComponent, BookComponent, Author.InfoComponent, Books.ListComponent, Edit.BookComponent, Add.BookComponent],
  imports: [
    CommonModule
  ]
})
export class UserModule { }
