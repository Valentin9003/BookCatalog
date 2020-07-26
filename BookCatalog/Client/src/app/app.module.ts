import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BooksModule } from './books/books.module';
import { AuthorsModule } from './authors/authors.module';
import { SharedModule } from './shared/shared.module';
import { AuthenticationModule } from './authentication/authentication.module';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { InterceptorService } from './shared/interceptor.service';
import { ErrorInterceptorService } from './shared/error-interceptor.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { UserComponent } from './user/user.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BooksModule,
    AuthorsModule,
    SharedModule,
    AuthenticationModule,
    HttpClientModule,
    RouterModule,
    CommonModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: InterceptorService,
      multi: true
       },
       {
        provide: HTTP_INTERCEPTORS,
        useClass: ErrorInterceptorService,
        multi: true
       }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
