using UnityEngine;

public class Saw : Obstacle
{
    [SerializeField] private Vector3 leftPoint;
    [SerializeField] private Vector3 rightPoint;

    private bool toLeft;
    private float CurrentRotation = 0;

    private void Start()
    {
        leftPoint += transform.parent.position;
        rightPoint += transform.parent.position;
    }

    private void Update()
    {
        Vector3 zero = Vector3.zero;
        if (toLeft)
        {
            transform.position = Vector3.SmoothDamp(transform.position, leftPoint, ref zero, 0.15f, 5);

            if ((transform.position - leftPoint).magnitude < 0.2f) toLeft = false;
        }
        else
        {
            transform.position = Vector3.SmoothDamp(transform.position, rightPoint, ref zero, 0.15f, 5);

            if ((transform.position - rightPoint).magnitude < 0.2f) toLeft = true;
        }

        CurrentRotation += 360 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(CurrentRotation, 90, 90);

        if (CurrentRotation >= float.MaxValue - 1000)
        {
            CurrentRotation = 0;
        }
    }
}
