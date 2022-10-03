using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : GameElement
{
    // ingredients
    public List<Ingredient> ingredientsList = new List<Ingredient>();
    public Ingredient wheat = new Ingredient("Wheat", 0.40);
    public Ingredient water = new Ingredient("Water", 0.0);
    public Ingredient hops = new Ingredient("Hops", 0.70);
    public Ingredient eels = new Ingredient("Eels", 2.00);
    public Ingredient spices = new Ingredient("Spices", 0.20);

    public void init()
    {
        // build ingredients list
        ingredientsList.Add(wheat);
        ingredientsList.Add(water);
        ingredientsList.Add(hops);
        ingredientsList.Add(eels);
        ingredientsList.Add(spices);
    }
}
