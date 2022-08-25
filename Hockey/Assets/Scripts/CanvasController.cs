using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private Text hitsPlayer;
    [SerializeField] private Text pucksPlayer;
    [SerializeField] private Text score;

    [SerializeField] private GameData gameData;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private GameObject gameWinPanel;
    void Start()
    {
        gameOverPanel.SetActive(false);
        gameWinPanel.SetActive(false);
        hitsPlayer.text = gameData.ViewHits().ToString();
        pucksPlayer.text = gameData.ViewPucks().ToString();
    }

    void Update()
    {
        hitsPlayer.text = gameData.ViewHits().ToString();
        pucksPlayer.text = gameData.ViewPucks().ToString();
    }
    /// <summary>
    /// Перезапуск сцены
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Засчитать выигрыш
    /// </summary>
    public void LoseGame()
    {
        gameOverPanel.SetActive(true);
        gamePanel.SetActive(false);
    }
    /// <summary>
    /// Засчитать проигрыш
    /// </summary>
    public void WinGame()
    {
        gameWinPanel.SetActive(true);
        score.text = $"Вы набрали {(gameData.ViewHits() * 50).ToString()} очков";
        gamePanel.SetActive(false);
    }
}
