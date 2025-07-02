import { Component, Input, Signal, signal, computed, OnInit } from '@angular/core';

@Component({
  selector: 'app-card',
  standalone: true,
  templateUrl: './card.html',
  styleUrl: './card.css',
  imports: []
})
export class Card implements OnInit {
  @Input() name!: string;
  @Input() description!: string;
  @Input() image!: string;
  @Input() initialParticipants!: number;

  private _participantes = signal(0);
  participantes = computed(() => this._participantes());

  ngOnInit() {
    this._participantes.set(this.initialParticipants || 0);
  }

  incrementarParticipantes() {
    this._participantes.update(p => p + 1);
  }

  decrementarParticipantes() {
    this._participantes.update(p => Math.max(0, p - 1));
  }
}
