import { isPlatformBrowser } from '@angular/common';

import { Inject, Injectable, PLATFORM_ID } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TaskServiceService {
  private tasks: string[] = [];
  private tasksKey = 'tasks';

  // constructor() {}


  constructor(@Inject(PLATFORM_ID) private platformId: Object) {
    if (isPlatformBrowser(this.platformId)) {
      const storedTasks = localStorage.getItem(this.tasksKey);
      if (storedTasks) {
        this.tasks = JSON.parse(storedTasks);
      }
    }
  }


  getTasks(): string[] {
    return this.tasks;
  }

  addTask(task: string): void {
    this.tasks.push(task);
    this.saveTasks();
  }

  deleteTask(index: number): void {
    this.tasks.splice(index, 1);
    this.saveTasks();
  }

  updateTask(index: number, updatedTask: string): void {
    this.tasks[index] = updatedTask;
    this.saveTasks();
  }

  private saveTasks(): void {
    if (isPlatformBrowser(this.platformId)) 
    {
      localStorage.setItem(this.tasksKey, JSON.stringify(this.tasks));
    }
  }
}

