import { Component, inject } from '@angular/core';
import { HeaderComponent } from "../../shared/components/header/header.component";
import { FooterComponent } from "../../shared/components/footer/footer.component";
import { RouterLink } from '@angular/router';
import { FilmeSerieDTO } from '../../core/interfaces/filmeSerie';
import { CardFilmeComponent } from "../../shared/components/card-filme/card-filme.component";
import { FilmeService } from '../../core/services/filme.service';

@Component({
  selector: 'app-home',
  imports: [HeaderComponent, FooterComponent, RouterLink, CardFilmeComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  items: FilmeSerieDTO[] = [];

  private filmeService = inject(FilmeService);

  constructor() {
    this.getRegistros();
  }

  getRegistros() {
    this.filmeService.get().subscribe((response) => {
      this.items = response;
    });
  }
}
