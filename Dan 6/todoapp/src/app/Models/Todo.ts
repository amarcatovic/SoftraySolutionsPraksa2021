import { TodoCategory } from './TodoCategory';
export class Todo{
    id!: number;
    title!: string;
    description!: string;
    todoCategory!: TodoCategory;
    createdAt!: Date;
    finishedAt!: Date;
}