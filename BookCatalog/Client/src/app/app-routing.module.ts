import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [ 
{
  path: 'identity',
  loadChildren: () => import('./identity/identity.routing.module').then(m => m.IdentityRoutingModule)
},
{
  path: 'books',
  loadChildren: () => import('./books/book.routing.module').then(m => m.BookRoutingModule)
},
{
  path: 'authors',
  loadChildren: () => import('./authors/author.routing.module').then(m => m.AuthorRoutingModule)
},
{
  path: '',
  loadChildren: () => import('./shared/shared.routing.module').then(m => m.SharedRoutingModule)
},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
