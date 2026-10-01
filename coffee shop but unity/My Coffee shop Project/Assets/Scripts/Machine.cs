using UnityEngine;

public class Machine : MonoBehaviour

{

    bool coffeeMachineOn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (coffeeMachineOn)
        {
            Debug.Log("Brewing coffee...");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
