import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Ingredientes } from "../../app/modelo/ingredientes";

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
};

@Injectable({
    providedIn: "root"
})

export class IngredienteServico implements OnInit {
    public ingredientes: Ingredientes[];
    private _baseUrl: string;

    constructor(private http: HttpClient, @Injectable('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    ngOnInit(): void {
        this.ingredientes = [];
       
    }

    get headers(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'applicaton/json')
    }

    public cadastrar(ingrediente: Ingredientes): Observable<Ingredientes> {
        return this.http.post<Ingredientes>(this._baseUrl + "api/ingrediente", JSON.stringify(ingrediente), httpOptions);
    }

}

