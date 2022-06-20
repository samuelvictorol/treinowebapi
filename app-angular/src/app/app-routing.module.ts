import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { PessoasComponent } from './Components/pessoas/pessoas.component';
import { ProfilesComponent } from './Components/profiles/profiles.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'pessoas', component: PessoasComponent},
  {path: 'profiles', component: ProfilesComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
