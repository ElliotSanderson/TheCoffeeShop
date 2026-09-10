using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{

    public int coffeeSold = 0;
    public float coffeePrice = 3.50f;
    public int amountOrdered = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("Hello, World");
       Debug.Log("I have ordered");
       Debug.Log(amountOrdered + "coffees");
       amountOrdered++;
       Debug.Log("Oops, I actually ordered" + amountOrdered + "coffees");
       

    }
    void AddCoffee()
    {
        coffeeSold =+ 1;
    }
    // Update is called once per frame
    
}

