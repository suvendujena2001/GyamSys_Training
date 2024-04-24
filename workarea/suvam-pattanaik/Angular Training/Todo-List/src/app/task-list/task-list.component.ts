import { Component, OnInit} from '@angular/core';
import { TaskService } from '../task.service';
import { AddTaskComponent } from '../add-task/add-task.component';
import { TaskComponent } from '../task/task.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [AddTaskComponent,TaskComponent,CommonModule],
  templateUrl: './task-list.component.html',
  styleUrl: './task-list.component.css'
})
export class TaskListComponent implements OnInit {
  tasks: string[] =[];

  constructor(private taskService : TaskService){}

  ngOnInit(): void {
    this.taskService.getTasks().subscribe(tasks =>{
      this.tasks = tasks;
    });
  }

  deleteTask(index: number){
    this.taskService.deleteTask(index);
  }

}
