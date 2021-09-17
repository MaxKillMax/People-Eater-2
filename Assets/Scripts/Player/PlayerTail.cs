using System.Collections.Generic;
using UnityEngine;

public class PlayerTail : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameObject tailPrefab;
    [SerializeField] private PlayerTail playerTail;

    private List<MeshRenderer> tailsList = new List<MeshRenderer>();
    private float needPositionZ;
    private int tailPoints = 0;

    public void AddTailPoints()
    {
        tailPoints++;

        if (tailPoints >= 4 + tailsList.Count)
        {
            tailPoints = 0;

            tailsList.Add(Instantiate(tailPrefab).GetComponent<MeshRenderer>());
            tailsList[tailsList.Count - 1].transform.position = transform.position;
            tailsList[tailsList.Count - 1].transform.parent = transform.parent;
            tailsList[tailsList.Count - 1].material = player.Color;
            player.TailLength++;

            if (tailsList.Count != 1)
            {
                tailsList[tailsList.Count - 1].GetComponent<Tail>().GetInformation(tailsList[tailsList.Count - 2].transform, 0.7f);
            }
            else
            {
                tailsList[tailsList.Count - 1].GetComponent<Tail>().GetInformation(transform, 1.2f);
            }
        }
    }

    public void GetInformation(float positionZ)
    {
        needPositionZ = positionZ;
        playerTail.enabled = true;
    }

    private void Update()
    {
        for (int i = 0; i < tailsList.Count; i++)
        {
            if (tailsList[i].transform.position.z >= needPositionZ)
            {
                tailsList[i].material = player.Color;

                if (i == tailsList.Count - 1)
                {
                    playerTail.enabled = false;
                }
            }
        }
    }
}
