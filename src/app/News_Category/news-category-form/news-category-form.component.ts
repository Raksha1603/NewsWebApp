import { Component, OnInit } from '@angular/core';
import {News_Category} from './../../Shared/news-category/news-category.model';
import { NewsCategoryService } from '../../Shared/news-category.service';
import {NgForm} from '@angular/forms'
@Component({
  selector: 'app-news-category-form',
  templateUrl: './news-category-form.component.html',
  styles: [
  ]
})
export class NewsCategoryFormComponent implements OnInit {

  constructor(public service : NewsCategoryService) { }

  ngOnInit(): void {
  }

  resetForm(form : NgForm)
  {
    form.form.reset();
    this.service.formData = new News_Category();
  }
  onSubmit(form: NgForm) {
    this.insertRecord(form);
  }
  
  insertRecord(form: NgForm) {
    this.service.postNewsCat().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
      },
      err => { console.log(err); }
    )
  }

}
