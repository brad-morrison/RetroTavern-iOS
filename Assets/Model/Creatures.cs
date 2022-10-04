using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creatures : GameElement
{
    public List<Creature> creaturesList = new List<Creature>();
    public Creature human, ogre;
    
    public void init()
    {
        human = new Creature("Human", new List<Product>{game.model.products.bread, game.model.products.ale}, new List<Product>{game.model.products.friedEels});
        ogre = new Creature("Ogre", new List<Product>{game.model.products.friedEels, game.model.products.ale}, new List<Product>{game.model.products.bread});
    }
    
}
