﻿var PokemonViewModel = function () {

    var self = this;

    this.id = ko.observable(0);
    this.name = ko.observable("Pikachu");
    this.number = ko.observable("25");
    this.description = ko.observable("blahblah.");

    this.availablesTypes = ["Acero", "Agua", "Bicho", "Dragón", "Eléctrico", "Fantasma", "Fuego", "Hada", "Hielo", "Lucha", "Normal", "Planta", "Psíquico", "Roca", "Siniestro", "Tierra", "Veneno", "Volador"];
    this.selectedType = ko.observable("Eléctrico");

    //Attacks
    this.attacks = ko.observableArray([]);
    this.newAttackName = ko.observable();

    this.addAttack = function () {
        if (this.attacks().length < 4)
        {
            this.attacks.push(this.newAttackName());
            this.newAttackName("");
        }
        else {
            this.errorMessage("El pokémon sólo puede tener cuatro movimientos.");
        }
    };

    this.deleteAttack = function (attack) {
        self.attacks.remove(attack);
    };

    //Error Handling
    this.errorMessage = ko.observable("");
    this.hasErrorMessage = ko.computed(function () {
        return (this.errorMessage() != "");
    }, this);

    //Computed
    this.imageUrl = ko.computed(function () {
        var number = this.number();
        if (this.number() < 10)
            number = "0" + number;
        if (this.number() < 100)
            number = "0" + number;

        return "http://assets.pokemon.com/assets/cms2/img/pokedex/detail/" + number + ".png";
    }, this);

    //Subscribe
    //this.imageUrl = ko.observable("");
    //this.number.subscribe(function (newValue) {
    //    //this.imageUrl("http://assets.pokemon.com/assets/cms2/img/pokedex/detail/" + newValue + ".png");

    //    var number = newValue;
    //    if (newValue < 10)
    //        number = "0" + number;
    //    if (newValue < 100)
    //        number = "0" + number;
    //    console.log("http://assets.pokemon.com/assets/cms2/img/pokedex/detail/" + number + ".png");
    //}, this);


    this.send = function () {

        $.ajax({
            url: '/Data/AddPokemon',
            type: 'post',
            data: JSON.stringify(getData()),
            contentType: 'application/json',
            success: function() {
                alert("Catched!");
                window.location = '/';
            }
        });
    };
    function getData()
    {
        return {
            Id: self.id(),
            Name: self.name(),
            Number: self.number(),
            Description: self.description(),
            Moves: self.attacks(),
            Type: self.selectedType()
        };
    }
}