import { Component } from "@angular/core";
import { User } from "src/app/models/user";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"],
})
export class LoginComponent {
  user: User;

  constructor(private router: Router) {
    this.user = new User();
  }

  login() {
    if (this.user.email === "teste@teste.com" && this.user.password) {
      localStorage.setItem("isAutenticated", JSON.stringify(true));
    }
  }
}
