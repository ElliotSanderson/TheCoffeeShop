using UnityEngine;

public class Machine : MonoBehaviour

{

    bool coffeeMachineOn = true;
    int sugarLevel = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (coffeeMachineOn)
        {
            Debug.Log("Brewing coffee...");
        }
        else
        {
            Debug.Log("Out of Beans");
        }
        
        if (sugarLevel == 1)
        {
             Debug.Log("Coffee + 1 sugar");
        }
        else if (sugarLevel == 2)
        {
             Debug.Log("Coffee + 2 sugar");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

}
