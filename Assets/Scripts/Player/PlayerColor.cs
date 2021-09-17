using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private PlayerTail playerTail;

    public void SetColor(Material material)
    {
        meshRenderer.material = material;
        player.Color = material;
    }
}
