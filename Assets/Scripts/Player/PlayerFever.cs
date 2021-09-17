using UnityEngine;

public class PlayerFever : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private PlayerFever playerFever;
    [SerializeField] private PlayerUI playerUI;

    private float feverTimer;

    public void ToggleFeverMode()
    {
        player.CrystallCount = 0;
        player.FeverMode = !player.FeverMode;

        playerFever.enabled = !playerFever.enabled;
        feverTimer = 6f;
    }

    private void Update()
    {
        feverTimer -= Time.deltaTime;
        playerUI.FeverTimerSet(feverTimer);
        if (feverTimer <= 0)
        {
            player.EndImmortality();
            ToggleFeverMode();
        }
        else if (feverTimer <= 1f)
        {
            player.EndBoost();
        }
    }
}
