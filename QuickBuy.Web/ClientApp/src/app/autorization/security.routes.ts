import { Injectable } from "@angular/core";
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  UrlTree,
  Router,
} from "@angular/router";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class SecurityRoute implements CanActivate {
  constructor(private router: Router) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): boolean {
    const isAutenticated = JSON.parse(localStorage.getItem("isAutenticated"));

    if (isAutenticated) return true;

    this.router.navigate(["/login"], { queryParams: { returnUrl: state.url } });
    return false;
  }
}
