using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    public AudioClip sound;
    private AudioSource audioSource; // AudioSource component
    // Start is called before the first frame update
    void Start()
    {
        // Adding the AudioSource component to the GameObject this script is attached to
        audioSource = gameObject.AddComponent<AudioSource>(); // This line ensures AudioSource is not null
        audioSource.clip = sound; // Assign the sound clip
        audioSource.playOnAwake = false; // Ensure it doesn't play automatically on awake
        audioSource.Play(); // Play the sound

        quitMenu.enabled = false;
    }
    public void ExitPress() 
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void noPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }
    public void Startlevel()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
