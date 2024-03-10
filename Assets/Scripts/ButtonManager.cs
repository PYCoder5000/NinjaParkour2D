using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Button startButton;
    private void Awake()
    {
        startButton.onClick.AddListener(delegate { StartGame(); });
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
