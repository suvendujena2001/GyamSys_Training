import { Component, inject } from '@angular/core';
import { PageTitleComponent } from '../../page-title/page-title.component';
import { HttpService } from '../../../services/HttpService';
import { TaskListComponent } from '../../task-list/task-list.component';

@Component({
  selector: 'app-completed-task',
  standalone: true,
  imports: [PageTitleComponent, TaskListComponent],
  templateUrl: './completed-task.component.html',
  styleUrl: './completed-task.component.css'
})
export class CompletedTaskComponent {
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
      this.taskList = result.filter((x: any) => x.completed == true);
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
