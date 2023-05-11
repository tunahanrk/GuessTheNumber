using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SPGuessingGameController : MonoBehaviour
{
    public Text feedbackText;
    public InputField inputField;
    public Button submitButton;
    public int player1Score = 0;
    public int guessLimit = 5;
    private int currentLevel;
    public static string playerName;
    
    int specMin = SPRangeController.minNumber;
    int specMax = SPRangeController.maxNumber;
    public int easyMin = 0;
    public int easyMax = 25;
    public int mediumMin = 0;
    public int mediumMax = 50;
    public int hardMin = 0;
    public int hardMax = 75;
    public int expMin = 0;
    public int expMax = 100;

    private int correctNumber;
    string playerNm = SPNameWrite.playerName;
    private int currentPlayer = 1;
    public int player1GuessCount = 0;

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
            case 8:
                currentLevel = 1;
                break;
            case 10:
                currentLevel = 2;
                break;
            case 12:
                currentLevel = 3;
                break;
            case 14:
                currentLevel = 4;
                break;
            case 16:
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
        feedbackText.text = "Bildiniz!";
        inputField.interactable = false;
        submitButton.interactable = false;
        UpdateScores();
    }
    else if (guess < correctNumber)
    {
        feedbackText.text = playerNm + ", tahmininiz doğru sayıdan düşük!.";
        player1GuessCount += (currentPlayer == 1) ? 1 : 0;

        if (currentPlayer == 1 && player1GuessCount == guessLimit)
        {
        feedbackText.text = "Tahmin hakkınız doldu, bilemediniz. Doğru sayı: " + correctNumber + " olmalıydı.";
        inputField.interactable = false;
        submitButton.interactable = false;
        }
    }
    else if (guess > correctNumber)
    {
        feedbackText.text = playerNm + ", tahmininiz doğru sayıdan yüksek!.";
        player1GuessCount += (currentPlayer == 1) ? 1 : 0;

        if (currentPlayer == 1 && player1GuessCount == guessLimit)
        {
        feedbackText.text = "Tahmin hakkınız doldu, bilemediniz. Doğru sayı: " + correctNumber + " olmalıydı.";
        inputField.interactable = false;
        submitButton.interactable = false;
        }
    }
    else
    {
        feedbackText.text = playerNm + ", lütfen mantıklı bir şey yazın :)";
    }
}

private void CheckGuessLimit()
{
    if (currentPlayer == 1 && player1GuessCount == guessLimit)
    {
        feedbackText.text = "Tahmin hakkınız doldu, bilemediniz. Doğru sayı: " + correctNumber + " olmalıydı.";
        inputField.interactable = false;
        submitButton.interactable = false;
    }
}

    public void UpdateScores()
{
    if (currentPlayer == 1)
    {
        player1Score++;
    }
}

public void RestartGame()
{
    int minNumber, maxNumber;

    int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        switch (sceneIndex)
    {
            case 8:
                currentLevel = 1;
                break;
            case 10:
                currentLevel = 2;
                break;
            case 12: 
                currentLevel = 3;
                break;
            case 14:
                currentLevel = 4;
                break;
            case 16:
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
}

}