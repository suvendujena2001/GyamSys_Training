import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  tasks: string[] = [];

  constructor() { }

  addTask(task: string): void {
    this.tasks.push(task);
  }

  deleteTask(index: number): void {
    this.tasks.splice(index, 1);
  }

  getTasks(): string[] {
    return this.tasks;
  }

  updateTask(index: number, newTask: string): void {
    this.tasks[index] = newTask;
  }
  
}
