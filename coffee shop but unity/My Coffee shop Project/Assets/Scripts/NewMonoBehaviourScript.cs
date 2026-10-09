using UnityEngine;

public class beaaaaaaans : MonoBehaviour
{
    private int cups = 10;
    public int beans = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (beans > 0)
        {
            Debug.Log("new cup of coffee");
        }
        Debug.Log("out of beans");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
