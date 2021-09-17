using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Rigidbody rigidBody;

    [SerializeField] private float Speed;

    private void Update()
    {
        if (!player.FeverModeBoost)
        {
            Vector3 playerDirection = transform.position;
            if (Input.touchCount > 0)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit;

                if (Physics.Raycast(ray, out raycastHit))
                {
                    playerDirection = raycastHit.point;
                }

                if (playerDirection.x > 6)
                {
                    playerDirection = new Vector3(6, playerDirection.y, playerDirection.z);
                }
                else if (playerDirection.x < -6)
                {
                    playerDirection = new Vector3(-6, playerDirection.y, playerDirection.z);
                }
            }

            rigidBody.velocity = new Vector3((playerDirection.x - transform.position.x) * Speed * Time.fixedDeltaTime / 5, 0, Speed * Time.fixedDeltaTime);
        }
        else
        {
            rigidBody.velocity = new Vector3(- transform.position.x, 0, Speed * 3 * Time.fixedDeltaTime);
        }

        rigidBody.rotation = Quaternion.Euler(90, rigidBody.velocity.x * 3, 0);
    }
}
