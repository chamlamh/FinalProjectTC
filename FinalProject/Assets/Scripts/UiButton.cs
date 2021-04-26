using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiButton : MonoBehaviour
{
    public int totalCoin = 0;
    public int p1Coin = 1000;
    public int plBet = 100;
    public int cpuCoing = 1000;
    public int cpuBet = 100;

    public Text totalText;
    public Text cpuTotal;
    public Text playerTotal;
    private Selectable selectable;
    public GameObject info;
    public Button button1;


    // Start is called before the first frame update

    private void Awake()
    {
        info.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
        info.SetActive(true);

    }

    public void RestetGame()
    {
        UpdateSprite[] cards = FindObjectsOfType<UpdateSprite>();

        foreach (UpdateSprite card in cards)
        {
            Destroy(card.gameObject);
        }


        FindObjectOfType<ThreeCard>().PlayCards();

    }

    public void ShowCards()
    {
        StartCoroutine(betCoin());
    }

    IEnumerator betCoin ()
    {
        p1Coin = p1Coin - plBet;
        playerTotal.text = p1Coin.ToString();
        totalCoin = totalCoin + plBet;
        totalText.text = totalCoin.ToString();
        button1.enabled = false;

        yield return new WaitForSeconds(2);

        cpuCoing = cpuCoing - cpuBet;
        cpuTotal.text = p1Coin.ToString();
        totalCoin = totalCoin + cpuBet;
        totalText.text = totalCoin.ToString();
        button1.enabled = true;

    }
}

