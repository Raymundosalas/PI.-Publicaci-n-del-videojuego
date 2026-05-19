using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public int coins = 0;
    public Text coinsText;

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
        UpdateUI();
    }

    public void AddCoin(int amount)
    {
        coins += amount;

        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.Save();

        UpdateUI();
    }

    void UpdateUI()
    {
        coinsText.text = "Coins: " + coins;
    }
}
