using UnityEngine;

public class TextDisappearing : MonoBehaviour
{
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (BirdMovement.isGameStarted)
        {
            TextAlpha();
        }
    }
    private void TextAlpha()
    {
        animator.SetBool("isStart", true);
    }
}
