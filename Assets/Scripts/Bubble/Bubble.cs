﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private int _colorNumber;
    private Vector2 _position;

    public int ColorNumber => _colorNumber;
    public Vector2 Position => _position;

    public void Move(int i,int j,int MaxLineLength)
    {
        float offset = 0;
        if (i % 2 == 0)
        {
            offset = 0;
        }
        else
        {           
            offset = 0.5f;
        }
        float x = (j + offset) * transform.localScale.x - (MaxLineLength * transform.localScale.x / 2);
        float y = (-i * transform.localScale.y) - transform.localScale.y;       
        transform.localPosition = new Vector2(x, y); ;
        _position = new Vector2(j, i);
    }



}
