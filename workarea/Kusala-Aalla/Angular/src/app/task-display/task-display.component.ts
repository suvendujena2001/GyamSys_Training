import { Component } from '@angular/core';
import { TaskService } from '../task.service';
import { Input } from '@angular/core';

@Component({
  selector: 'app-task-display',
  standalone: true,
  imports: [],
  templateUrl: './task-display.component.html',
  styleUrl: './task-display.component.css'
})
export class TaskDisplayComponent {
  
  @Input() task!: string[];

  constructor(public taskService: TaskService) {}
}
