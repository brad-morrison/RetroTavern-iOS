using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient
{
    public string name { get; set; }
    public double price { get; set; }

    public Ingredient(string _name, double _price)
    {
        name = _name;
        price = _price;
    }
}
