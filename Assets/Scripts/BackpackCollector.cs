using UnityEngine;

public class BackpackCollector : MonoBehaviour
{
    [SerializeField]
    private GameObject houseDoorCollider; 
    [SerializeField]
    private AudioSource equipAudioSource;
    [SerializeField]
    private AudioClip equipClip;

 

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("backpack"))
        {
            Debug.Log("Backpack");


            if (equipAudioSource != null)
                equipAudioSource.PlayOneShot(equipClip);
            else
                AudioSource.PlayClipAtPoint(equipClip, transform.position);

            other.gameObject.SetActive(false);

            // Enable the house door collider
            if (houseDoorCollider != null)
            {
                houseDoorCollider.SetActive(true);
               
            }
           
        }
    }
}