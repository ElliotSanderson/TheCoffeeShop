using UnityEngine;
using UnityEngine.AI;
using static NPCCHOICE;


public class NPCCHOICE : MonoBehaviour
{
    GameObject nameTag;
    private enum Coffeetype
    {
        Cappucino,
        Mocha,
        Espresso,
        Latte,
        Americano
    }
    private NPCCHOICE.Coffeetype coffeechoice;

    void Start()
    {
       coffeechoice = (Coffeetype)Random.Range(0, 5);
        nameTag = new GameObject("NameTag");
        nameTag.transform.SetParent(transform);
        var textMesh = nameTag.AddComponent<TextMesh>();

        // Set text properties and make sure it stays centered.
        textMesh.text = "Can I have a " + coffeechoice + "?";
        textMesh.fontSize = 32;
        textMesh.characterSize = 0.1f;
        textMesh.anchor = TextAnchor.LowerCenter;
        textMesh.alignment = TextAlignment.Center;
    }
}