using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    bool ended = false;
    public GameObject completeLevelUI ;
    public void completLevel ()
    {
        completeLevelUI.SetActive(true);
    }
   public void EndGame ()
    {
        if (ended == false)
        {
            ended = true;
            Debug.Log("Game Over");
            Invoke("restart", 2f);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
