function PokedexListViewModel() {
    var serlf = this;

    self.pokemons = ko.observableArray([]);

    getAllPokemon();

    function getAllPokemon()
    {
        $.get('/Data/ListAllPokemon'
            , ''
            , function (data) {
                self.pokemons.removeAll();
                
                data.forEach(function (e) {
                    self.pokemons.add(e);
                });

            });
    }
}

ko.applyBindings(new PokedexListViewModel());