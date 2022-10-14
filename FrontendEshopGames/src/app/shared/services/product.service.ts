import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ResponseProducts } from '../models/responseProduct.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  apiUrl = 'http://localhost:5246/api/v1/';

  httpOptions = {
    headers: new HttpHeaders({
    })
  };

  constructor(
    private httpClient: HttpClient
  ) { }

  public getProducts(): Observable<ResponseProducts[]> {
    return this.httpClient.get<ResponseProducts[]>(this.apiUrl + 'Product');
  }
}
