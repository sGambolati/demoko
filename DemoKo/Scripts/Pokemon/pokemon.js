var PokemonViewModel = function () {

    this.name = ko.observable("Pikachu");
    this.number = ko.observable("25");

    this.selectedType = ko.observable(0);
};