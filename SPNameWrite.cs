using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SPNameWrite : MonoBehaviour
{
    public static string playerName;

    public Button submitButton;
    public InputField inputField;
    public InputField nameInputField;

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

    public void SetPlayerName()
    {
        playerName = nameInputField.text;
        SceneManager.LoadScene(4);
    }
}
