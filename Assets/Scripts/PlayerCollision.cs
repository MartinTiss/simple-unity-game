﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "obstacle") 
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();    
        }
    }
}
