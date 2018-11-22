using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterManager : MonoBehaviour
{
    public void Reset()
    {
        //reload scene
        Scene game = SceneManager.GetActiveScene();
        SceneManager.LoadScene(game.buildIndex);
    }
}