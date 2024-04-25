import { CommonModule } from '@angular/common';
import { Component, Input,OnInit } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  standalone:true,
  imports:[FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {
  @Input() formData: any;
  @Input() email: FormControl=new FormControl();
  @Input() name: FormControl=new FormControl();
  @Input() phone: FormControl=new FormControl();
  @Input() gender: FormControl=new FormControl();
  @Input() skills: FormControl = new FormControl();
  @Input() submitted: boolean=false;
  
  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      // Retrieve form data from query parameters
      this.formData = params;
    });
  }
}

