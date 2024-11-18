import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [ 
  {
    path: '',
    redirectTo: 'universidades-brasileiras',
    pathMatch: 'full',
  },
  {
    path: 'universidades-brasileiras',
    loadChildren: () => import('./university/university.module').then(m => m.UniversityModule) 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
