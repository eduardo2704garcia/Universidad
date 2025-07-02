import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Card } from '../card/card';

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [CommonModule, Card],
  templateUrl: './list.html',
  styleUrl: './list.css'
})
export class List {
    programs = [
    {
      name: 'Programa de Inclusión Digital',
      description: 'Capacitación gratuita en herramientas tecnológicas para jóvenes.',
      image: 'images/inclusion.jpeg',
      participants: 0
    },
    {
      name: 'Apoyo Escolar Comunitario',
      description: 'Clases de refuerzo para estudiantes en zonas rurales.',
      image: 'images/apoyo.jpeg',
      participants: 0
    }
  ];
}
