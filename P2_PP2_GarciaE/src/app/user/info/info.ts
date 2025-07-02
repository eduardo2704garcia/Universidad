import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-info',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './info.html',
  styleUrl: './info.css'
})
export class Info {
   user = {
      name: 'Eduardo García',
      email: 'eduagarcia985@gmail.com',
      phone: '+593 987654321',
      country: 'Ecuador',
      about: 'Colaborador activo y propietario de "ATLAS".',
      avatar: 'images/SRC.jpg'
  };
}
