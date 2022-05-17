using UnityEngine;

public class CloseChildren : MonoBehaviour
{
    public void SetInactiveAllChildren()
     {
         foreach (Transform child in this.transform)
         {
             child.gameObject.SetActive(false);
         }
     }
}
