using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playag : MonoBehaviour
{ 
    public void NewGame()
    {
        SceneManager.LoadScene("game");
    }
}
