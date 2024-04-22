// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class TaskService {

//   constructor() { }
// }

import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  private tasks: BehaviorSubject<string[]> = new BehaviorSubject<string[]>([]);

  constructor() {}

  getTasks() {
    return this.tasks.asObservable();
  }

  addTask(task: string) {
    const currentTasks = this.tasks.value;
    currentTasks.push(task);
    this.tasks.next(currentTasks);
  }

  deleteTask(index: number) {
    const currentTasks = this.tasks.value;
    currentTasks.splice(index, 1);
    this.tasks.next(currentTasks);
  }
}
