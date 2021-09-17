using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().PlayerDestroy(gameObject);
        }
    }
}
