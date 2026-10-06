using UnityEngine;

public class refillstest : MonoBehaviour
{
    private int refills = 0;
    private int maxRefills = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        do
        {
            Debug.Log("Serving coffee  refill number: " + refills);
            refills++;
        }
        while (refills < maxRefills);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
