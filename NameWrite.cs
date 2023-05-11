using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameWrite : MonoBehaviour
{
    public static string FirstPlayerName;
    public static string SecondPlayerName;


    public InputField inputField2;
    public InputField inputField;
    public Button submitButton;
    public InputField nameInputField;
    public InputField secondInputField;

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

        if (inputField2.text == "")
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
        FirstPlayerName = nameInputField.text;
        SecondPlayerName = secondInputField.text;
        SceneManager.LoadScene(5);
    }
}
