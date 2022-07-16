import { Component, OnDestroy, OnInit  } from '@angular/core' 
import { Subscription } from 'rxjs';
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
export class ProductListComponent implements OnInit, OnDestroy {
  private _productService; 
  
  constructor(productService : ProductService) {
      this._productService = productService; 
  }

    productListTitle  = 'List of Product'; 
    imageWidth = 50;
    imageMargin = 2;
    showImage = false;
    errorMessage: string = '';
    //! tells the Typescript compiler that we will handle the assignment later 
    sub! : Subscription ; 
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
    products : IProduct [] = []; 

  //Method in typescript 
  toggleImage():  void {
      this.showImage = !this.showImage; 
  }


  ngOnInit(): void {
    //hmmm
    this.sub = this._productService.getProduct().subscribe({

      next: products => {
        this.products = products;
        this.filteredProducts = this.products;
      },
      error : err => this.errorMessage = err  
      
    });
}

ngOnDestroy(): void {
    this.sub.unsubscribe();
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