using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : GameElement
{
    // all data variables ---
    public float timeHour = 7.0f;
    public float timeMinutes = 10.0f;
    public float timeIncrement = 1.0f;
    public float timeBreak = 0.5f;
    public string timeAmPm = "am";
    public Ingredients ingredients;
    public Products products;
    public PlayerModel playerModel;
    public Creatures creatures;
    public Prefabs prefabs;
    
    private void Awake()
    {
        
    }
}
