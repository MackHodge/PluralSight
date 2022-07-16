import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable ,  throwError } from "rxjs";
import { IProduct } from "./product";
import {catchError ,tap,} from "rxjs/operators"

//This makes it a services 
@Injectable({
    providedIn:'root'   
})
export class ProductService {
    private productUrl = 'api/products/products.json';
    constructor (private http: HttpClient){
    }

    //get product method that return a list of product
    //this return nothing until we subscribe 
    getProduct(): Observable<IProduct[]> {
        return this.http.get<IProduct[]>(this.productUrl).pipe( 
            //Stringify convert an object or an array of object to an array of JSON string
        tap(data => console.log('All: ' , JSON.stringify(data))),
        catchError(this.handleError)
        );
    }

    private handleError(err: HttpErrorResponse){ 

        let errorMessage = ''; 
        if(err.error instanceof ErrorEvent){
            errorMessage = `An error occurred: ${err.error.message}`; 

        }else {
            errorMessage = `Server returned code: ${err.status} , error message is : ${err.message}`;
        }
        console.error(errorMessage); 
        return throwError(() =>errorMessage);
    }
}