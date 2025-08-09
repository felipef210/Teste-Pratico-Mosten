import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { DetalhesFilmeComponent } from './pages/detalhes-filme/detalhes-filme.component';
import { CriarFilmeComponent } from './pages/criar-filme/criar-filme.component';

export const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'detalhes/:id', component: DetalhesFilmeComponent},
  {path: 'criar', component: CriarFilmeComponent},

  {path: '**', redirectTo: ''}
];
