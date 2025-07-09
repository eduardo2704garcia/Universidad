import { Component, computed, signal } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-services',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './services.html',
  styleUrl: './services.css'
})
export class Services {
  readonly weight = signal(25);
  readonly height = signal(1.69);

  readonly bmi = computed(() => {
    const w = this.weight();
    const h = this.height();
    return +(w / (h * h)).toFixed(1);
  });

  readonly category = computed(() => {
    const bmi = this.bmi();
    if (bmi < 18.5) return 'bajo';
    if (bmi < 25) return 'normal';
    if (bmi < 30) return 'sobrepeso';
    return 'obesidad';
  });

  inc = () => this.weight.set(this.weight() + 1);
  dec = () => this.weight.set(Math.max(40, this.weight() - 1));
  reset = () => this.weight.set(40);
}
