import { Component,Input,Output,EventEmitter} from '@angular/core';

@Component({
  selector: 'app-task',
  standalone: true,
  imports: [],
  templateUrl: './task.component.html',
  styleUrl: './task.component.css'
})
export class TaskComponent {
  @Input() task: string = '';
  @Input() showDeleteButton: boolean = true; // Add this property
  @Output() delete: EventEmitter<void> = new EventEmitter<void>();

  onDelete(index:number) {
    this.delete.emit();
  }
}
