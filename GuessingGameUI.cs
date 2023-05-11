using UnityEngine;
using UnityEngine.UI;

public class GuessingGameUI : MonoBehaviour
{
    public GuessingGameController gameController;
    public Text feedbackText;
    public InputField inputField;
    public Button submitButton;

void Start()
{
    gameController = FindObjectOfType<GuessingGameController>();

    if (gameController != null)
    {
        inputField.onEndEdit.AddListener(delegate { gameController.OnSubmitGuess(); });
    }
}


    void Update()
    {
        if (inputField.text == "")
        {
            submitButton.interactable = false;
        }
        else
        {
            submitButton.interactable = true;
        }
    }
}
