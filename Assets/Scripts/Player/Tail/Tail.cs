using UnityEngine;

public class Tail : MonoBehaviour
{
    private Transform leading;
    private Vector3 lastPoint;
    private float distance;

    public void GetInformation(Transform leading, float distance)
    {
        this.leading = leading;
        this.distance = distance;
    }

    private void Update()
    {
        Vector3 zero = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, transform.position.y, leading.position.z - distance), ref zero, 0.006f);
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(lastPoint.x, lastPoint.y, transform.position.z), ref zero, 0.03f);
        lastPoint = leading.position;
    }
}
