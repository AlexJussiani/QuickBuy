import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Lanche } from "../../app/modelo/lanches";

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
};

@Injectable({
  providedIn: "root"
})
export class LancheServico implements OnInit {
    
  public lanches: Lanche[];

  private _baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.lanches = [];
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'applicaton/json')
  }

    public cadastrar(lanche: Lanche): Observable<Lanche> {
        return this.http.post<Lanche>(this._baseUrl + "api/lanche", JSON.stringify(lanche), httpOptions);
  }

    public salvar(lanche: Lanche): Observable<Lanche> {

        return this.http.post<Lanche>(this._baseUrl + "api/lanche/salvar", JSON.stringify(lanche), httpOptions);
  }

    public deletar(lanche: Lanche): Observable<Lanche[]> {
 
        return this.http.post<Lanche[]>(this._baseUrl + "api/lanche/deletar", JSON.stringify(lanche), httpOptions);
  }

    public obterTodosLanches(): Observable<Lanche[]> {
      return this.http.get<Lanche[]>(this._baseUrl + "api/lanche");
  }

  public obterProduto(produtoId: number): Observable<Lanche> {
      return this.http.get<Lanche>(this._baseUrl + "api/lanche/obter");
  }

}
