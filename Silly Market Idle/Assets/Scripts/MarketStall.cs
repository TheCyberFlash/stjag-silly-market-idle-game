using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketStall : MonoBehaviour
{
    [SerializeField]
    private float baseEarningRate = 1.0f;
    public float earningRate, upgradeCost;
    public int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        earningRate = baseEarningRate;
        CalculateUpgradeCost();
    }

    // Update is called once per frame
    void Update()
    {
        // Upgrading, Earning, Selling, Downgrading ? 
    }

    void CalculateUpgradeCost()
    {
        upgradeCost = (10 * level) * 1.1f;
    }
}
