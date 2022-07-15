import { Component, OnInit  } from '@angular/core' 
import { IProduct } from './product';
import { ProductService } from './product.service';

//Metadata & tempplate  2. component decorator is what makes this class a component  
@Component({
  //Selector means that we can use the component as a directive in any other component. Therfore using this component elsewhere we can also use its templates 
    selector: 'pm-products', 
    templateUrl: './product-list.component.html',
    styleUrls: ['./product-list.component.css']
})

//export the class so its available in other part of the application 
export class ProductListComponent implements OnInit{
  private _productService; 
  
  constructor(productService : ProductService) {
      this._productService = productService; 
  }

    productListTitle  = 'List of Product'; 
    imageWidth = 50;
    imageMargin = 2;
    showImage = false;
    //this is typescript 
    private _listFilter: string = '';
    get listFilter(): string {
      return this._listFilter;
    }

    set listFilter (value:string) {
      this._listFilter = value;
      console.log('in set',this._listFilter);
      this.filteredProducts = this.performFilter(value);
    }

    filteredProducts: IProduct [] = [];
//array in typescript 
    products : IProduct [] = [
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
  ];

  //Method in typescript 
  toggleImage():  void {
      this.showImage = !this.showImage; 
  }


  ngOnInit(): void {
   console.log("initialized method");
}

performFilter(productToFilter : string) : IProduct [] {
  productToFilter = productToFilter.toLocaleLowerCase();
  //filters out list of products to only those with a product name that inlcudes the list filter string
  //if the list filter string is empty it returns al product
  return this.products.filter((product:IProduct) => product.productName.toLocaleLowerCase().includes(productToFilter));
      

}
onRatingStarsClicked(message : string):void{
  this.productListTitle = message;

}

}