import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Nav } from './home/nav/nav';
import { Footer } from './home/footer/footer';
import { WelcomePage } from './home/welcome-page/welcome-page';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CommonModule, Nav, Footer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'P2_PP2_GarciaE';
}
