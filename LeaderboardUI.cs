using UnityEngine;
using UnityEngine.UI;

public class LeaderboardUI : MonoBehaviour
{
    public Text leaderboardText;
    string FirstPnm = NameWrite.FirstPlayerName;
    string SecondPnm = NameWrite.SecondPlayerName;
    string Pnm = SPNameWrite.playerName;

    private GuessingGameController gameController;

void Start()
{
    gameController = FindObjectOfType<GuessingGameController>();
    if (gameController == null)
    {
        Debug.LogError("Could not find GuessingGameController object in the scene.");
    }
    UpdateLeaderboard();
}

public void UpdateLeaderboard()
{
    string leaderboardString = "Liderlik Tablosu\n\n";
    if (gameController != null)
    {
        if (gameController.player1Score > gameController.player2Score)
        {
            leaderboardString += "1.) " + FirstPnm + ": " + gameController.player1Score + " puan." + "\n\n";
            leaderboardString += "2.) " + SecondPnm + ": " + gameController.player2Score + " puan.";
        }
        else if (gameController.player2Score > gameController.player1Score)
        {
            leaderboardString += "1.) " + SecondPnm + ": " + gameController.player2Score + " puan." + "\n\n";
            leaderboardString += "2.) " + FirstPnm + ": " + gameController.player1Score + " puan.";
        }
        else
        {
            leaderboardString += gameController.player1Score + " puan ile berabere!";
        }
    }
    else
    {
        leaderboardString += "Oyun kontrolcüsü bulunamadı.";
    }
    leaderboardText.text = leaderboardString;
}
}
