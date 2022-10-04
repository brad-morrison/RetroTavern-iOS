using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : GameElement
{
    public GameObject RandomSpawner()
    {
        int roll = Random.Range(1, 6);
        switch (roll)
        {
            case 1:
                return game.view.spawnerView.spawner1_left;
                break;
            case 2:
                return game.view.spawnerView.spawner1_right;
                break;
            case 3:
                return game.view.spawnerView.spawner1_left;
                break;
            case 4:
                return game.view.spawnerView.spawner1_right;
                break;
            case 5:
                return game.view.spawnerView.spawner1_left;
                break;
            case 6:
                return game.view.spawnerView.spawner1_right;
                break;
            default:
                return game.view.spawnerView.spawner1_left;
                break;
        }
    }
}
