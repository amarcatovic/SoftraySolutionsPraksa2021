import { TodoCategory } from './../Models/TodoCategory';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TodoCategoryService {

  constructor(private http: HttpClient) { }

  getTodoCategories(): Observable<TodoCategory[]>{
    return this.http.get<TodoCategory[]>('https://localhost:5001/api/todoCategories');
  }
}
