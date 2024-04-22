import { Component, NgModule, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpService } from '../../../services/HttpService';
import { PageTitleComponent } from '../../page-title/page-title.component';
import { TaskListComponent } from '../../task-list/task-list.component';



@Component({
  selector: 'app-all-task',
  standalone: true,
  imports: [FormsModule, PageTitleComponent, TaskListComponent],
  templateUrl: './all-task.component.html',
  styleUrl: './all-task.component.css'
})
export class AllTaskComponent {
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
      this.taskList = result;
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
  onEdit(task: any) {
    const newTitle = prompt("Enter updated task", task.title); // Prompt user for updated task title
    if (newTitle !== null) {
      const updatedTask = { ...task, title: newTitle }; // Create a new task object with updated title
      this.httpService.updateTask(updatedTask).subscribe(() => {
        console.log("Task updated successfully");
        this.getAllTasks();
      });
    }
  }



  onDelete(task: any) {
    this.httpService.deleteTask(task.id).subscribe(() => {
      this.taskList = this.taskList.filter(t => t.id !== task.id);
    });
    console.log("Delete", task);
  }
}
