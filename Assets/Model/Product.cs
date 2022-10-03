using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : GameElement
{
    public string name { get; set; }
    public string type { get; set; }
    public float price { get; set; }
    public List<Ingredient> ingredients  { get; set; }

    public Product(string _name, string _type, float _price, List<Ingredient> _ingredients)
    {
        name = _name;
        type = _type;
        price = _price;
        ingredients = _ingredients;
    }
}
