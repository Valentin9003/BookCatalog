import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IdentityService } from '../identity/services/identity.service';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class ErrorInterceptor implements HttpInterceptor {

  constructor(public authService: IdentityService, private toastr: ToastrService) {}
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
        catchError((error) => {
          if (error.error.validationDetails) {
            for(var key in error.error.errors){
              console.log(error.error.errors[key])
              error.error.errors[key].forEach(element => {
                this.toastr.error("Error", element, {
                  timeOut: 0,
                  extendedTimeOut: 0
                })
              });
    
            }
          }
          else {
          error.error.forEach(element => {
            this.toastr.error("Error", element, {
              timeOut: 0,
              extendedTimeOut: 0
            })
          });
        }
          return throwError(error.error);
        })
      )}
}