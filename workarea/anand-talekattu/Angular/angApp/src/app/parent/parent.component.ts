import { Component } from '@angular/core';
import { ChildComponent } from '../child/child.component';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-parent',
  standalone: true,
  imports: [ChildComponent,FormsModule],
  templateUrl: './parent.component.html',
  styleUrl: './parent.component.css'
})
export class ParentComponent {
count:number=0;
increment():void{
  this.count++;
}
}
