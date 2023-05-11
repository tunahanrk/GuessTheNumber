using UnityEngine;
using UnityEngine.UI;

public class ScoreboardUI : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;

    private GuessingGameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GuessingGameController>();
    }

    void Update()
    {
        if (gameController != null)
        {
            player1ScoreText.text = "Kalan Hak: " + (5-gameController.player1GuessCount);
            player2ScoreText.text = "Kalan Hak: " + (5-gameController.player2GuessCount);
        }
    }

}
