import { Route } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { ProductComponent } from "./product/product.component";
import { LoginComponent } from "./user/login/login.component";
import { SecurityRoute } from "./autorization/security.routes";

export const Routes: Path[] = [
  { path: "", pathName: "Home", component: HomeComponent, pathMatch: "full" },
  { path: "counter", pathName: "Counter", component: CounterComponent },
  { path: "fetch-data", pathName: "Fetch Data", component: FetchDataComponent },
  {
    path: "product",
    pathName: "Product",
    component: ProductComponent,
    canActivate: [SecurityRoute],
  },
  { path: "login", pathName: "Login", component: LoginComponent },
];

export interface Path extends Route {
  pathName: string;
  isShow?: boolean;
}
