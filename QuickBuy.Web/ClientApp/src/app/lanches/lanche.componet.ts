import { Component, OnInit } from "@angular/core";
import { Lanche } from "../modelo/lanches";
import { LancheServico } from "../../servicos/lanche/lanche.servico";

@Component({
  selector: "app-lanche",
  templateUrl: "./lanche.component.html",
  styleUrls: ["./lanche.component.css"]
})
export class LancheComponent implements OnInit {

    public ativar_spinner: boolean;
    public returnUrl: string;
    public mensagem: string;
    public lanche: Lanche;

    constructor(private LancheServico: LancheServico) {
    }

    ngOnInit(): void {
        this.lanche = new Lanche();
        //var produtoSession = sessionStorage.getItem('plancheSession');
        //if (produtoSession) 
        //  this.produto = JSON.parse(produtoSession);
        //else
        //  this.produto = new Produto();

  }


    public cadastrar() {
    //    this.ativarEspera();
    ////this.produtoServico.cadastrar(this.produto)
    //  .subscribe(
    //    produtoJson => {
    //      console.log(produtoJson);
    //          this.desativarEspera();
    //          this.router.navigate(['pesquisar-produto'])
    //    },
    //    e => {
    //        console.log(e.error);
    //        this.mensagem = e.error;
    //        this.desativarEspera(); 
    //    }
     // );
    }

    public ativarEspera() {
        this.ativar_spinner = true;
    }

    public desativarEspera() {
        this.ativar_spinner = false;
    }
}
