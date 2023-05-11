using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LvlSc(){
        SceneManager.LoadScene(5);
    }

    public void EasyLevel(){
        SceneManager.LoadScene(9);
    }

    public void MediumLevel(){
        SceneManager.LoadScene(11);
    }

    public void HardLevel(){
        SceneManager.LoadScene(13);
    }

    public void ExpertLevel(){
        SceneManager.LoadScene(15);
    }

    public void SpecificLevel(){
        SceneManager.LoadScene(7);
    }

    public void SP_EasyLevel(){
        SceneManager.LoadScene(8);
    }

    public void SP_MediumLevel(){
        SceneManager.LoadScene(10);
    }

    public void SP_HardLevel(){
        SceneManager.LoadScene(12);
    }

    public void SP_ExpertLevel(){
        SceneManager.LoadScene(14);
    }

    public void SP_SpecificLevel(){
        SceneManager.LoadScene(6);
    }

    public void OnePlayerLevels(){
        SceneManager.LoadScene(2);
    }

    public void SecondPlayerLevels(){
        SceneManager.LoadScene(3);
    }
}
