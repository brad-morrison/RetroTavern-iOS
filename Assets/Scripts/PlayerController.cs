using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : GameElement
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        game.view.playerView.printStock();
    }
}
