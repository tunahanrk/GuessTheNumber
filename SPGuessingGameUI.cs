using UnityEngine;
using UnityEngine.UI;

public class SPGuessingGameUI : MonoBehaviour
{
    public SPGuessingGameController gameController;
    public Text feedbackText;
    public InputField inputField;
    public Button submitButton;

void Start()
{
    gameController = FindObjectOfType<SPGuessingGameController>();

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
