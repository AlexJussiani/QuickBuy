import {Component, OnInit } from "@angular/core";
import { ProdutoServico } from "../../../servicos/produto/pruduto.servico";
import { Produto } from "../../modelo/produto";

@Component({
    selector: "app-loja",
    templateUrl: "/loja.pesquisa.component.html",
    styles: ["./loja.pesquisa.component.css"]
})
export class LojaPesquisaComponent implements OnInit {
    public produtos: Produto[];

    ngOnInit(): void {
  
    }

    constructor(private produtoServico: ProdutoServico) {
        this.produtoServico.obterTodosProdutos()
            .subscribe(
                 produtos => {
                    this.produtos = produtos;
              },
                e => {
                    console.log(e.error);
                }
            )
    }

}
