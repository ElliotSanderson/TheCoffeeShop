using UnityEngine;

public class forloop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for  (int i = 0; i < 5; i++)
        {
            Debug.Log("Coffee number: " + i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
