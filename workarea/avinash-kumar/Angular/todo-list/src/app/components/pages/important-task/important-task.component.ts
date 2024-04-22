import { Component, inject } from '@angular/core';
import { PageTitleComponent } from '../../page-title/page-title.component';
import { TaskListComponent } from '../../task-list/task-list.component';
import { HttpService } from '../../../services/HttpService';

@Component({
  selector: 'app-important-task',
  standalone: true,
  imports: [PageTitleComponent, TaskListComponent],
  templateUrl: './important-task.component.html',
  styleUrl: './important-task.component.css'
})
export class ImportantTaskComponent {
  newTask = "";
  taskList: any[] = [];
  httpService = inject(HttpService);
  ngOnInit() {
    this.getAllTasks();
  }
  addTask() {
    this.httpService.addTask(this.newTask).subscribe(() => {
      this.newTask = "";
      this.getAllTasks();
    })
  }
  getAllTasks() {
    this.httpService.getAllTasks().subscribe((result: any) => {
      this.taskList = result.filter((x: any) => x.important == true);
    })
  }
  onComplete(task: any) {
    task.completed = true;
    console.log("complete", task);
    this.httpService.updateTask(
      task)
      .subscribe(() => {

      })
  }
  onImportant(task: any) {
    task.important = true;
    console.log("Important", task);
    this.httpService.updateTask(
      task)
      .subscribe(() => {

      })
  }

}
