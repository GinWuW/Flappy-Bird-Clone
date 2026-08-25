using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private TextMeshProUGUI scoreText;
    private Rigidbody2D rb;

    private Animator animator;

    public static bool isDeath {get; set;}

    public static bool isGameStarted {get; private set;}

    public static int Score {get; private set;}

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Score = 0;
        isDeath = false;
        isGameStarted = false;

        rb.linearVelocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && isDeath == false)
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                rb.bodyType = RigidbodyType2D.Dynamic;
                rb.linearVelocity = new Vector2(0, jumpForce);
            }
            else
                rb.linearVelocity = new Vector2(0, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            isDeath = true;
            animator.SetBool("isDeath", true);
            Invoke(nameof(LoadDefeatScene), 2f);
        }
        else
        {
            isDeath = false;
        }
    }

    private void LoadDefeatScene()
    {
        SceneManager.LoadScene("DefeatScene");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.CompareTag("Point"))
        {
            Score++;
            scoreText.text = $"Score: {Score}";
        }
    }
}
