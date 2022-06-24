import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { PessoasComponent } from './Components/pessoas/pessoas.component';
import { ProfilesComponent } from './Components/profiles/profiles.component';
import { VoosComponent } from './Components/voos/voos.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'pessoas', component: PessoasComponent},
  {path: 'profiles', component: ProfilesComponent},
  {path: 'passagens', component: VoosComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
