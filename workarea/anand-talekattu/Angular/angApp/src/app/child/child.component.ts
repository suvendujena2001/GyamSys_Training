import { Component ,Input, Output,EventEmitter, OnChanges, SimpleChanges} from '@angular/core';


@Component({
  selector: 'app-child',
  standalone: true,
  imports: [],
  templateUrl: './child.component.html',
  styleUrl: './child.component.css'
})
export class ChildComponent implements OnChanges  {

 @Input() data:number=0;

 firstValue=0;
 laterValue=0;
 constructor(){}

 ngOnChanges(changes: SimpleChanges): void {
  if (changes['data'] && changes['data'].currentValue !== undefined) {
    this.firstValue = changes['data'].currentValue;
    this.laterValue = changes['data'].previousValue ?? 'No previous value';
  }
 
}
}
