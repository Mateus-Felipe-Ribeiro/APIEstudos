import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from './../shared/services/authentication.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  isCollapsed: boolean = false;
  isUserAuthenticated: boolean;

  constructor(public authService: AuthenticationService, private router: Router) {
    this.authService.authChanged
    .subscribe(res => {
      this.isUserAuthenticated = res;
    })
   }

  ngOnInit(): void {
    this.authService.authChanged
    .subscribe(res => {
      this.isUserAuthenticated = res;
    })
  }

  public logout = () => {
    this.authService.logout();
    this.router.navigate(["/"]);
  }

}
