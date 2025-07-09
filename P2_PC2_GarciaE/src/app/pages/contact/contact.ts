import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-contact',
  imports: [FormsModule, CommonModule],
  standalone: true,
  templateUrl: './contact.html',
  styleUrl: './contact.css'
})
export class Contact {
   user = {
    name: '',
    email: '',
    message: ''
  };

  submitForm() {
    alert(`Gracias ${this.user.name}, tu mensaje fue enviado.`);
    this.user = { name: '', email: '', message: '' };
  }
}
