using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    private InputManager inputManager;
    public AudioClip shootSound;
    public AudioClip backgroundSound;
    private Animator animator;
    private bool shot = false;
    public Image muzzleFlash;
    public Text gameStatus;
    int goal = 13;
    public Text killsText;

    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
        shootSound = Resources.Load<AudioClip>("Sounds/hq-explosion-6288");
        backgroundSound = Resources.Load<AudioClip>("Sounds/scary-audio-19409");
        AudioSource.PlayClipAtPoint(backgroundSound, transform.position);
        animator = GetComponent<Animator>();
        if(muzzleFlash)
            muzzleFlash.color = new Color(muzzleFlash.color.r, muzzleFlash.color.g, muzzleFlash.color.b, 0);
    }

    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;

        if (inputManager.onFoot.Shoot.triggered)
        {
            shot = true;
            AudioSource.PlayClipAtPoint(shootSound, transform.position);
            StartCoroutine(FadeIn(muzzleFlash, 0.1f)); // Adjust the duration as needed
            StartCoroutine(FadeOut(muzzleFlash, 0.1f)); // Adjust the duration as needed
        }

        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (shot)
            {
                if (hitInfo.collider.gameObject.tag == "Enemy")
                {
                    Debug.Log($"Raycast hit: {hitInfo.collider.name}");
                    ShootEnemy(hitInfo.collider.gameObject);
                    //animator.SetBool("isShooting", true);
                }
                shot = false;
            }
            else if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }

    public void ShootEnemy(GameObject enemy)
    {
        Debug.Log($"Shooting at {enemy.name}");
        if (enemy.GetComponent<Enemy>().isDying == false)
        {

            //kills++;
            // killsText.text = "Kills: " + kills.ToString() + "/12"; // Set the text property correctly
            GameManager.kills++;
            killsText.text = "Kills: " + GameManager.kills.ToString() + "/13"; // Set the text property correctly
            enemy.GetComponent<Enemy>().gotShot();
        }


        if (GameManager.kills >= goal)
        {
            gameStatus.text = "You Won!!!";
            Color color = gameStatus.color;
            color.a = 1; // Set alpha to 1 to make the text fully visible
            gameStatus.color = color;
            StartCoroutine(EndGameAfterTime(2));
        }
    }

    private IEnumerator EndGameAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);

        // If you're running this in the Unity Editor, use the following line:
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    private IEnumerator FadeIn(Image image, float duration)
    {
        Color color = image.color;
        float alpha = color.a;

        for (float t = 0.01f; t < duration; t += Time.deltaTime)
        {
            color.a = Mathf.Lerp(alpha, 1, t / duration);
            image.color = color;
            yield return null;
        }
        color.a = 1;
        image.color = color;
    }

    private IEnumerator FadeOut(Image image, float duration)
    {
        yield return new WaitForSeconds(0.1f); // Adjust delay before fading out

        Color color = image.color;
        float alpha = color.a;

        for (float t = 0.01f; t < duration; t += Time.deltaTime)
        {
            color.a = Mathf.Lerp(alpha, 0, t / duration);
            image.color = color;
            yield return null;
        }
        color.a = 0;
        image.color = color;
    }
}
