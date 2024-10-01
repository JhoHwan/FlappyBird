using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Obstacle")
        {
            GameManager.Instance.GameOver();
            return;
        }
        else 
        {
            GameManager.Instance.IncreaseScore();
            return;
        }
        
    }
}
