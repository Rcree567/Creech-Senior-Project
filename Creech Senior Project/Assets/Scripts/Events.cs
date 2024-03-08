using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
   //Restart level
   
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) RestartLevel();
    }
}
