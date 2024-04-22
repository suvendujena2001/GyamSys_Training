

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TaskServiceService {
  private tasks: string[] = [];

  constructor() { }

  getTasks(): string[] {
    return this.tasks;
  }

  addTask(task: string): void {
    this.tasks.push(task);
  }

  deleteTask(index: number): void {
    this.tasks.splice(index, 1);
  }

  updateTask(index: number, updatedTask: string): void {
    this.tasks[index] = updatedTask;
  }
}

