using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        transform.position = new Vector3(target.position.x * 0.4f + 1, 15, target.position.z - 11);
    }
}
