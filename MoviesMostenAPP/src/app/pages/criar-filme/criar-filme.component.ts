import { Component, inject } from '@angular/core';
import { FormFilmeComponent } from "../../shared/components/form-filme/form-filme.component";
import { CriarFilmeSerieDTO } from '../../core/interfaces/filmeSerie';
import { FilmeService } from '../../core/services/filme.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-criar-filme',
  imports: [FormFilmeComponent],
  templateUrl: './criar-filme.component.html',
  styleUrl: './criar-filme.component.css'
})
export class CriarFilmeComponent {
  private filmeService = inject(FilmeService);
  private router = inject(Router);

  errorMsg: string | null = null;

  onSubmit(dto: CriarFilmeSerieDTO) {
    this.filmeService.post(dto).subscribe({
      next: () => {
        this.router.navigate(['/'])
      },
      error: () => {
        this.errorMsg = 'Erro ao criar o filme ou série. Tente novamente.';
      }
    });

  }
}
