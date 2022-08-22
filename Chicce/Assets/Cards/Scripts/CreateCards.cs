using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCards : MonoBehaviour
{
    public Card[] deckArray;
    public GameObject cardObject;
    public GameObject cardImage1;
    public GameObject cardImage2;
    public GameObject cardImage3;
    public List<GameObject> tempPile = new List<GameObject>();
    public List<GameObject> pile = new List<GameObject>();
    public void Start()
    {
        
        for (int i = 0; i < deckArray.Length; i++)
        {
            Instantiate(cardObject, new Vector3(700, 0, 0), Quaternion.identity);
            cardObject.GetComponent<CardDisplay>().card = deckArray[i];
        }
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Card"))
        {
            tempPile.Add(obj);
            //obj.tag = "Untagged";
        }
        shuffle();
    }
    public void shuffle()
    {
        int y = 0;
        for (int i = 0; i < 52; i++)
        {
            int x = Random.Range(0, tempPile.Count);
            pile.Add(tempPile[x]);
            tempPile.RemoveAt(x);
            y++;
            Debug.Log(pile[i].GetComponent<CardDisplay>().card);
        }
    }
    //Dont forget to add discard and pile to temppile in the end of round
    public void Update()
    {
        if (pile.Count >= 26)
        {
            cardImage1.SetActive(true);
            cardImage2.SetActive(true);
            cardImage3.SetActive(true);
        }
        else if (pile.Count < 26 && pile.Count >= 8)
        {
            cardImage1.SetActive(false);
            cardImage2.SetActive(true);
            cardImage3.SetActive(true);
        }
        else if (pile.Count < 8 && pile.Count >= 1)
        {
            cardImage1.SetActive(false);
            cardImage2.SetActive(false);
            cardImage3.SetActive(true);
        }
        else if (pile.Count < 1)
        {
            cardImage1.SetActive(false);
            cardImage2.SetActive(false);
            cardImage3.SetActive(false);
        }
    }
}
