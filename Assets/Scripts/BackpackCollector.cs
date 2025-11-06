using UnityEngine;

public class BackpackCollector : MonoBehaviour
{
    [SerializeField]
    private GameObject houseDoorCollider; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("backpack"))
        {
            Debug.Log("ahhh");
            // Make the backpack disappear
            other.gameObject.SetActive(false);
            
            // Enable the house door collider
            if (houseDoorCollider != null)
            {
                houseDoorCollider.SetActive(true);
            }
           
        }
    }
}