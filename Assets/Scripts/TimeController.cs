using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : GameElement
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("timer");
    }

    public void TimeTick(float increment)
    {
        if (increment < 60.0f)
        {
            // if counting over into the next hour
            if (game.model.timeMinutes + increment >= 60)
            {
                float distanceToNextHour = 60 - game.model.timeMinutes;
                float newTimeMinutes = increment - distanceToNextHour;
                game.model.timeMinutes = newTimeMinutes;
                
                // check for flip am & pm
                if (game.model.timeHour == 11)
                {
                    if (game.model.timeAmPm == "am")
                    {
                        game.model.timeAmPm = "pm";
                    }
                    else
                    {
                        game.model.timeAmPm = "am";
                    }
                }
                
                // check for hour over 12
                if (game.model.timeHour == 12)
                {
                    game.model.timeHour = 1;
                }
                else
                {
                    game.model.timeHour++;
                }

            }
            else
            {
                game.model.timeMinutes += increment;
            }
        }
        
        //print time
        //game.view.timeView.printTime();
    }

    public IEnumerator timer()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(game.model.timeBreak);
            TimeTick(game.model.timeIncrement);
        }
    }
}
