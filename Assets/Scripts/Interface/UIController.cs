using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private GameObject startUI;
    [SerializeField] private GameObject restartUI;
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject ingameUI;

    [Header("Other")]
    [SerializeField] private Text score;
    [SerializeField] private Player player;

    private void Awake()
    {
        Time.timeScale = 0;

        startUI.SetActive(true);
        restartUI.SetActive(false);
        winUI.SetActive(false);
        ingameUI.SetActive(false);
    }

    public void StartGame()
    {
        startUI.SetActive(false);
        ingameUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void OpenRestartMenu()
    {
        ingameUI.SetActive(false);
        restartUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void OpenWinMenu()
    {
        ingameUI.SetActive(false);
        winUI.SetActive(true);

        score.text = "Snake length: " + (player.TailLength + 1).ToString("N0");
    }
}
