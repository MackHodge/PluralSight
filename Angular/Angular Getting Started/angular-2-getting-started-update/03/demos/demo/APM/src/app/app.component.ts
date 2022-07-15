import { Component } from "@angular/core";

@Component({
  //selector is the name of the component when we use it as directive  
 selector: 'pm-root' , 
 template: `
 <div> 
  <!--Angular looks in the app.component.ts for the pm-products-->
<h1>{{pagetitle}} </h1>
<div>My First Component</div> 
<p> {{number}} </p>
<pm-products></pm-products>
 </div>`  
})    
 
export class AppComponent {
  //Typescript variable 
pagetitle : string = 'Product Management'  
number : string = ""
} 