import { Injectable, Output } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable, Subject, timer } from 'rxjs';
import { retryWhen, delayWhen } from 'rxjs/operators';
import { Todo } from '../Models/Todo';

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  @Output() todosLoaded: Subject<number> = new Subject<number>();

  constructor(private http: HttpClient) { }

  getTodos(): Observable<Todo[]>{
    return this.http.get<Todo[]>('https://localhost:5001/api/Todos')
      .pipe(
        retryWhen(error => error.pipe(
          delayWhen(() => timer(1000))
        ))
      );
  }

  addTodo(todo: Todo): Observable<any>{
    const headers = {'Content-Type': 'application/json'};
    return this.http.post('https://localhost:5001/api/Todos', todo, {headers});
  }

  onTodoListLoaded(todoListSize: number): void{
    this.todosLoaded.next(todoListSize);
  }
}
