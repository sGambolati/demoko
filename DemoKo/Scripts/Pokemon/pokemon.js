var PokemonViewModel = function () {

    this.name = ko.observable("Pikachu");
    this.number = ko.observable("25");

    this.availablesTypes = ["Acero", "Agua", "Bicho", "Dragón", "Eléctrico", "Fantasma", "Fuego", "Hada", "Hielo", "Lucha", "Normal", "Planta", "Psíquico", "Roca", "Siniestro", "Tierra", "Veneno", "Volador"];
    this.selectedType = ko.observable("Eléctrico");
    
    this.send = function () {
        alert(this.selectedType());
    };
}