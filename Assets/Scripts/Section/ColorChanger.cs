using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer colorChangeMeshRenderer;
    [SerializeField] private Material color;
    [SerializeField] private GameObject LastObstacles;
    [SerializeField] private GameObject NextObstacles;

    private void Start()
    {
        colorChangeMeshRenderer.material = color;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.transform.GetComponent<PlayerColor>().SetColor(color);

            LastObstacles.SetActive(false);
            NextObstacles.SetActive(true);
        }
    }
}
