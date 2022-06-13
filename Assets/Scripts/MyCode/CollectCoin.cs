using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private int coin;

    public int Coin { get => coin; private set => coin = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private int CoinDelivered()
    {
        var coinD = Coin;
        Coin = 0;
        return coinD;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            Destroy(other.gameObject);
            Coin++;
        }

        else if (other.GetComponent<CoinReceiver>())
            other.GetComponent<CoinReceiver>().CoinAmount = CoinDelivered();
    }
}
