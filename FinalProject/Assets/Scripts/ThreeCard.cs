using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ThreeCard : MonoBehaviour
{
    public Text totalText;
    public Text cpuTotal;
    public Text playerTotal;

    public Sprite[] cardFaces;
    public GameObject cardPrefabs;
    public GameObject[] playerPos;
    public static string[] suits = new string[] { "S", "D", "C", "H"};
    public static string[] values = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
    public List<string>[] player;
    private List<string> player1 = new List<string>();
    private List<string> player2 = new List<string>();
    private List<string> player3 = new List<string>();

    private List<string> cpu1 = new List<string>();
    private List<string> cpu2 = new List<string>();
    private List<string> cpu3 = new List<string>();
    public GameObject info;

    public int totalCoin = 0;
    public int p1Coin = 1000;
    public int plBet = 100;
    public int cpuCoing = 1000;
    public int cpuBet = 100;

    public List<string> deck;
    // Start is called before the first frame update
    void Start()
    {
        player = new List<string>[] { player1, player2, player3, cpu1, cpu2, cpu3 };
        PlayCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayCards()
    {
        p1Coin = 1000;
        cpuBet = 1000;
        totalCoin = 0;
        playerTotal.text = "1000";
        cpuTotal.text = "1000";
        totalText.text = "0";
        info.SetActive(false);
        foreach (List<string> list in player)
        {
            list.Clear();
        }

        deck = GenerateDeck();
        Shuffle(deck);

        foreach (string card in deck)
        {
            print(card);
        }
        ThreeCardSort();
        StartCoroutine(ThreeCardDeal());
    }

    public static List<string> GenerateDeck()
    {
        List<string> newDeck = new List<string>();

        foreach (string v in values)
        {
            foreach(string s in suits)
            {
                newDeck.Add(s + v);
            }
        }

        return newDeck;
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    IEnumerator ThreeCardDeal()
    {
        for (int i = 0; i < 6; i++)
        {
            float yOffSet = 0;
            float zOffSet = 0.03f;
            foreach (string card in player[i])
            {
                yield return new WaitForSeconds(0.20f);

                GameObject newCards = Instantiate(cardPrefabs, new Vector3(playerPos[i].transform.position.x, playerPos[i].transform.position.y - yOffSet, playerPos[i].transform.position.z - zOffSet), Quaternion.identity, playerPos[i].transform);
                newCards.name = card;
                newCards.GetComponent<Selectable>().faceUp = false;

                yOffSet = yOffSet + 0.03f;
                zOffSet = zOffSet + 0.03f;
            }
        }
    }

    void ThreeCardSort()
    {
        for (int i = 0; i < 6; i++)
        {
                player[i].Add(deck.Last<string>());
                deck.RemoveAt(deck.Count - 1);
        }

    }

    public void RestartGame()
    {

    }
}
