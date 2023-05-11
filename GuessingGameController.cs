using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GuessingGameController : MonoBehaviour
{
    public Text feedbackText;
    public InputField inputField;
    public Button submitButton;
    public int player1Score = 0;
    public int player2Score = 0;
    public int guessLimit = 5;
    private int currentLevel;
    public static string playerName;
    
    int specMin = RangeController.minNumber;
    int specMax = RangeController.maxNumber;
    public int easyMin = 0;
    public int easyMax = 25;
    public int mediumMin = 0;
    public int mediumMax = 50;
    public int hardMin = 0;
    public int hardMax = 75;
    public int expMin = 0;
    public int expMax = 100;

    string FirstplayerNm = NameWrite.FirstPlayerName;
    string SecondplayerNm = NameWrite.SecondPlayerName;
    private int correctNumber;
    private int currentPlayer = 1;
    public int player1GuessCount = 0;
    public int player2GuessCount = 0;

void Start()
{
 RestartGame();
}

public void OnSubmitGuess()
{
    int minNumber, maxNumber;

    int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        switch (sceneIndex)
    {
            case 9:
                currentLevel = 1;
                break;
            case 11:
                currentLevel = 2;
                break;
            case 13:
                currentLevel = 3;
                break;
            case 15:
                currentLevel = 4;
                break;
            case 17:
                currentLevel = 5;
                break;
    }

    if (currentLevel == 1) {
        minNumber = easyMin;
        maxNumber = easyMax;
    } else if (currentLevel == 2) {
        minNumber = mediumMin;
        maxNumber = mediumMax;
    } else if (currentLevel == 3) {
        minNumber = hardMin;
        maxNumber = hardMax;
    }else if (currentLevel == 4) {
        minNumber = expMin;
        maxNumber = expMax;
    }else if (currentLevel == 5) {
        minNumber = specMin;
        maxNumber = specMax;
    } else {
        minNumber = easyMin;
        maxNumber = easyMax;
    }

    int guess = int.Parse(inputField.text);
    inputField.text = "";

    if (guess < minNumber || guess > maxNumber)
    {
        feedbackText.text = "Lütfen " + minNumber + " ile " + maxNumber + "aralığında tahminde bulunun!";
        return;
    }

    if (guess == correctNumber)
    {
        if(currentPlayer==1){
            feedbackText.text = FirstplayerNm + " kazandı!";
        }else if(currentPlayer==2){
            feedbackText.text = SecondplayerNm + " kazandı!";
        }
        inputField.interactable = false;
        submitButton.interactable = false;
        UpdateScores();
    }
    else if (guess < correctNumber)
    {
        if(currentPlayer==1){
            feedbackText.text = FirstplayerNm + ", tahmininiz doğru sayıdan düşük!";
        }else if(currentPlayer==2){
            feedbackText.text = SecondplayerNm + ", tahmininiz doğru sayıdan düşük!";
        }
        player1GuessCount += (currentPlayer == 1) ? 1 : 0;
        player2GuessCount += (currentPlayer == 2) ? 1 : 0;

        if (currentPlayer == 1 && player1GuessCount == guessLimit)
        {
        feedbackText.text = FirstplayerNm + " tahmin hakkını doldurdu. " + SecondplayerNm + " için son şans!";
        currentPlayer = 2;
            return;
        }
        else if (currentPlayer == 2 && player2GuessCount == guessLimit)
        {
        feedbackText.text = "Tahmin hakları doldu. Oyun berabere! Doğru sayı " + correctNumber + " olmalıydı.";
        inputField.interactable = false;
        submitButton.interactable = false;
            return;
        }

        SwitchPlayer();

    }
    else if (guess > correctNumber)
    {
        if(currentPlayer==1){
            feedbackText.text = FirstplayerNm + ", tahmininiz doğru sayıdan yüksek!";
        }else if(currentPlayer==2){
            feedbackText.text = SecondplayerNm + ", tahmininiz doğru sayıdan yüksek!";
        }
        player1GuessCount += (currentPlayer == 1) ? 1 : 0;
        player2GuessCount += (currentPlayer == 2) ? 1 : 0;

        if (currentPlayer == 1 && player1GuessCount == guessLimit)
        {
        feedbackText.text = FirstplayerNm + " tahmin hakkını doldurdu. " + SecondplayerNm + " için son şans!";
        currentPlayer = 2;
            return;
        }
        else if (currentPlayer == 2 && player2GuessCount == guessLimit)
        {
        feedbackText.text = "İki oyuncu da hakkını doldurdu. Oyun berabere!";
        inputField.interactable = false;
        submitButton.interactable = false;
            return;
        }

        SwitchPlayer();
    }
    else
    {
        if(currentPlayer==1){
            feedbackText.text = FirstplayerNm + ", lütfen mantıklı bir şey yazın :)";
        }else if(currentPlayer==2){
            feedbackText.text = SecondplayerNm + ", lütfen mantıklı bir şey yazın :)";
        }
    }
}

private void CheckGuessLimit()
{
    if (currentPlayer == 1 && player1GuessCount == guessLimit)
    {
        feedbackText.text = FirstplayerNm + " tahmin hakkını doldurdu. " + SecondplayerNm + " için son şans!";
        currentPlayer = 2;
    }

    if (player1GuessCount == guessLimit && player2GuessCount == guessLimit)
    {
        feedbackText.text = "İki oyuncu da hakkını doldurdu. Oyun berabere! Doğru sayı: " + correctNumber + " olmalıydı.";
        inputField.interactable = false;
        submitButton.interactable = false;
        UpdateScores();
    }
}

    public void UpdateScores()
{
    if (currentPlayer == 1)
    {
        player1Score++;
    }
    else
    {
        player2Score++;
    }
}

public void SwitchPlayer()
{
    if (currentPlayer == 1)
    {
        feedbackText.text += "Sıradaki oyuncu: " + SecondplayerNm; 
        currentPlayer = 2;
    }
    else
    {
        feedbackText.text += "Sıradaki oyuncu: " + FirstplayerNm;
        currentPlayer = 1;
    }
}

public void RestartGame()
{
    int minNumber, maxNumber;

    int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        switch (sceneIndex)
    {
            case 9:
                currentLevel = 1;
                break;
            case 11:
                currentLevel = 2;
                break;
            case 13:
                currentLevel = 3;
                break;
            case 15:
                currentLevel = 4;
                break;
            case 17:
                currentLevel = 5;
                break;
    }

    if (currentLevel == 1) {
        minNumber = easyMin;
        maxNumber = easyMax;
    } else if (currentLevel == 2) {
        minNumber = mediumMin;
        maxNumber = mediumMax;
    } else if (currentLevel == 3) {
        minNumber = hardMin;
        maxNumber = hardMax;
    }else if (currentLevel == 4) {
        minNumber = expMin;
        maxNumber = expMax;
    }else if (currentLevel == 5) {
        minNumber = specMin;
        maxNumber = specMax;
    } else {
        minNumber = easyMin;
        maxNumber = easyMax;
    }    

    currentPlayer = 1;
    correctNumber = Random.Range(minNumber, maxNumber + 1);
    inputField.text = "";
    inputField.interactable = true;
    feedbackText.text = minNumber + " ile " + maxNumber + " arasında bir sayı tuttum. Tahmin et!";
    submitButton.interactable = true;
    player1GuessCount = 0;
    player2GuessCount = 0;
}

}
