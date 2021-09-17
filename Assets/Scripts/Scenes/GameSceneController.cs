using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
