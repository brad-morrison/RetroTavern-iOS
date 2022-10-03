using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameElement : MonoBehaviour
{
    public Game game
    {
        get { return GameObject.FindObjectOfType<Game>(); }
    }
}
public class Game : MonoBehaviour
{
    // base instances of the MVC
    public GameModel model;
    public GameController controller;
    public GameView view;

    void Awake()
    {
        // Init flow
        model.ingredients.init();
        model.products.init();
        model.creatures.init();
        model.playerModel.init();
    }
}
