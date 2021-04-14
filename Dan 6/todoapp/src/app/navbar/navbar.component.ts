import { TodoService } from './../Services/todo.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  todoSize: number;

  constructor(private todoService: TodoService) { }

  ngOnInit(): void {
    this.todoService.todosLoaded
      .subscribe(response => this.todoSize = response);
  }

}
