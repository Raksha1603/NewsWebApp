import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { News_Category} from './news-category/news-category.model';


@Injectable({
  providedIn: 'root'
})
export class NewsCategoryService {

  formData : News_Category = new News_Category();
  readonly url = 'https://localhost:44393/api/NewsCategory';
  list!: News_Category[];
  constructor(private http : HttpClient) { }

  postNewsCat (){
    return this.http.post(this.url,this.formData);
  }

  putNewsCat(){
    return this.http.put(`${this.url}/${this.formData.catId}`, this.formData);
  }  

  deleteNewsCat(){
    return this.http.delete(`${this.url}/${this.formData.catId}`);
  }

  refreshList(){
    this.http.get(this.url).toPromise().then(res => this.list = res as News_Category[] );
  }
}
