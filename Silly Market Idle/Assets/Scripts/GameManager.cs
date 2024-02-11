using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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
    }

    public void FixedUpdate()
    {
        // Logic for upgrading existing market stall (3 possible upgrades.. ? )
    }
}
