using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : GameElement
{
    public string species { get; set; }
    public List<Product> baseLikes = new List<Product>();
    public List<Product> baseDislikes = new List<Product>();

    public Creature(string _species, List<Product> _baseLikes, List<Product> _baseDislikes)
    {
        species = _species;
        baseLikes = _baseLikes;
        baseDislikes = _baseDislikes;
    }

    public void printDetails()
    {
        Debug.Log("---- " + this.species + " ----");
        foreach (var data in this.baseLikes)
        {
            Debug.Log("likes - " + data.name);
        }
        foreach (var data in this.baseDislikes)
        {
            Debug.Log("dislikes - " + data.name);
        }
    }
}
