using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketStall : MonoBehaviour
{
    [SerializeField]
    private int level = 1;
    [SerializeField]
    private float baseEarningRate = 1.0f;
    [SerializeField]
    private float earningRate, upgradeCost;

    // Start is called before the first frame update
    void Start()
    {
        earningRate = baseEarningRate;
        upgradeCost = (10 * level) * 1.1f ;
    }

    // Update is called once per frame
    void Update()
    {
        // Upgrading, Earning, Selling, Downgrading ? 
    }
}
