using UnityEngine;
using UnityEngine.UI;

public class SPLeaderBoard : MonoBehaviour
{
    public Text leaderboardText;
    string Pnm = SPNameWrite.playerName;
    
    private SPGuessingGameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<SPGuessingGameController>();
        UpdateLeaderboard();
    }

    public void UpdateLeaderboard()
    {
        string leaderboardString = "LİDERLİK TABLOSU:\n\n";
        leaderboardString += "1.) " + Pnm + " " + gameController.player1Score + " puan.";
        leaderboardText.text = leaderboardString;
    }
}
