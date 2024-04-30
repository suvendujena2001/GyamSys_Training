import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {


  loggedOut :boolean =true;
  loggedIn: boolean = false;
  constructor() { }

  isLoggedIn() {
    return this.loggedIn;
  }
}
