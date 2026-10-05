using UnityEngine;
using System.Collections.Generic;

public class array : MonoBehaviour
{
    public GameObject[] gameObject;
    public List<GameObject> gameObjectsList = new List<GameObject>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject obj in gameObjectsList)
        {
            Debug.Log("GameObject in List; " + obj.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
