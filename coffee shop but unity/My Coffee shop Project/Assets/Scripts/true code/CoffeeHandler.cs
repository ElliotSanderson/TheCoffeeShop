//using UnityEngine;
//[CreateAssetMenu(fileName = "CoffeeData", menuName = "Coffee/Coffee Dsata")]
//public class CoffeeData : ScriptableObject
//{
//    public float espressoPrice = 2.00f;
//    public float lattePrice = 3.50f;
//    public float cappuccinoPrice = 3.00f;
//    public float americanoPrice = 2.50f;
//    public float mochaPrice = 4.00f;
    
//}

//public class CoffeeHandler : MonoBehaviour
//{

//    [SerializeField] private coffeeOrder coffeedata;
//    [SerializeField] private CoffeeType selectedCoffee;
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private void Start()
//    {
//        float price = GetCoffeePrice(selectedCoffee);
//        Debug.Log($"{selectedCoffee} costs £{price:F2}");
//    }
//    private float GetCoffeePrice(CoffeeType type)
//    {
//        switch(type)
//        {
//            case CoffeeType.espresso:
//                return CoffeeData.espressoPrice;
//            case CoffeeType.latte:
//                return CoffeeData.lattePrice;
//            case CoffeeType.cappuccino:
//                return CoffeeData.cappuccino;
//            case CoffeeType.americano:
//                return CoffeeData.americanoPrice;
//            case CoffeeType.mocha:
//                return CoffeeData.mochaPrice;


//        }
//    }
//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
