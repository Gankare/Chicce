using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Image cardSprite;
    public GameObject cardBack;
    public bool cardbackActive;
    public Sprite[] spriteArray;


    void Start()
    {
        cardbackActive = true;
        transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        cardSprite.sprite = spriteArray[card.id];
    }
    private void Update()
    {
        if (cardbackActive is false)
            cardBack.SetActive(false);
        else if (cardbackActive is true)
            cardBack.SetActive(true);
    }
}
