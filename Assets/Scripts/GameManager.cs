using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        ScoreTextView();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void ScoreTextView()
    {
        int lastDigit = BirdMovement.Score % 10;
        int lastTwo = BirdMovement.Score % 100;

        if(BirdMovement.Score == 1)
            scoreText.text = $"You scored: {BirdMovement.Score} point";
        else
            scoreText.text = $"You scored: {BirdMovement.Score} points";
    }
}
