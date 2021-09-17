using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private PlayerTail playerTail;
    [SerializeField] private PlayerHealth playerHealth;

    private Vector3[] vectorArray = new Vector3[11];

    private void Start()
    {
        vectorArray[0] = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2.5f);
        vectorArray[1] = new Vector3(vectorArray[0].x - 0.45f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[2] = new Vector3(vectorArray[0].x - 0.90f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[3] = new Vector3(vectorArray[0].x - 1.35f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[4] = new Vector3(vectorArray[0].x - 1.80f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[5] = new Vector3(vectorArray[0].x - 1.80f, vectorArray[0].y, vectorArray[0].z - 0.5f);
        vectorArray[6] = new Vector3(vectorArray[0].x + 0.45f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[7] = new Vector3(vectorArray[0].x + 0.90f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[8] = new Vector3(vectorArray[0].x + 1.35f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[9] = new Vector3(vectorArray[0].x + 1.80f, vectorArray[0].y, vectorArray[0].z);
        vectorArray[10] = new Vector3(vectorArray[0].x + 1.80f, vectorArray[0].y, vectorArray[0].z - 0.5f);
    }

    private void Update()
    {
        RaycastHit raycastHit;
        for (int i = 0; i < vectorArray.Length; i++)
        {
            if (Physics.Raycast(transform.position, vectorArray[i], out raycastHit, 2))
            {
                if (raycastHit.collider.tag == "People")
                {
                    if (raycastHit.collider.gameObject.GetComponent<MeshRenderer>().material.name == player.Color.name + " (Instance)"
                        || player.FeverModeImmortality)
                    {
                        playerTail.AddTailPoints();
                    }
                    else
                    {
                        playerHealth.PlayerDestroy(raycastHit.collider.gameObject);
                    }

                    Destroy(raycastHit.collider.gameObject);
                }
                else if (raycastHit.collider.tag == "Crystall")
                {
                    player.CrystallCount++;

                    Destroy(raycastHit.collider.gameObject);
                    break;
                }
            }
        }
    }
}
