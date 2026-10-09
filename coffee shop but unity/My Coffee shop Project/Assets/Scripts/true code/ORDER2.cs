using UnityEngine;

public class orderSystemm : MonoBehaviour
{
    //camel casting i.e Variables
    private float _costOfCoffee = 4.50f;
    public int coffeeAmountOrdered;
    private float totalOrderAmount;

    //Pascal Casting i.e Method, Classes, Properties
    public void AmountPlaced(int coffeeAmountOrdered)
    {
        totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
    }
    void start()
    {
        Debug.Log("Your Order Amount Today Is " + "£" + totalOrderAmount);
    }
}
