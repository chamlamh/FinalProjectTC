using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    public string cardTag = "Card";
    public bool tests;
    public Transform test;

    private ThreeCard threeCard;
    private SpriteRenderer spriteRenderer;
    private Selectable selectable;
    private UpdateSprite updateSprite;


    public void showHand()
    {
        //GetComponentInChildren<Selectable>().faceUp = true;
        //GameObject cards = GameObject.FindWithTag(cardTag);
        //selectable = GetComponent<Selectable>();

        print("Clicked");
        print(test);

    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        test = this.transform.GetComponentInChildren<Transform>();
        print(test);
    }
}