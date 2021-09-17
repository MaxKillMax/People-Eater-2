using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Material startMaterial;

    [SerializeField] private PlayerUI playerUI;
    [SerializeField] private PlayerTail playerTail;
    [SerializeField] private PlayerFever playerFever;
    [SerializeField] private PlayerMove playerMove;

    private int crystallCount;
    public int CrystallCount { get { return crystallCount; } set { crystallCount = value; SetCrystallCount(); } }

    private Material color;
    public Material Color { get { return color; } set { SetColor(value); color = value; } }

    private bool feverMode;
    public bool FeverMode { get { return feverMode; } set { feverMode = value; } }
    public bool FeverModeImmortality { get; private set; }
    public bool FeverModeBoost { get; private set; }


    private int tailLength;
    public int TailLength { get { return tailLength; } set { tailLength = value; playerUI.AddLength(); } }

    private void Start()
    {
        color = startMaterial;
    }

    private void SetCrystallCount()
    {
        if (feverMode)
        {
            crystallCount--;
        }
        else
        {
            playerUI.AddCrystall();

            if (crystallCount >= 3)
            {
                playerFever.ToggleFeverMode();
                playerUI.StartFever();
                FeverModeBoost = true;
                FeverModeImmortality = true;
            }
        }
    }

    private void SetColor(Material value)
    {
        if (color != value)
        {
            playerTail.GetInformation(transform.position.z);
        }
    }

    public void EndImmortality()
    {
        FeverModeImmortality = false;
    }

    public void EndBoost()
    {
        FeverModeBoost = false;
    }
}
