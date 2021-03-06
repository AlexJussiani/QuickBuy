import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Produto } from "../../app/modelo/produto";

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
};

@Injectable({
  providedIn: "root"
})
export class ProdutoServico implements OnInit {
    
  public produtos: Produto[];

  private _baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.produtos = [];
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'applicaton/json')
  }

    public cadastrar(produto: Produto): Observable<Produto> {
        return this.http.post<Produto>(this._baseUrl + "api/produto", JSON.stringify(produto), httpOptions);
  }

  public salvar(produto: Produto): Observable<Produto> {

      return this.http.post<Produto>(this._baseUrl + "api/produto/salvar", JSON.stringify(produto), httpOptions);
  }

  public deletar(produto: Produto): Observable<Produto[]> {
 
      return this.http.post<Produto[]>(this._baseUrl + "api/produto/deletar", JSON.stringify(produto), httpOptions);
  }

  public obterTodosProdutos(): Observable<Produto[]> {
    return this.http.get<Produto[]>(this._baseUrl + "api/produto");
  }

  public obterProduto(produtoId: number): Observable<Produto> {
    return this.http.get<Produto>(this._baseUrl + "api/produto/obter");
  }

  public enviarArquivo(arquivoSelecionado: File): Observable<string> {
    const formData: FormData = new FormData();
    formData.append("arquivoEnviado", arquivoSelecionado, arquivoSelecionado.name);
    return this.http.post<string>(this._baseUrl + "api/produto/enviarArquivo", formData);
  }


}
