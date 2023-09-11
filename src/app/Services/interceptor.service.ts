import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

//http interceptor used for adding base url 
export class InterceptorService implements HttpInterceptor {

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    alert("intercepted");
    const baseUrl = "localhost:900";
    const newReq = req.clone({ url: baseUrl + req.url })
    console.log(newReq);
    return next.handle(newReq);
  }
}
