using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private PlayerUI playerUI;

    [Header("UI")]

    [SerializeField] private Text textCountCrystall;
    private int countCrystall;

    [SerializeField] private Text textLengthTail;
    private int lengthTail = 1;

    [SerializeField] private Image fillerFever;
    [SerializeField] private Text timerFever;

    private bool colorBlack;

    public void AddCrystall()
    {
        countCrystall++;
        textCountCrystall.text = countCrystall.ToString();
    }

    public void AddLength()
    {
        lengthTail++;
        textLengthTail.text = lengthTail.ToString();
    }

    public void StartFever()
    {
        fillerFever.gameObject.SetActive(true);
        timerFever.gameObject.SetActive(true);

        fillerFever.color = new Color(0.5f, 0.5f, 0.5f);
    }

    public void FeverTimerSet(float time)
    {
        if (time >= 1)
        {
            fillerFever.fillAmount = (time - 1) / 5;
            timerFever.text = (time - 0.75f).ToString("N1");
        }
        else if (time >= 0)
        {
            if (!colorBlack)
            {
                fillerFever.color = new Color(0f, 0f, 0f);
                colorBlack = true;
            }

            fillerFever.fillAmount = time / 1;
            timerFever.text = time.ToString("N1");
        }
        else
        {
            fillerFever.gameObject.SetActive(false);
            timerFever.gameObject.SetActive(false);
        }
    }
}
