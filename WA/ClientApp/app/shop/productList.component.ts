import { Component, OnInit } from "@angular/core";
import { DataService } from "../shared/dataService";
import { Product } from "../shared/product";
import { Router } from '@angular/router';
@Component({
    selector: "product-list",
    templateUrl: "productList.component.html",
    styleUrls: ["productList.component.css"]
})
export class ProductList implements OnInit {
    public products: Product[];
    tmpList: Product[] = [];
    selectedOption: string;
    searchTitle: string;
    neededPrice: number;
    neededPriceMax: number;
    haveData: boolean;
    constructor(private data: DataService, private router: Router) {
        this.products = data.products;
    }

    ngOnInit() {
        this.data.loadProducts()
            .subscribe(success => {
                if (success) {
                    this.products = this.data.products;
                    for (let p1 of this.products) {
                        if (p1.category == "Interroom door") {
                            p1.categoryRu = "Межкомнатная дверь";
                        }

                        if (p1.category == "Steel door") {
                            p1.categoryRu = "Металлическая дверь";
                        }

                        if (p1.category == "Furniture") {
                            p1.categoryRu = "Фурнитура";
                        }
                    };
                }
            });
    }

    addProduct(product: Product) {
        this.data.AddToOrder(product);
    }
    onForm() {
        this.products = [];
        this.products = this.data.products;
        this.haveData = false;
        console.log("Search for", this.searchTitle, this.selectedOption, this.neededPrice, this.neededPriceMax);
        if ((this.searchTitle != null) && (this.products.length > 0)) {
            this.searchElement();
            this.haveData = true;
        }
        else
            if (!this.haveData)
                this.products = this.data.products;

        if ((this.selectedOption != "") && (this.selectedOption != null) && (this.products.length > 0)) {
            this.searchCategory();
            this.haveData = true;
        }
        else
            if (!this.haveData)
                this.products = this.data.products;

        if ((this.neededPrice != null) && (this.products.length > 0)) {
            this.searchPrice();
            this.haveData = true;
        }
        else
            if (!this.haveData)
                this.products = this.data.products;

        if ((this.neededPriceMax != null) && (this.products.length > 0)) {
            this.searchPriceMax();
            this.haveData = true;
        }
        else
            if (!this.haveData)
                this.products = this.data.products;

        this.data.loadProducts()
            .subscribe(success => {
                if (success) {
                    this.products;
                    //console.log(this.products.length);
                }
            });
    }
    searchElement() {
        this.tmpList = [];
        for (let p1 of this.products) {
            //console.log(this.searchTitle, p1.title, "- title");
            if (p1.title == this.searchTitle) {
                this.tmpList.push(p1);
                //console.log("+");
            }
        };
        this.products = Object.assign([], this.tmpList);
    }

    searchCategory() {
        this.tmpList = [];
        for (let p1 of this.products) {
            if (p1.category == this.selectedOption) {
                this.tmpList.push(p1); 
            }
        };
        this.products = Object.assign([], this.tmpList);
    }

    searchPrice() {
        this.tmpList = [];
        for (let p1 of this.products) {
            if (p1.price >= Number(this.neededPrice)) {
                this.tmpList.push(p1);
            }
        };
        this.products = Object.assign([], this.tmpList);
    }
    searchPriceMax() {
        this.tmpList = [];
        for (let p1 of this.products) {
            if (p1.price <= Number(this.neededPriceMax)) {
                this.tmpList.push(p1);
            }
        };
        this.products = Object.assign([], this.tmpList);
    }
}