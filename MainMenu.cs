using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

public void ButtonClick(){
    SceneManager.LoadScene(1);
}

public void ExitGame(){
    Application.Quit();
}

    public void TurnBack(){
        NameWrite.FirstPlayerName = "";
        NameWrite.SecondPlayerName = "";
        SPNameWrite.playerName = "";
        SceneManager.LoadScene(0);
    }
}
