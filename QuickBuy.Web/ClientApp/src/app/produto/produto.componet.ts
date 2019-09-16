import { Component, OnInit } from "@angular/core"
import { Produto } from "../modelo/produto";
import { ProdutoServico } from "../../servicos/produto/pruduto.servico";

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})
export class ProdutoComponent implements OnInit {

  public produto: Produto
    public arquivoSelecionado: File;

  constructor(private produtoServico: ProdutoServico) {

  }

  public inputChange(files: FileList) {
    this.arquivoSelecionado = files.item(0);
    this.produtoServico.enviarArquivo(this.arquivoSelecionado)
      .subscribe(
        retorno => {
          console.log(retorno);
        },
        e => {
          console.log(e.error);
        });
  }

  ngOnInit(): void {
    this.produto = new Produto();

  }
  public cadastrar() {
    //this.produto
    //this.produtoServico.cadastrar(this.produto)
    //  .subscribe(
    //    produtoJson => {
    //      console.log(produtoJson);
          
    //    },
    //    e => {
    //      console.log(e.error);
    //    }
    //  );
  }
}
