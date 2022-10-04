using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : GameElement
{
    // reference to all controllers
    public TimeController timeController;
    public PlayerController playerController;
    public SpawnerController SpawnerController;
    
    
    private void Start()
    {
        game.view.spawnerView.spawnCustomer();
    }
}
