using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    //Both players hands
    public List<GameObject> Player1Hand = new List<GameObject>();
    public List<GameObject> Player2Hand = new List<GameObject>();
    //Each card in player1s hand
    public Transform p1C1;
    public Transform p1C2;
    public Transform p1C3;
    public Transform p1C4;
    public Transform p1C5;
    //Each card in player1s hand
    public Transform p2C1;
    public Transform p2C2;
    public Transform p2C3;
    public Transform p2C4;
    public Transform p2C5;
    //Reach the pile
    public CreateCards cc;
    //Hand ints
    public int fullHand;
    public int removed;
    //Card draw animation
    public Animation cardDrawAnimation;
    void Start()
    {
        StartCoroutine(StartOfGame());
    }
    void Update()
    {
        
    }
    public void RemovePhase()
    {
        //Set removed
    }
    public void DrawPhase()
    {
        for (int i = 0; i < removed; i++)
        {
            Player1Hand.Add(cc.pile[0]);
            cc.pile.RemoveAt(0);
            
        }
    }
    IEnumerator StartOfGame()
    {
        yield return new WaitForSeconds(2f);
        //First draw
        cardDrawAnimation.PlayQueued("P1C1_Animation");
        yield return new WaitForSeconds(1.1f);
        Player1Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player1Hand[0].transform.position = p1C1.position;
        Player1Hand[0].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P2C1_Animation");
        yield return new WaitForSeconds(1.1f);
        Player2Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player2Hand[0].transform.position = p2C1.position;
        Player2Hand[0].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P1C2_Animation");
        //second draw
        yield return new WaitForSeconds(1.1f);
        Player1Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player1Hand[1].transform.position = p1C2.position;
        Player1Hand[1].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P2C2_Animation");
        yield return new WaitForSeconds(1.1f);
        Player2Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player2Hand[1].transform.position = p2C2.position;
        Player2Hand[1].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P1C3_Animation");
        //Third draw
        yield return new WaitForSeconds(1.1f);
        Player1Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player1Hand[2].transform.position = p1C3.position;
        Player1Hand[2].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P2C3_Animation");
        yield return new WaitForSeconds(1.1f);
        Player2Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player2Hand[2].transform.position = p2C3.position;
        Player2Hand[2].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P1C4_Animation");
        //Forth draw
        yield return new WaitForSeconds(1.1f);
        Player1Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player1Hand[3].transform.position = p1C4.position;
        Player1Hand[3].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P2C4_Animation");
        yield return new WaitForSeconds(1.1f);
        Player2Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player2Hand[3].transform.position = p2C4.position;
        Player2Hand[3].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P1C5_Animation");
        //Fifth draw
        yield return new WaitForSeconds(1.1f);
        Player1Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player1Hand[4].transform.position = p1C5.position;
        Player1Hand[4].GetComponent<CardDisplay>().cardbackActive = false;
        cardDrawAnimation.PlayQueued("P2C5_Animation");
        yield return new WaitForSeconds(1.1f);
        Player2Hand.Add(cc.pile[0]);
        cc.pile.RemoveAt(0);
        Player2Hand[4].transform.position = p2C5.position;
        Player2Hand[4].GetComponent<CardDisplay>().cardbackActive = false;

        Debug.Log("All starting cards distributed");
        // Animation and sound when drawing startinghand
    }
    //Make Rounds here ?

}
