﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron : MonoBehaviour
{
    public string orderedMeat = "hamburger";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if ((Gameplay.deleteFood) && (Gameplay.currentMeat == orderedMeat ))
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 10;
        }
    }
}
