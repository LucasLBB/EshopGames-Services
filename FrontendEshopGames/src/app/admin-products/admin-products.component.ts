import { Component, OnInit } from '@angular/core';
import { ResponseProducts } from '../shared/models/responseProduct.model';
import { ProductService } from '../shared/services/product.service';

@Component({
  selector: 'app-admin-products',
  templateUrl: './admin-products.component.html',
  styleUrls: ['./admin-products.component.css']
})
export class AdminProductsComponent implements OnInit {

  adminProducts: ResponseProducts[];

  catalog: ResponseProducts = {
    id: 0,
    name: '',
    category_name: '',
    description: '',
    image_url: '',
    price: 0,
  }

  constructor(private productsService: ProductService) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts() {
    this.productsService.getProducts().subscribe(data =>{
    this.adminProducts = data;
    console.log(this.adminProducts)
    });
  }
}
