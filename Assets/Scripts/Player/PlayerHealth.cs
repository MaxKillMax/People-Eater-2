using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private UIController controller;

    public void PlayerDestroy(GameObject obstacle, bool isFood = false)
    {
        if (player.FeverModeImmortality)
        {
            Destroy(obstacle);
        }
        else
        {
            if (isFood)
            {
                if (obstacle.GetComponent<MeshRenderer>().material.name != player.Color.name + " (Instance)")
                {
                    controller.OpenRestartMenu();
                }
            }
            else
            {
                controller.OpenRestartMenu();
            }
        }
    }
}
