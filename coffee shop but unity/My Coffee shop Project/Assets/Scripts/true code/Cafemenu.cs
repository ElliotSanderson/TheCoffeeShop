using UnityEngine;
[CreateAssetMenu(fileName = "NewMenu", menuName = "Game/Cafe Menu")]
public class Cafemenu : ScriptableObject
{
    public enum CoffeeType
    {
        espresso,
        latte,
        cappuccino,
        americano,
        mocha,
        none
    }
    public CoffeeType menu;
}
