using System.Collections;
using UnityEngine;

public class Spawned : MonoBehaviour
{
    [SerializeField] private GameObject pipe;

    private void Start() {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true){
            yield return new WaitUntil(() => BirdMovement.isGameStarted == true && BirdMovement.isDeath == false);

            if(BirdMovement.Score <= 10f)
            {
                yield return new WaitForSeconds(2f);
            }
            else
            {
                yield return new WaitForSeconds(Random.Range(1f, 2f));
            }

            GameObject pipeObj = Instantiate(pipe);
            pipeObj.transform.position = transform.position + new Vector3(0, Random.Range(-2f, 2f), 0);
        }
    }
}
