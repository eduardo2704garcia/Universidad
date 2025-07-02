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

  private _participants = signal(0);
  participants = computed(() => this._participants());

  ngOnInit() {
    this._participants.set(this.initialParticipants || 0);
  }

  incrementParticipants() {
    this._participants.update(p => p + 1);
  }

  decrementParticipants() {
    this._participants.update(p => Math.max(0, p - 1));
  }
}
