using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float money = 10;
    public float earnings = 0f;
    public int stallCost = 10;
    public string moneyString = string.Empty;
    public List<MarketStall> stalls = new List<MarketStall>();
    public GameObject marketStallPrefab;
    public TextMeshProUGUI moneyText, newStallCost;

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

    void Start()
    {
        moneyString = money.ToString("F2");
        moneyText.text = $"Money: {moneyString}";
        newStallCost.text = $"New Stall Cost: {stallCost}";
    }

    // Update is called once per frame
    void Update()
    {
        earnings = CalculateEarnings();
        if (earnings > 0f)
        {
            //Debug.Log(earnings);
            IncreaseMoney(earnings);
        }    
    }

    public void PurchaseStall()
    {
        // Logic for adding a new market stall
        if (money >= stallCost)
        {
            money -= stallCost;
            Debug.Log("Market Stall purchased!");
            IncreaseStallCost();
            CreateNewMarketStall();
        }
        else Debug.Log("Not enough money to purchase a new stall!");
    }

    public void IncreaseStallCost()
    {
        stallCost = Mathf.RoundToInt(stallCost * 1.3f);
        newStallCost.text = $"New Stall Cost: {stallCost}";
        Debug.Log($"Stall cost increased to: {stallCost}");
    }

    public void CreateNewMarketStall()
    {
        GameObject newStallObj = Instantiate(marketStallPrefab);
        MarketStall newStall = newStallObj.GetComponent<MarketStall>();

        stalls.Add(newStall);
    }

    public void Upgrade()
    {
        // Logic for upgrading existing market stall (3 possible upgrades.. ? )
    }

    public float CalculateEarnings()
    {
        float totalEarnings = 0.0f;

        foreach (MarketStall market in stalls)
        {
            totalEarnings += market.earningRate;
        }

        return totalEarnings;
    }

    public void IncreaseMoney(float earnings)
    {
        money += earnings * Time.deltaTime;
        moneyString = money.ToString("F2");
        //Debug.Log($"Money: {moneyString}");
        moneyText.text = $"Money: {moneyString}";
    }
}
