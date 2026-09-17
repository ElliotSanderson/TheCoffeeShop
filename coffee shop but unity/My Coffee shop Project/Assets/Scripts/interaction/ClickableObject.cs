using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour, IClickable
{
    [SerializeField] public UnityEvent onClick;

    public void OnClick()
    {
      onClick.Invoke();
      Debug.Log("Found Clickable Object"); 
    }
}