import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  public products: Product[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Product[]>(`${baseUrl}api/product`).subscribe(
      response => {
        console.log('response', response)
        this.products = response
      },
      err => {
        console.log('err', err)
      }
    )
  }
}

interface Product {
  id: number,
  name: string,
  description: string,
  price: number
}