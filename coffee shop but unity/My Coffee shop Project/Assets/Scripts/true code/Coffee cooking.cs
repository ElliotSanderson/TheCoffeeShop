using System.Collections.Generic;
using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class Coffeecooking : MonoBehaviour
{ 
    public enum CoffeeType
    {
        espresso,
        latte,
        cappuccino,
        americano,
        mocha,
        none
    }
    private float coffeetime;
    [SerializeField]
    private CoffeeType coffeeOrder;




// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        switch (coffeeOrder)
        {
            case CoffeeType.espresso:
                coffeetime = 4f;
                break;
            case CoffeeType.latte:
                coffeetime = 5f;
                break;
            case CoffeeType.cappuccino:
                coffeetime = 3f;
                break;
            case CoffeeType.americano:
                coffeetime = 4f;
                break;
            case CoffeeType.mocha:
                coffeetime = 5f;
                break;
        }
        StartCoroutine(MakeCoffee());
    }



    private IEnumerator MakeCoffee()
    {
        yield return new WaitForSeconds(coffeetime);
        Debug.Log("coffee ready!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}