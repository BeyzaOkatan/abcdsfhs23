using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OpeningScene()
    {
        Debug.Log("Button Clicked!");
        SceneManager.LoadScene("Opening");
    }

  
}
