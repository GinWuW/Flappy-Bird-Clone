using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartClicked()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitClicked()
    {
        Application.Quit();
    }
}
