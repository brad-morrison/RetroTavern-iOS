using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeView : GameElement
{
    public void printTime()
    {
        Debug.Log(game.model.timeHour + ":" + game.model.timeMinutes.ToString("00") + game.model.timeAmPm);
    }
}
