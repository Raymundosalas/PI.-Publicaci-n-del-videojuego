using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 1;

    public void NextLevel()
    {
        currentLevel++;

        if (currentLevel == 2)
        {
            SceneManager.LoadScene("Level2");
        }
        else if (currentLevel == 3)
        {
            SceneManager.LoadScene("Level3");
        }
        else
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
