import { Component } from '@angular/core';
import { UserService } from '../user.service';
import { CommonModule } from '@angular/common';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-show-profile',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './show-profile.component.html',
  styleUrl: './show-profile.component.css'
})
export class ShowProfileComponent {
  users:any[]=[];
 constructor(private userService:UserService,private toastr:ToastrService){}
 ngOnInit(): void {
  this.users=this.userService.getUsers();
  console.log(this.users);
}

onDelete(index:number):void{
  this.userService.deleteUser(index);
    this.toastr.success('profile has been deleted successfully','delete');
}
}
