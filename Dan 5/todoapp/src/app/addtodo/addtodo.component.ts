import { TodoCategoryService } from './../Services/todo-category.service';
import { TodoCategory } from './../Models/TodoCategory';
import { TodoService } from './../Services/todo.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-addtodo',
  templateUrl: './addtodo.component.html',
  styleUrls: ['./addtodo.component.css']
})
export class AddtodoComponent implements OnInit {

  form: FormGroup;
  categories: TodoCategory[];

  constructor(private formBuilder: FormBuilder, 
    private todoService: TodoService,
    private todoCategoriesService: TodoCategoryService,) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      title: ['', [Validators.required]],
      description: ['', [Validators.required]],
      todoCategoryId: ['', [Validators.required]]
    });

    this.todoCategoriesService.getTodoCategories()
      .subscribe(response => this.categories = response);
  }

  submit(): void{
    this.todoService.addTodo(this.form.value)
      .subscribe(() => console.log("todo has been added"));
  }

}
