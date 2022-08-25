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
    /// ���������� �����
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// ��������� �������
    /// </summary>
    public void LoseGame()
    {
        gameOverPanel.SetActive(true);
        gamePanel.SetActive(false);
    }
    /// <summary>
    /// ��������� ��������
    /// </summary>
    public void WinGame()
    {
        gameWinPanel.SetActive(true);
        score.text = $"�� ������� {(gameData.ViewHits() * 50).ToString()} �����";
        gamePanel.SetActive(false);
    }
}
