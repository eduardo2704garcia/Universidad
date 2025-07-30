import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';

import { ProductService, Product } from '../../services/products';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './products.html',
  styleUrl: './products.css'
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];
  newForm: FormGroup;
  editForm: FormGroup;
  editingId: number | null = null;

  constructor(
    private productService: ProductService,
    private fb: FormBuilder
  ) {
    // Form para crear
    this.newForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      description: [''],
      price: [0, [Validators.required, Validators.min(0)]],
    });
    // Form para editar
    this.editForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      description: [''],
      price: [0, [Validators.required, Validators.min(0)]],
    });
  }

  ngOnInit() {
    this.loadAll();
  }

  loadAll() {
    this.productService.getAll().subscribe(data => this.products = data);
  }

  // ▶ Crear
  onCreate() {
    if (this.newForm.invalid) return;
    this.productService.create(this.newForm.value).subscribe(() => {
      this.newForm.reset({ name: '', description: '', price: 0 });
      this.loadAll();
    });
  }

  // ▶ Preparar edición
  onEdit(product: Product) {
    this.editingId = product.id!;
    this.editForm.setValue({
      name: product.name,
      description: product.description,
      price: product.price
    });
  }

  // ▶ Cancelar edición
  onCancel() {
    this.editingId = null;
  }

  // ▶ Guardar edición
  onUpdate() {
    if (this.editForm.invalid || this.editingId === null) return;
    this.productService.update(this.editingId, this.editForm.value).subscribe(() => {
      this.editingId = null;
      this.loadAll();
    });
  }

  // ▶ Eliminar
  onDelete(id: number) {
    if (!confirm('¿Eliminar este producto?')) return;
    this.productService.delete(id).subscribe(() => this.loadAll());
  }
}
