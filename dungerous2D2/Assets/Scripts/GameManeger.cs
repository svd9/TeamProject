using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private GameObject quests;
    [SerializeField] private GameObject loseWindow;
    [SerializeField] private GameObject winWindow;

    public static GameManager Instance;
    public int coinsToWin = 30;
    public int coins;

    private bool questIsOpen;

    private void Awake()
    {
        Time.timeScale = 1;
        Instance = this;
        quests.SetActive(questIsOpen);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            questIsOpen = !questIsOpen;
            quests.SetActive(questIsOpen);

            Cursor.lockState = questIsOpen ? CursorLockMode.None : CursorLockMode.Locked;
        }
    }

    public void ChangeCoinsCount(int value)
    {
        coins += value;
        coinsText.text = coins.ToString();

        if (coins >= coinsToWin)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        ShowCursor();
        winWindow.SetActive(true);
    }

    public void LoseGame()
    {
        ShowCursor();
        loseWindow.SetActive(true);
    }

    private static void ShowCursor()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }
}