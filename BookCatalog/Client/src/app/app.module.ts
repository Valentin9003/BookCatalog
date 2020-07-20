import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BooksModule } from './books/books.module';
import { AuthorsModule } from './authors/authors.module';
import { SharedModule } from './shared/common.module';
import { IdentityModule } from './identity/identity.module';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { TokenInterceptor } from './shared/token-interceptor';
import { ErrorInterceptor } from './shared/error-interceptor';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BooksModule,
    AuthorsModule,
    SharedModule,
    IdentityModule,
    HttpClientModule,
    RouterModule,
    CommonModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptor,
      multi: true
       },
       {
        provide: HTTP_INTERCEPTORS,
        useClass: ErrorInterceptor,
        multi: true
       }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
