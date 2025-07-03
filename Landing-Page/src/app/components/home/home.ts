import { Component, AfterViewInit } from '@angular/core';
import Typed from 'typed.js';

@Component({
  selector: 'app-home',
  standalone: true,
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements AfterViewInit {
   ngAfterViewInit(): void {
    const options = {
      strings: ["Web Designer", "Software Engineer", "Web Developer", "Machine Learning Engineer"],
      typeSpeed: 100,
      backSpeed: 60,
      loop: true
    };

    new Typed('.typing', options);
  }
}
