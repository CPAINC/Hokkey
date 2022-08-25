using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioGoal;
    [SerializeField] private AudioSource audioMiss;
    [SerializeField] Button musicButton;
    private bool musicIsPlaying = true;
    void Start()
    {
        audioGoal.volume = 1;
        audioMiss.volume = 1;
    }
    /// <summary>
    ///  нопка включить/выключить музыку
    /// </summary>
    public void ButtonMusicOffOrOn()
    {
        if (musicIsPlaying)
        {
            audioGoal.volume = 0;
            audioMiss.volume = 0;
            musicButton.image.sprite = Resources.Load<Sprite>("Sprites/MusicOff");
            musicIsPlaying = false;
        }
        else
        {
            audioGoal.volume = 1;
            audioMiss.volume = 1;
            musicButton.image.sprite = Resources.Load<Sprite>("Sprites/MusicOn");
            musicIsPlaying = true;
        }
    }
}
