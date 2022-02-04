import { Component } from "@angular/core";

@Component({
  //selector is the name of the component when we use it as directive  
 selector: 'pm-root' , 
 template: `
 <div> 
<h1>{{pagetitle}} </h1>
<div>My First Component</div>
<p> {{number}} </p>
<pm-products></pm-products>
 </div>`  
})    
 
export class AppComponent {
pagetitle : string = 'Product Management'  
number : string = ""
}