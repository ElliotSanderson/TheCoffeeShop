using UnityEngine;

public class Tillsystem : MonoBehaviour
{
    public bool tip = true;
    public int tipamount = 20;
    public float tillamount = 30.00f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float maincost = 6.50f;
        tillamount = tillamount - maincost;
        Debug.Log(tillamount + " left in till");
        if (tip == true)
        {
            
            
            float tippercent = tipamount / 100;
            float tiptoadd = tippercent * maincost;
            tillamount = tillamount + tiptoadd;
            Debug.Log(tiptoadd + "added to till!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
