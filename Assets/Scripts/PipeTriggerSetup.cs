using UnityEngine;

public class PipeTriggerSetup : MonoBehaviour
{
    void Start()
    {
        if (BirdMovement.isDeath == true)
        {
            SetTriggers(true);
        }
    }

    void Update()
    {
        if (BirdMovement.isDeath == true)
        {
            SetTriggers(true);
        }
    }

    void SetTriggers(bool isTrigger)
    {
        BoxCollider2D[] colliders = GetComponentsInChildren<BoxCollider2D>();
        foreach (BoxCollider2D col in colliders)
        {
            col.isTrigger = isTrigger;
        }
    }
}