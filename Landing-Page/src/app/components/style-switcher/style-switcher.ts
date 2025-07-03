import { Component, Renderer2, signal } from '@angular/core';

@Component({
  selector: 'app-style-switcher',
  templateUrl: './style-switcher.html',
  styleUrl: './style-switcher.css',
  standalone: true
})
export class StyleSwitcher {

  activeColor = signal('color-1');//signal

  constructor(private renderer: Renderer2) {}

  setActiveStyle(color: string): void {
    this.activeColor.set(color);

    let colorValue = '';

    switch (color) {
      case 'color-1': colorValue = '#ec1839'; break;
      case 'color-2': colorValue = '#fa5b0f'; break;
      case 'color-3': colorValue = '#37b182'; break;
      case 'color-4': colorValue = '#1854b4'; break;
      case 'color-5': colorValue = '#f021b2'; break;
      case 'color-6': colorValue = '#ffc107'; break;
    }

    document.documentElement.style.setProperty('--skin-color', colorValue);
  }

  isActive(color: string): boolean {
    return this.activeColor() === color;
  }

  toggleSwitcher(): void {
    const switcher = document.querySelector('.style-switcher');
    if (switcher) {
      switcher.classList.toggle('open');
    }
  }

  toggleDarkMode(): void {
    const body = document.body;
    const icon = document.querySelector('.day-night i');

    if (body.classList.contains('dark')) {
      this.renderer.removeClass(body, 'dark');
      if (icon) icon.classList.remove('fa-sun');
      if (icon) icon.classList.add('fa-moon');
    } else {
      this.renderer.addClass(body, 'dark');
      if (icon) icon.classList.remove('fa-moon');
      if (icon) icon.classList.add('fa-sun');
    }
  }
}
