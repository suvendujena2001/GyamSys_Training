import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private STORAGE_KEY = 'fusers';

  constructor() { }

  addUser(user: FormGroup): void {
    const newUser = user.value; 
    let fusers = this.getUsersFromStorage();
    fusers.push(newUser); 
    this.saveUsersToStorage(fusers);
  }

  deleteUser(index: number): void {
    const fusers = this.getUsersFromStorage();
    fusers.splice(index, 1);
    this.saveUsersToStorage(fusers);
  }

  getUsers(): any[] {
    return this.getUsersFromStorage();
  }

  updateUser(index: number, newUser: FormGroup): void {
    const fusers = this.getUsersFromStorage();
    fusers[index] = newUser.value;
    this.saveUsersToStorage(fusers);
  }
  getUserByEmail(email: string): any {
    const fusers = this.getUsersFromStorage();
    return fusers.find(user => user.Email === email);
  }

  private getUsersFromStorage(): any[] {
    const storedUsers = localStorage.getItem(this.STORAGE_KEY);
    return storedUsers ? JSON.parse(storedUsers) : [];
  }

  private saveUsersToStorage(fusers: any[]): void {
    localStorage.setItem(this.STORAGE_KEY, JSON.stringify(fusers));
  }
}
