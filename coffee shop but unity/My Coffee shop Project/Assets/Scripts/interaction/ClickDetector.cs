using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    [SerializeField] private int CountClicks;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
              IClickable clickable = hit.collider.GetComponent<IClickable>();
                
                clickable?.OnClick();
                //calls the interface "IClickable"
            }
          
        }
    }
}
