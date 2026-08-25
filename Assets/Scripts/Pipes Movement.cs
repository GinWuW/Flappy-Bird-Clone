using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    [SerializeField] private int speed;

    private void Update() {
        if(BirdMovement.isDeath == false && BirdMovement.isGameStarted == true)
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
        }
    }
}
