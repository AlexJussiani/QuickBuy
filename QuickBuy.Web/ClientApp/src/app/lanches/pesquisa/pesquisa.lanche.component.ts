import { Component, OnInit } from "@angular/core";
import { Lanche } from "../../modelo/lanches";
import { LancheServico } from "../../../servicos/lanche/lanche.servico";
import { Router } from "@angular/router";

@Component({
    selector: "pesquisar-lanche",
    templateUrl: "./pesquisa.lanche.component.html",
    styleUrls: ["./pesquisa.lanche.component.css"]
})

export class PesquisaProdutoComponent implements OnInit {

    public lanches: Lanche[];
    
    ngOnInit(): void {
    }

    constructor(private lancheServico: LancheServico, private router: Router) {
        this.lancheServico.obterTodosLanches()
            .subscribe(
                lanches => {
                    this.lanches = lanches;
                },

                e => {
                    console.log(e.error);
                });
    }

    public adicionarProduto() {
        this.router.navigate(['/produto']);
    }

    public deletarProduto(lanche: Lanche) {
        var retorno = confirm("Deseja realmente deletar o produto selecionado ?");
        if (retorno == true) {
            this.lancheServico.deletar(lanche).subscribe(
                lanches => {
                    this.lanches = lanches;
                },
                e => {
                    console.log(e.errors);
                }
            )
        }

    }

    public editarProduto(lanche: Lanche) {
        sessionStorage.setItem('produtoSession', JSON.stringify(lanche));
        this.router.navigate(['/lanche']);
    }
}
