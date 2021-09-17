using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private UIController controller;

    public void PlayerDestroy(GameObject obstacle)
    {
        if (player.FeverModeImmortality)
        {
            Destroy(obstacle);
        }
        else
        {
            controller.OpenRestartMenu();
        }
    }
}
