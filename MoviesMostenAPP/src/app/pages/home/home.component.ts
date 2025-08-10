import { Component, inject } from '@angular/core';
import { FilmeSerieDTO } from '../../core/interfaces/filmeSerie';
import { CardFilmeComponent } from "../../shared/components/card-filme/card-filme.component";
import { FilmeService } from '../../core/services/filme.service';

@Component({
  selector: 'app-home',
  imports: [CardFilmeComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  items: FilmeSerieDTO[] = [];
  totalAvaliacoes!: number;
  totalCurtidas!: number;
  totalDescurtidas!: number;

  private filmeService = inject(FilmeService);

  constructor() {
    this.getRegistros();
    this.getTotalAvaliacoes();
  }

  getRegistros() {
    this.filmeService.get().subscribe((response) => {
      this.items = response;
      console.log(this.items);
    });
  }

  getTotalAvaliacoes() {
    this.filmeService.getTotalAvaliacoes().subscribe((response) => {
      this.totalAvaliacoes = response;
    });

    this.filmeService.getTotalCurtidas().subscribe((response) => {
      this.totalCurtidas = response;
    });

    this.filmeService.getTotalDescurtidas().subscribe((response) => {
      this.totalDescurtidas = response;
    });
  }
}
