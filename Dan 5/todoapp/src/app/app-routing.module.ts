import { AddtodoComponent } from './addtodo/addtodo.component';
import { TodolistComponent } from './todolist/todolist.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {path: '', component: TodolistComponent},
  {path: 'add', component: AddtodoComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
