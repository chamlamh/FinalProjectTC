using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public bool top = false;
    public string suit;
    public int value;
    public int row;
    public bool faceUp = true;
    public bool inDeckPile = false;

    public bool playerWin;
    public bool cpuWin;

    public string playerCard1s;
    public string playerCard2s;
    public string playerCard3s;
    public int playerCard1v;
    public int playerCard2v;
    public int playerCard3v;

    public string cpuCard1s;
    public string cpuCard2s;
    public string cpuCard3s;
    public int cpuCard1v;
    public int cpuCard2v;
    public int cpuCard3v;


    public int playerWinPick;
    public int cpuWinPick;
    private string valueString;

    // Start is called before the first frame update
    void Start()
    {
        if (CompareTag("Card"))
        {
            suit = transform.name[0].ToString();

            for (int i = 1; i < transform.name.Length; i++)
            {
                char c = transform.name[i];
                valueString = valueString + c.ToString();

            }


            if (valueString == "A")
            {
                value = 1;
            }
            if (valueString == "2")
            {
                value = 2;
            }
            if (valueString == "3")
            {
                value = 3;
            }
            if (valueString == "4")
            {
                value = 4;
            }
            if (valueString == "5")
            {
                value = 5;
            }
            if (valueString == "6")
            {
                value = 6;
            }
            if (valueString == "7")
            {
                value = 7;
            }
            if (valueString == "8")
            {
                value = 8;
            }
            if (valueString == "9")
            {
                value = 9;
            }
            if (valueString == "10")
            {
                value = 10;
            }
            if (valueString == "J")
            {
                value = 11;
            }
            if (valueString == "Q")
            {
                value = 12;
            }
            if (valueString == "K")
            {
                value = 13;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string Winnner()
    {
        string winnerPick = "";


        return winnerPick;
    }
    private void PlayerHand()
    {
        // Three of the Kind
        if(playerCard1v == playerCard2v && playerCard2v == playerCard3v)
        {
            playerWinPick = 6;
        }
        // Flush
        if (playerCard2v == 20)
        {
            playerWinPick = 5;
        }
        //Stright
        if (playerCard2v == 20)
        {
            playerWinPick = 4;
        }
        //SameSuit
        if (playerCard1s == playerCard2s && playerCard2s == playerCard3s)
        {
            playerWinPick = 3;
        }
        //Pair
        if (playerCard1v == playerCard2v || playerCard1v == playerCard3v || playerCard2v == playerCard3v)
        {
            playerWinPick = 2;
        }
        //High Card
        else
        {
            playerWinPick = 1;
        }

    }

    private void CpuHand()
    {
        // Three of the Kind
        if (cpuCard1v == cpuCard2v && cpuCard2v == cpuCard3v)
        {
            cpuWinPick = 6;
        }
        // Flush
        if (playerCard1v == 20)
        {
            cpuWinPick = 5;
        }
        //Stright
        if (cpuCard3v == 20)
        {
            cpuWinPick = 4;
        }
        //SameSuit
        if (cpuCard1s == cpuCard2s && cpuCard2s == cpuCard3s)
        {
            cpuWinPick = 3;
        }
        //Pair
        if (cpuCard1v == cpuCard2v || cpuCard1v == cpuCard3v || cpuCard2v == cpuCard3v)
        {
            cpuWinPick = 2;
        }
        //High Card
        else
        {
            cpuWinPick = 1;
        }

    }

}
