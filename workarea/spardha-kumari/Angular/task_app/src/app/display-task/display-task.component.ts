import { Component } from '@angular/core';
import { Input } from '@angular/core';
import { TaskService } from '../task.service';
@Component({
  selector: 'app-display-task',
  standalone: true,
  imports: [],
  templateUrl: './display-task.component.html',
  styleUrl: './display-task.component.css'
})
export class DisplayTaskComponent {
  @Input() task!: string[];

  constructor() { }

}
