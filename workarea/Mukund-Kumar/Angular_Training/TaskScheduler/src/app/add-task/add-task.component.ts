// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-add-task',
//   standalone: true,
//   imports: [],
//   templateUrl: './add-task.component.html',
//   styleUrl: './add-task.component.css'
// })
// export class AddTaskComponent {

// }


// add-task.component.ts

import { Component } from '@angular/core';
import { TaskServiceService } from '../task-service.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-task',
  standalone:true,
  imports:[CommonModule,FormsModule],
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent {
  newTask: string = '';

  constructor(private taskService: TaskServiceService) { }

  addTask(): void {
    if (this.newTask.trim() !== '') {
      this.taskService.addTask(this.newTask);
      this.newTask = '';
    }
  }
}

