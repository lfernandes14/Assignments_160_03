/*****************************************************************************
// File Name :         Fruit.cs
// Author :            Lynette Fernandes
// Creation Date :     January 24, 2024
//
// Brief Description : Creating fruit salad using
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public string name;
    public string color;
    public float weight;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name">name of the fruit</param>
    /// <param name="c"></param>
    /// <param name="w"></param>
    public Fruit(string name, string c, float w)
    {
        this.name = name;
        color = c;
        weight = w;
    }

    public Fruit()
    {
        name = "mandarin";
        color = "orange";
        weight = 1.0f;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public Fruit(string name)
    {
        this.name = name;
        color = "blue";
        weight = 2.7f;
    }

    public Fruit(float w) 
    {
        name = "watermelon";
        color = "red";
        weight = w;
    }
}
