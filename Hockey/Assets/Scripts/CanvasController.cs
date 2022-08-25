using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private Text hitsPlayer;
    [SerializeField] private Text healPlayer;
    [SerializeField] private Text score;

    [SerializeField] private GameData gameData;

    [SerializeField] private GameObject gamePanel;
    [SerializeField] private GameObject gameWinPanel;
    void Start()
    {
        gameWinPanel.SetActive(false);
        hitsPlayer.text = (gameData.ViewHits() * 50 ).ToString();
        healPlayer.text = gameData.ViewHeal().ToString();
    }

    void Update()
    {
        hitsPlayer.text = (gameData.ViewHits() * 50).ToString();
        healPlayer.text = gameData.ViewHeal().ToString();
    }
    /// <summary>
    /// ���������� �����
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// ��������� ��������
    /// </summary>
    public void EndGame()
    {
        gameWinPanel.SetActive(true);
        score.text = $"�� ������� {(gameData.ViewHits() * 50).ToString()} �����";
        gamePanel.SetActive(false);
    }
}
