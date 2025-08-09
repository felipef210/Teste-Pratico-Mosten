import { Component, Input } from '@angular/core';
import { FilmeSerieDTO } from '../../../core/interfaces/filmeSerie';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-card-filme',
  imports: [RouterLink],
  templateUrl: './card-filme.component.html',
  styleUrl: './card-filme.component.css'
})
export class CardFilmeComponent {
  @Input()
  model!: FilmeSerieDTO;
}
