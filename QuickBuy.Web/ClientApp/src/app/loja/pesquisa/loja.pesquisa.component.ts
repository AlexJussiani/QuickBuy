import { Component, OnInit } from "@angular/core";
import { LancheServico } from "../../../servicos/lanche/lanche.servico";
import { Lanche } from "../../modelo/lanches";

@Component({
    selector: "app-loja",
    templateUrl: "/loja.pesquisa.component.html",
    styles: ["./loja.pesquisa.component.css"]
})
export class LojaPesquisaComponent implements OnInit {
    public lanches: Lanche[]; 

    ngOnInit(): void {
  
    }

    constructor(private produtoServico: LancheServico) {
        this.produtoServico.obterTodosLanches()
            .subscribe(
                lanches => {
                    this.lanches = lanches;
              },
                e => {
                    console.log(e.error);
                }
            )
    }

}
