using System.Collections;
using UnityEngine;

public class Coroutest : MonoBehaviour
{
    //private IEnumerator HeatCoffee()
    //{

    //}
    private void Start()
    {
        StartCoroutine(MakeCoffee());
    }

    private IEnumerator MakeCoffee()
    {
        yield return new WaitForSeconds(coffeetime);
        Debug.Log("coffee ready!");
    }

    public float coffeetime = 5f;

    // Update is called once per frame
    void Update()
    {
        
    }
}
