using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSwitcher : MonoBehaviour
{
    public void playGame(){
         SceneManager.LoadScene("SampleScene");
    }
    public void Quit(){
        Application.Quit();
    }
}
