import { Injectable } from "@angular/core";
import { IProduct } from "./product";

//This makes it a services 
@Injectable({
    providedIn:'root'   
})
export class ProductService {


    //get product method that return a list of products
    getProducts(): IProduct[]{
        return [
            {
                "productId": 2,
                "productName": "Garden Cart",
                "productCode": "GDN-0023",
                "releaseDate": "March 18, 2021",
                "description": "15 gallon capacity rolling garden cart",
                "price": 32.99,
                "starRating": 2.2,
                "imageUrl": "assets/images/garden_cart.png"
              },
              {
                "productId": 5,
                "productName": "Hammer",
                "productCode": "TBX-0048",
                "releaseDate": "May 21, 2021",
                "description": "Curved claw steel hammer",
                "price": 8.9,
                "starRating": 4.8,
                "imageUrl": "assets/images/hammer.png"
              }, 
              {
                "productId": 6,
                "productName": "Bin",
                "productCode": "TTX-0048",
                "releaseDate": "May 21, 2022",
                "description": "Curved claw steel hammer",
                "price": 2.9,
                "starRating": 1.8,
                "imageUrl": "assets/images/hammer.png"
              }
        
        ]
    }
}