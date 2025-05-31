using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SupplyCrate : MonoBehaviour
{
    private int supplyCrate;
    public AudioClip getCrate;
    public Text gameStatus;
    int goalCrates = 4;
    public Text crateText;
    // Start is called before the first frame update
    void Start()
    {
        supplyCrate = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GatherCrate()
    {
        AudioSource.PlayClipAtPoint(getCrate, gameObject.transform.position);
        supplyCrate++;
        crateText.text = "Supply Crate Gathered: " + supplyCrate.ToString() + "/4";
        if (supplyCrate >= goalCrates) 
        {
            gameStatus.text = "You Won!!!";
            Color color = gameStatus.color;
            color.a = 1; // Set alpha to 1 to make the text fully visible
            gameStatus.color = color;
            StartCoroutine(EndGameAfterTime(2));
        }
        //future- pause 2 seconds and back to the main screen

        IEnumerator EndGameAfterTime(float time)
        {
            yield return new WaitForSeconds(time);
            SceneManager.LoadScene(0);

            // If you're running this in the Unity Editor, use the following line:
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
