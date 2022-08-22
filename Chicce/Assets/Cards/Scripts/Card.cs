using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public int id;
    public string cardName;
    public int color;
    public int power;
  
    public void print()
    {
        Debug.Log(cardName + ": Color number is: " + color + " Its power is: " + power);
    }
}

