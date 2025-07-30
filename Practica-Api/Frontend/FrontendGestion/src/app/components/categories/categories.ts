import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CategoryService, Category } from '../../services/category';

@Component({
  selector: 'app-categories',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './categories.html',
  styleUrl: './categories.css'
})
export class CategoriesComponent implements OnInit {
  categories: Category[] = [];
  newForm: FormGroup;
  editForm: FormGroup;
  editingId: number | null = null;

  constructor(
    private categoryService: CategoryService,
    private fb: FormBuilder
  ) {
    this.newForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
      description: ['', Validators.maxLength(255)],
    });
    this.editForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
      description: ['', Validators.maxLength(255)],
    });
  }

  ngOnInit() {
    this.loadAll();
  }

  loadAll() {
    this.categoryService.getAll().subscribe(data => this.categories = data);
  }

  onCreate() {
    if (this.newForm.invalid) return;
    this.categoryService.create(this.newForm.value).subscribe(() => {
      this.newForm.reset();
      this.loadAll();
    });
  }

  onEdit(cat: Category) {
    this.editingId = cat.id!;
    this.editForm.setValue({
      name: cat.name,
      description: cat.description ?? ''
    });
  }

  onCancel() {
    this.editingId = null;
  }

  onUpdate() {
    if (this.editForm.invalid || this.editingId === null) return;
    this.categoryService.update(this.editingId, this.editForm.value).subscribe(() => {
      this.editingId = null;
      this.loadAll();
    });
  }

  onDelete(id: number) {
    if (!confirm('¿Eliminar esta categoría?')) return;
    this.categoryService.delete(id).subscribe(() => this.loadAll());
  }
}  

