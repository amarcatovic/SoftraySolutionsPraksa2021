import { TodoService } from './../Services/todo.service';
import { Component, OnInit } from '@angular/core';
import { Todo } from '../Models/Todo';

@Component({
  selector: 'app-todolist',
  templateUrl: './todolist.component.html',
  styleUrls: ['./todolist.component.css']
})
export class TodolistComponent implements OnInit {

  todos: Todo[];

  constructor(private todoService: TodoService) { }

  ngOnInit(): void {
    this.todoService.getTodos()
      .subscribe(response => this.todos = response);
  }
}
