using UnityEngine;
using UnityEngine.UI;

public class LeaderboardButton : MonoBehaviour
{
    public GameObject leaderboardPanel;

    public void OnLeaderboardButtonClicked()
    {
        leaderboardPanel.SetActive(!leaderboardPanel.activeSelf);
    }
}
