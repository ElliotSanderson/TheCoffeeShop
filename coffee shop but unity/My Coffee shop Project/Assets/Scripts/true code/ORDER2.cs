using UnityEngine;

public class ORDER2 : MonoBehaviour
{
    private float Coffeecost;
    private string coffeesize;
    private string coffeetype;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("(C)appucino, (A)mericano, or (F)rappucino");
        Debug.Log("(S)mall or (L)arge?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            coffeetype = "Cappucino";
            Coffeecost = 5.00f;
            Debug.Log("cappucino");
            Debug.Log("(S)mall or (L)arge?");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            coffeetype = "Americano";
            Coffeecost = 4.50f;
            Debug.Log("americano");
            Debug.Log("(S)mall or (L)arge?");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            coffeetype = "Frappucino";
            Coffeecost = 6.50f;
            Debug.Log("frappucino");
        
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            coffeesize = "Large";
            Coffeecost = Coffeecost += 1.50f;
            Debug.Log("large coffee");
            Debug.Log("a " + coffeesize + "" + coffeetype + " is £" + Coffeecost);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            coffeesize = "Small";
            Debug.Log("Small coffee");
            Debug.Log("a " + coffeesize + "" + coffeetype + " is £" + Coffeecost);
        }
    }
}
