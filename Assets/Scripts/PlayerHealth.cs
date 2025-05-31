using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private float lerpTimer;
    //private float health;
    [Header("Health Bar")]
    [SerializeField]
    public float maxHealth = 100;
    [SerializeField]
    public float chipSpeed = 2f;
    [SerializeField]
    public Image frontHealthBar;
    [SerializeField]
    public Image backHealthBar;
    public Text gameStatus;
    public Text healthNumber;


    [Header("Damage Overlay")]
    public Image overlay; // The DamageOverlay Gameobject
    public float duration; // How long the image stays fully opaque
    public float fadeSpeed; // How quickly the image will fade
    public float durationTimer; // A timer to check against the duration
    // Start is called before the first frame update
    void Start()
    {
        Color color = gameStatus.color;
        color.a = 0; // Set alpha to 0 to make the text completely transparent
        gameStatus.color = color;
        //GameManager.health = 10;
        overlay.color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, 1);
        frontHealthBar.fillAmount = GameManager.health;
        backHealthBar.fillAmount = GameManager.health;
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.health = Mathf.Clamp(GameManager.health, 0, maxHealth);
        healthNumber.text = GameManager.health.ToString();
        UpdateHealthUI();
        if (overlay.color.a > 0) //Means that the image is not fully transperent
        {
            if (GameManager.health == 0)
            {
                Color color = gameStatus.color;
                color.a = 1; // Set alpha to 1 to make the text fully visible
                gameStatus.color = color;
                StartCoroutine(EndGameAfterTime(2));
            }
            if (GameManager.health < 30)
                return;
            durationTimer += Time.deltaTime;
            if (durationTimer > duration)
            {
                //Fade the image
                float tempAlpha = overlay.color.a;
                tempAlpha -= Time.deltaTime * fadeSpeed;
                overlay.color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, tempAlpha);
            }
          
        }
    }
    public void UpdateHealthUI()
    {
        //Debug.Log(health);
        float fillF = frontHealthBar.fillAmount; //fillFront
        float fillB = backHealthBar.fillAmount; //fillBack
        float hFraction = GameManager.health / maxHealth;
        if (fillB > hFraction)
        {
            frontHealthBar.fillAmount = hFraction;
            backHealthBar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            percentComplete = percentComplete * percentComplete;
            backHealthBar.fillAmount = Mathf.Lerp(fillB, hFraction, percentComplete);
        }
        if (fillF < hFraction)
        {
            backHealthBar.color = Color.green;
            backHealthBar.fillAmount = hFraction;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            percentComplete = percentComplete * percentComplete;
            frontHealthBar.fillAmount = Mathf.Lerp(fillF, backHealthBar.fillAmount, percentComplete);
        }
    }
    public void TakeDamage(float damage) 
    {
        GameManager.health -= damage;
        lerpTimer = 0f;
        durationTimer = 0;
        overlay.color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, 1);

    }
    public void RestoreHealth(float healAmount)
    {
        GameManager.health += healAmount;
        lerpTimer = 0f;
    }

    IEnumerator EndGameAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);

        // If you're running this in the Unity Editor, use the following line:
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
