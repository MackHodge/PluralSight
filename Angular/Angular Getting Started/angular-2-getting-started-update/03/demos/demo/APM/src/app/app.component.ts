import { Component } from "@angular/core";

@Component({
  //selector is the name of the component when we use it as directive  
 selector: 'pm-root' , 
 template: `
 <div> 
  <!--Angular looks in the app.component.ts for the pm-products-->

<nav class='navbar navbar-expand navbar-light bg-light'> 
  <a class='navbar-brand' >{{pageTitle}} </a>
  <ul class="nav nav-pills">
    <li><a class='nav-link'>Home</a></li>
    <li><a class='nav-link'>Product List</a></li>
  </ul>
</nav>
<div class='container'> 
<router-outlet></router-outlet>
</div> 
`  
})    
 
export class AppComponent {
  //Typescript variable 
pageTitle : string = 'Product Management'  
number : string = ""
} 