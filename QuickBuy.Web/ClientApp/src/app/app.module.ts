import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { LancheComponent } from './lanches/lanche.componet'
import { LoginComponent } from './usuario/login/login.componet';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { UsuarioServico } from '../servicos/usuario/usuario.servico';
import { CadastroUsuarioComponent } from './usuario/cadastro/cadastro.usuario.component';
import { LancheServico } from '../servicos/lanche/lanche.servico';
import { PesquisaProdutoComponent } from './lanches/pesquisa/pesquisa.lanche.component';
import { LojaPesquisaComponent } from './loja/pesquisa/loja.pesquisa.component';
import { IngredienteComponent } from './ingrediente/ingrediente.component'

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    LancheComponent,
    LoginComponent,
    CadastroUsuarioComponent,
    PesquisaProdutoComponent,
    LojaPesquisaComponent,
    IngredienteComponent
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'lanche', component: LancheComponent},
      { path: 'entrar', component: LoginComponent },
      { path: 'novo-usuario', component: CadastroUsuarioComponent },
      { path: 'pesquisar-lanche', component: PesquisaProdutoComponent },
      { path: 'ingrediente', component: IngredienteComponent }
    ])
    ],
    providers: [UsuarioServico, LancheServico],
  bootstrap: [AppComponent]
})
export class AppModule { }

//{ path: 'produto', component: ProdutoComponent, canActivate: [GuardaRotas] },
