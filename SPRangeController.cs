using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SPRangeController : MonoBehaviour
{
    public InputField minInputField;
    public InputField maxInputField;
    public Button submitButton;
    public Text feedbackText;
    private int currentLevel;
    public static int minNumber;
    public static int maxNumber;

    void Start()
    {
        submitButton.onClick.AddListener(OnSubmitRange);
    }

    public void OnSubmitRange()
    {
        int newMinNumber = int.Parse(minInputField.text);
        int newMaxNumber = int.Parse(maxInputField.text);

        if (newMaxNumber <= newMinNumber)
        {
            feedbackText.text = "Maximum limit, minimum limtten yüksek olmalı.";
            return;
        }

        minNumber = newMinNumber;
        maxNumber = newMaxNumber;

        SceneManager.LoadScene(16);    
    }

    public int GetMinNumber()
    {
        return minNumber;
    }

    public int GetMaxNumber()
    {
        return maxNumber;
    }
}