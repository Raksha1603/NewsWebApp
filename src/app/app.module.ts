import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import { NewsCategoryComponent } from './News_Category/news-category/news-category.component';
import { NewsCategoryFormComponent } from './News_Category/news-category-form/news-category-form.component';

@NgModule({
  declarations: [
    AppComponent,
    NewsCategoryComponent,
    NewsCategoryFormComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
