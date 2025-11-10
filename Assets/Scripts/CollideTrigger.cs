// Tutorial for changing scenes
// Documentatin: https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideTrigger : MonoBehaviour
{
    [SerializeField] private GameObject restart; 
    private void OnTriggerEnter(Collider other)
    {
        // Check if collision is made with the Drop, which is tagged as "Finish"
        // You can change the tag and manually change this accordingly.
        if (other.tag == "busDoor")
        {
            SceneManager.LoadScene("insideBus");
        }
        if (other.tag == "houseDoor")
        {
            SceneManager.LoadScene("Outside");
        }

        if (other.tag == "bus2school")
        {
            SceneManager.LoadScene("classroomScene");
        }
        if (other.tag == "classroomDoor")
        {
            PlayerPrefs.SetInt("showRestart", 1);
            PlayerPrefs.Save();
            SceneManager.LoadScene("house");
        }
    }
}
