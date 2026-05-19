using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public float easySpeed = 4f;
    public float mediumSpeed = 6f;
    public float hardSpeed = 8f;

    public PlayerMovement player;

    void Start()
    {
        int difficulty = PlayerPrefs.GetInt("Difficulty", 1);

        switch (difficulty)
        {
            case 1:
                player.moveSpeed = easySpeed;
                break;

            case 2:
                player.moveSpeed = mediumSpeed;
                break;

            case 3:
                player.moveSpeed = hardSpeed;
                break;
        }
    }
}
