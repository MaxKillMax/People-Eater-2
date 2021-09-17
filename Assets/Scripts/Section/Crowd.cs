using UnityEngine;

public class Crowd : MonoBehaviour
{
    [SerializeField] private MeshRenderer[] peopleMeshRenderer;
    [SerializeField] private Material[] colors;
    [SerializeField] private colorVariablesEnum currentColor;

    private enum colorVariablesEnum
    {
        BLUE = 0,
        GREEN = 1,
        ORANGE = 2,
        PURPLE = 3,
        RED = 4,
        YELLOW = 5
    }

    private void Start()
    {
        int colorIndex = 0;
        if (currentColor == colorVariablesEnum.BLUE)
        {
            colorIndex = 0;
        }
        else if (currentColor == colorVariablesEnum.GREEN)
        {
            colorIndex = 1;
        }
        else if (currentColor == colorVariablesEnum.ORANGE)
        {
            colorIndex = 2;
        }
        else if (currentColor == colorVariablesEnum.PURPLE)
        {
            colorIndex = 3;
        }
        else if (currentColor == colorVariablesEnum.RED)
        {
            colorIndex = 4;
        }
        else if (currentColor == colorVariablesEnum.YELLOW)
        {
            colorIndex = 5;
        }

        for (int i = 0; i < peopleMeshRenderer.Length; i++)
        {
            peopleMeshRenderer[i].material = colors[colorIndex];
        }
    }
}
