using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinReceiver : MonoBehaviour
{
    public UnityEvent onCoinFull;
    [SerializeField] private int coinAmount;
    [SerializeField] private int coinAmountTarget;

    public int CoinAmount { private get => coinAmount; set => coinAmount += value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CoinAmount == coinAmountTarget)
            onCoinFull.Invoke();
        
    }
}
