import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
import { start } from 'repl';

@Injectable({
  providedIn: 'root'
})
export class CrudService {
  private tasks:string[]=[];

  constructor() {}
   
   addTask(task:string):void{
     this.tasks.push(task);
   }
   getTask():string[]{
    return this.tasks;
   }
   deleteTask(start:number):void{
     this.tasks.splice(start,1);
   }
   editTask(start:number,editTask:string):void{
    this.tasks[start]=editTask;
   }
   
}
