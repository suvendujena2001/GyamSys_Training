import { Component,OnInit } from '@angular/core';
import { TaskService } from '../task.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DisplayTaskComponent } from '../display-task/display-task.component';

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [CommonModule,FormsModule,DisplayTaskComponent,],
  templateUrl: './task-list.component.html',
  styleUrl: './task-list.component.css'
})
export class TaskListComponent implements OnInit {
  tasks!: string[];
  updateActiveIndex: number = -1;
   toggle: boolean=false;

  constructor(private taskService: TaskService) { }

  ngOnInit(): void {
    this.tasks = this.taskService.getTasks();
  }
  activateUpdateButton(index: number): void {
    this.updateActiveIndex= index;
  }

  deleteTask(index: number): void {
    this.taskService.deleteTask(index);
    this.tasks = this.taskService.getTasks();
  }
  updateTask(index: number, newTask: string): void {
    
    if(this.toggle===false){
      this.toggle=true;
    }

    this.taskService.updateTask(index, newTask);
    this.tasks = this.taskService.getTasks();
  }
}
