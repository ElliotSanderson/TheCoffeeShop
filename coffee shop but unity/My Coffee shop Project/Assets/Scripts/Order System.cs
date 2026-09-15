using UnityEngine;

public class OrderSystem: MonoBehaviour
{   
    //camel casting i.e Variables
    private float _costOfCoffee= 4.50f;

    public int coffeeAmountOrdered;

    public float totalOrderAmount;
  //Pascal Casting i.e Method, Classes, Properties
   public void AmountPlaced(int coffeeAmountOrdered)
   {
      totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
      Debug.Log("Your Order Amount Today Is"+ " £ " + totalOrderAmount);
   }
}
