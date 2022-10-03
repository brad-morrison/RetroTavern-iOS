using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : GameElement
{
    public Creature type { get; set; }
    public int gold { get; set; }
    public List<Product> likes = new List<Product>();
    public List<Product> dislikes = new List<Product>();
    public bool spawnedLeft = true;
    
    // move off screen
    public void MoveOffScreen()
    {
        if (spawnedLeft)
        {
            StartCoroutine(Move(this.transform.position, new Vector3(5, 1, 1), 2));
        }
        else
        {
            StartCoroutine(Move(this.transform.position, new Vector3(-5, 1, 1), 2));
        }
    }
    
    // move to stall
    public void MoveToStall()
    {
        
    }
    
    // stop
    public void Stop()
    {
        
    }

    public IEnumerator Move(Vector3 position, Vector3 target, float speed)
    {
        // speed should be 1 unit per second
        while (this.transform.position != target)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, target, speed * Time.deltaTime);
            yield return new WaitForEndOfFrame ();
        }
    }
}
