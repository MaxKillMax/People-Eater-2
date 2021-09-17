using UnityEngine;

public class Mine : Obstacle
{
    private float minMineScale = 1.60f;
    private float maxMineScale = 2.00f;
    private float speed = 0.25001f;

    private void Start()
    {
        speed += Random.Range(-0.05001f, 0.05001f);
    }

    private void Update()
    {
        transform.localScale = new Vector3(
            transform.localScale.x + speed * Time.deltaTime,
            transform.localScale.y + speed * Time.deltaTime,
            transform.localScale.z + speed * Time.deltaTime);

        if (transform.localScale.x > maxMineScale)
        {
            speed *= -1;
            transform.localScale = new Vector3(maxMineScale, maxMineScale, maxMineScale);
        }
        else if (transform.localScale.x < minMineScale)
        {
            speed *= -1;
            transform.localScale = new Vector3(minMineScale, minMineScale, minMineScale);
        }
    }
}
