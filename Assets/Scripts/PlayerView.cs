using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : GameElement
{
    public void printStock(bool printIngredients = false)
    {
        foreach (var product in game.model.playerModel.selling)
        {
            Debug.Log(product.name);

            if (printIngredients)
            {
                foreach (var ingredient in product.ingredients)
                {
                    Debug.Log(product.name + " ingredient: " + ingredient.name);
                }
            }
        }
    }
}
