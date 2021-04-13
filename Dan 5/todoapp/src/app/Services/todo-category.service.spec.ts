import { TestBed } from '@angular/core/testing';

import { TodoCategoryService } from './todo-category.service';

describe('TodoCategoryService', () => {
  let service: TodoCategoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TodoCategoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
