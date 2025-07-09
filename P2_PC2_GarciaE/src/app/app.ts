import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Navbar } from './components/navbar/navbar';
import { Footer } from './components/footer/footer';
import { Home } from './pages/home/home';
import { About } from './pages/about/about';
import { Services } from './pages/services/services';
import { Contact } from './pages/contact/contact';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Navbar, Footer, Home, About, Services, Contact],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'P2_PC2_GarciaE';
}
