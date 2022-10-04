using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : GameElement
{
    // reference to other views
    public TimeView timeView;
    public PlayerView playerView;
    public SpawnerView spawnerView;
    
    
    public void printMsg(string msg)
    {
        Debug.Log(msg);
    }
}
