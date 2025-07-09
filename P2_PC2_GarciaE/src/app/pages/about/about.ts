import { Component,signal } from '@angular/core';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [],
  templateUrl: './about.html',
  styleUrl: './about.css'
})
export class About {
    user = signal({
    name: 'Eduardo García',
    email: 'eduardo.garcia@email.com',
    phone: '+593 987 654 321',
    country: 'Ecuador',
    about: 'Apasionado por el deporte y el desarrollo natural, por la vida sana y duradera.',
    avatar: '/images/SRC.jpg'
  });
}
