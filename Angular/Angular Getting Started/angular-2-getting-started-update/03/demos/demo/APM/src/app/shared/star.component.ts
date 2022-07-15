import { Component, Input, OnChanges, Output ,EventEmitter} from "@angular/core";

//the start component will be used as a nested component in app.component.ts 
@Component({
    selector: 'pm-star', 
    templateUrl:'./star.component.html',
    styleUrls: ['./star.component.css']
})

export class StarComponent implements OnChanges{
    //from main container 
    @Input() rating: number = 0; 
    cropWidth: number = 75;    
    //output back to main container 
    @Output() ratingStarsClicked: EventEmitter<string> = new EventEmitter<string>();

    ngOnChanges( ): void {
        this.cropWidth = this.rating * 75/5; 
    }

    onClick(): void {
        this.ratingStarsClicked.emit(`The rating ${this.rating} was clicked`);
    }
}