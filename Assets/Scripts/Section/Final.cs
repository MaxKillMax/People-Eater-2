using UnityEngine;

public class Final : MonoBehaviour
{
    [SerializeField] private UIController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.transform.GetComponent<Player>().CrystallCount = 5;
            controller.OpenWinMenu();
        }
    }
}
