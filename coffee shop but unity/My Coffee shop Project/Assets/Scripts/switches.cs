using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class switchenums : MonoBehaviour
{
    public enum CoffeeType
    {
        espresso,
        latte,
        cappuccino,
        americano,
        mocha,
        nitro_cold_brew,
        none
    }
    
    [SerializeField] private CoffeeType coffeeOrder = CoffeeType.latte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //let's switch
        switch (coffeeOrder)
        {
            case CoffeeType.espresso:
                Debug.Log("Making a stronk Espresso");
                break;
            case CoffeeType.latte:
                Debug.Log("Preparing a creamy latte with steamed milk");
                break;
            case CoffeeType.cappuccino:
                Debug.Log("foaming at the mouth for a Cappucino");
                break;
            case CoffeeType.americano:
                Debug.Log("Pouring hot water into a rich Espresso for an Americano");
                break;
            case CoffeeType.mocha:
                Debug.Log("Mixing chocolate with Espresso for a Mocha");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
