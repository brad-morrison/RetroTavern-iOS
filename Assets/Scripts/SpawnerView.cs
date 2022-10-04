using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerView : GameElement
{
    public GameObject spawner1_left, spawner2_left, spawner3_left;

    public GameObject spawner1_right, spawner2_right, spawner3_right;

    public void spawnCustomer()
    {
        GameObject customer = Instantiate(game.model.prefabs.customer, game.controller.SpawnerController.RandomSpawner().transform);
    }
}
