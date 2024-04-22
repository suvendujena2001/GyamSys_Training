// task.component.ts
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Task } from '../Models/task.model';
import { TaskService } from '../Services/task.service';
import { RouterOutlet } from '@angular/router';
import { AppComponent } from '../app.component';
import { AddTaskComponent } from '../add-task/add-task.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css'],
  standalone:true,
  imports: [RouterOutlet,AppComponent,TaskComponent,AddTaskComponent,FormsModule,CommonModule]
})
export class TaskComponent {
  @Input() task!: Task;
  @Output() deleteTaskEvent: EventEmitter<number> = new EventEmitter<number>();

  constructor(private taskService: TaskService) {this.task = { id: 0, title: '', description: '' }; }

  deleteTask(id: number): void {
    this.taskService.deleteTask(id);
    this.deleteTaskEvent.emit(id);
  }
}
