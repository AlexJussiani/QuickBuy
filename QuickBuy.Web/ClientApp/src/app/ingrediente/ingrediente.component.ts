import { Component, OnInit } from "@angular/core";
import { Ingredientes } from "../modelo/ingredientes";
import { IngredienteServico } from "../../servicos/ingrediente/ingrediente.servico";

@Component({
    selector: "app-ingrediente",
    templateUrl: "./ingrediente.component.html",
    styleUrls: ["./ingrediente.component.css"]
})

export class IngredienteComponent implements OnInit {
    public ingrediente: Ingredientes;

    constructor(private ingredienteServico: IngredienteServico) { }

    ngOnInit(): void {
        this.ingrediente = new Ingredientes();
        }
    
}
