using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMenuTwo : MonoBehaviour
{
    public Button Menu2;

    public void ReturnToMenu2()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
