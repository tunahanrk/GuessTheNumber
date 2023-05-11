using UnityEngine;
using UnityEngine.UI;

public class SPScoreboardUI : MonoBehaviour
{
    public Text scoreText;

    private SPGuessingGameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<SPGuessingGameController>();
    }

    void Update()
    {
        scoreText.text = "Kalan Hak: " + (5-gameController.player1GuessCount);
    }
}
