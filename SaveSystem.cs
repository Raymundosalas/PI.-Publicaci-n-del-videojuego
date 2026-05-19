using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public int coins;

    void Start()
    {
        LoadGame();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.Save();
    }

    public void LoadGame()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
    }
}
