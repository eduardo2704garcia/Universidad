import { Component } from '@angular/core';
import { Aside } from './components/aside/aside';
import { Home } from './components/home/home';
import { Portfolio } from './components/portfolio/portfolio';
import { Contact } from './components/contact/contact';
import { About } from './components/about/about';
import { StyleSwitcher } from './components/style-switcher/style-switcher';
import { Services } from './components/services/services';

@Component({
  selector: 'app-root',
  imports: [Aside, Home, Portfolio, Contact, About, StyleSwitcher, Services],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Landing-Page';
}
