using UnityEngine;

public class endTriger : MonoBehaviour
{
    public gameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.completLevel();
    }

}
