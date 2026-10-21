using UnityEngine;

[CreateAssetMenu(fileName = "NewCafeData", menuName = "Game/Cafe Data")]
public class CafeData : ScriptableObject
{
    public string coffeeName;
    public Sprite Coffeecup;
    public int value;
    public Cafemenu menu;
}