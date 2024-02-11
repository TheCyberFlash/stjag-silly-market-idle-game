using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int money = 0;
    public int stallCost = 10;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Logic for earning money over time
    }

    public void PurchaseStall()
    {
        // Logic for adding a new market stall
        if (money >= stallCost)
        {
            money -= stallCost;
            Debug.Log("Market Stall purchased!");
        }
        else Debug.Log("Not enough money to purchase a new stall!");
    }

    public void FixedUpdate()
    {
        // Logic for upgrading existing market stall (3 possible upgrades.. ? )
    }
}
