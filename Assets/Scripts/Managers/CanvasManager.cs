using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;
    public Button returnToMenuButton;
    public Button returnToGameButton;

    public GameObject pauseMenu;

    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        if (startButton)
        {
            startButton.onClick.AddListener(() => GameManager.instance.StartGame());
        }

        if (quitButton)
        {
            quitButton.onClick.AddListener(() => GameManager.instance.QuitGame());
        }
        
        if (returnToMenuButton)
        {
            returnToMenuButton.onClick.AddListener(() => GameManager.instance.ReturnToMenu());
        }

        if (returnToGameButton)
        {
            returnToGameButton.onClick.AddListener(() => ReturnToGame());
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseMenu)
                pauseMenu.SetActive(!pauseMenu.activeSelf);
        }

        if (livesText)
        {
            livesText.text = GameManager.instance.lives.ToString();
        }
    }

    public void ReturnToGame()
    {
        pauseMenu.SetActive(false);
    }
}
