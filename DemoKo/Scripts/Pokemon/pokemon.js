var PokemonViewModel = function () {

    this.name = ko.observable("Pikachu");
    this.number = ko.observable("25");
    this.description = ko.observable("blahblah.");

    this.availablesTypes = ["Acero", "Agua", "Bicho", "Dragón", "Eléctrico", "Fantasma", "Fuego", "Hada", "Hielo", "Lucha", "Normal", "Planta", "Psíquico", "Roca", "Siniestro", "Tierra", "Veneno", "Volador"];
    this.selectedType = ko.observable("Eléctdddrico");
    
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
        alert(this.selectedType());
    };
}