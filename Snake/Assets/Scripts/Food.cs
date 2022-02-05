using UnityEngine;
using Random = UnityEngine.Random;

public class Food : MonoBehaviour
{
    public BoxCollider2D greedArea;

    private void RandomizePosition()
    {
        Bounds bounds = this.greedArea.bounds;

        this.transform.position = new Vector3(
            Mathf.Round(Random.Range(bounds.min.x, bounds.max.x)),
            Mathf.Round(Random.Range(bounds.min.y, bounds.max.y)),
            0.0f
        );
       
    }

    private void Start()
    {
        RandomizePosition();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Tail")
        {
            RandomizePosition();
        }
    }
}
