﻿using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; 
    
    void Update()
    {
        transform.position = player.position + offset; 
    }
}
