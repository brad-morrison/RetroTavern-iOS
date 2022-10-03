using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : GameElement
{
    public int gold;
    public List<Product> selling = new List<Product>();
    
    public void init()
    {
        game.model.playerModel.selling.Add(game.model.products.bread);
        game.model.playerModel.selling.Add(game.model.products.ale);
    }

}
