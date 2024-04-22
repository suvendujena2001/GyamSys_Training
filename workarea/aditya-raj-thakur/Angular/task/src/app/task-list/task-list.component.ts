import { Component, OnInit } from '@angular/core';
import { CrudService } from '../crud.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './task-list.component.html',
  styleUrl: './task-list.component.css'
})
export class TaskListComponent  implements OnInit{
  tasks:string[]=[];
  task:string='';

 
  constructor(private crudService:CrudService){}
  
  
  addTask():void{
    if(this.task.trim()!== ''){
      this.crudService.addTask(this.task);
      this.task="";
    }
   
  }
  editTask(start:number):void{
    const newTask = prompt("Enter update task",this.tasks[start])
    if(newTask!=null){
    this.crudService.editTask(start,newTask);
  }
}
  deleteTask(start:number):void{
    this.crudService.deleteTask(start);

  }
  ngOnInit(): void {
    this.tasks=this.crudService.getTask();

    
}
}
