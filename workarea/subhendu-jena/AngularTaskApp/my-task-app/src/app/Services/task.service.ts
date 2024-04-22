// task.service.ts
import { Injectable } from '@angular/core';
import { Task } from '../Models/task.model';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  tasks: Task[] = [];

  constructor() { }

  getAllTasks(): Task[] {
    return this.tasks;
  }

  addTask(task: Task): void {
    this.tasks.push(task);
  }

  // deleteTask(id: number): void {
  //   console.log('Deleting task with id:', id);
  //   this.tasks = this.tasks.splice(id,1);
  //   console.log('Updated tasks:', this.tasks);
  // }
  
  deleteTask(id: number): void {
    console.log('Deleting task with id:', id);
  
    // Find the index of the task with the specified id
    const index = this.tasks.findIndex(task => task.id === id);
  
    // If the task with the specified id is found, remove it using splice
    if (index !== -1) {
      this.tasks.splice(index, 1);
    }
  
    console.log('Updated tasks:', this.tasks);
  }
  
  updateTask(updatedTask: Task): void {
    const index = this.tasks.findIndex(task => task.id === updatedTask.id);
    if (index !== -1) {
      this.tasks[index] = updatedTask;
    }
  }
}
