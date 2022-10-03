using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Products : GameElement
{
    public List<Product> products = new List<Product>();
    public Product bread, ale, friedEels;

    public void init()
    {
        bread = new Product("Bread","food",1, new List<Ingredient>{game.model.ingredients.wheat, game.model.ingredients.water});
        ale = new Product("Ale","drink",3, new List<Ingredient>{game.model.ingredients.hops, game.model.ingredients.water});
        friedEels = new Product("Fried Eels","food",4, new List<Ingredient>{game.model.ingredients.eels, game.model.ingredients.spices});
    }
}
