import { Component, OnInit, Input } from '@angular/core';
import { FormComponent } from '../form/form.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-details',
  standalone: true,
  imports: [FormComponent, CommonModule],
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent implements OnInit {
   formData: any;


  constructor() {}

  
  ngOnInit(): void {
    this.formData = history.state.data;
    
  }
}
