using UnityEngine;
public enum Allergies
{
    gluten,
    milk,
}    
[CreateAssetMenu(fileName = "NewIngredients", menuName = "Game/Ingreident")]
public class Cafeingredient : ScriptableObject
{
    public float price;
    public float quantity;
    public bool Instock;
    public Allergies[] allergies;
}
