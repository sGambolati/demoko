function PokedexListViewModel() {
    var serlf = this;

    self.pokemons = ko.observableArray([]);
    self.getImageUrlOf = getImageUrlOf;

    getAllPokemon();

    function getAllPokemon()
    {
        $.get('/Data/ListAllPokemon'
            , ''
            , function (data) {
                self.pokemons(data);
            });
    }
    function getImageUrlOf(aPokemon)
    {
        var number = aPokemon.Number;
        if (aPokemon.Number < 10)
            number = "0" + number;
        if (aPokemon.Number < 100)
            number = "0" + number;

        return "http://assets.pokemon.com/assets/cms2/img/pokedex/detail/" + number + ".png";
    }
}

ko.applyBindings(new PokedexListViewModel());