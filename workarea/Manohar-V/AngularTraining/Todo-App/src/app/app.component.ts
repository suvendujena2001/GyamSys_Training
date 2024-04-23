import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Item } from './item';
import { ItemComponent } from './item/item.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CommonModule,ItemComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Todo-App';

  filter: "all" | "active" | "done" = "all";

  allItems = [
    {description: "eat", done: true},
    {description: "sleep", done: false},
    {description: "play", done: true},
    {description: "work", done: true},
  ];

  get items() {
    switch (this.filter) {
      case "all":
        return this.allItems;
      case "done":
        return this.allItems.filter(item => item.done);
      case "active":
        return this.allItems.filter(item => !item.done);
      default:
        return this.allItems;
    }
  }

  addItem (description: string) {
      if (!description) return;
    
      this.allItems.push({
        description,
        done: false
      });
  }
  
  remove (item: Item) {
    this.allItems.splice(this.allItems.indexOf(item), 1);
  }

}