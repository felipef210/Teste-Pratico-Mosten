import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-modal',
  imports: [],
  templateUrl: './modal.component.html',
  styleUrl: './modal.component.css'
})
export class ModalComponent {
  @Output()
  btnSim: EventEmitter<void> = new EventEmitter<void>();

  @Output()
  btnNao: EventEmitter<void> = new EventEmitter<void>();
}
