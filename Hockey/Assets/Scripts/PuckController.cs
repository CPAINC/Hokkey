using UnityEngine;
using UnityEngine.UI;

public class PuckController : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    [SerializeField] private Vector3 positionTarget;
    [SerializeField] private GameObject puck;
    [SerializeField] private bool goal = false;
    private Vector3 StartTransform;
    private float speedPuck;
    [SerializeField] private AudioSource audioGoal;
    [SerializeField] private AudioSource audioMiss;
    [SerializeField] private Image slider;
    [SerializeField] private CanvasController canvas;
    [SerializeField] private Goalkeeper goalkeeper;
    [SerializeField] private ParticleSystem effectShow;

    void Start()
    {
        StartTransform = puck.transform.position;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                if (hit.transform.tag == "Target" && !goal)
                {
                    positionTarget = hit.transform.position;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if (goal && puck.transform.position.z > 0 && positionTarget.x != 0)
        {
            puck.transform.position = Vector3.MoveTowards(puck.transform.position, positionTarget, Time.deltaTime * speedPuck);
        }

        if (goal && 0 < puck.transform.position.z && puck.transform.position.z < 0.5)
        {
            audioGoal.Play();
            gameData.GiveHits();
            respawnPuck();

        }
        
    }
    /// <summary>
    /// Удар по шайбе
    /// </summary>
    public void HitThePack()
    {
        if (!goal && positionTarget.x != 0)
        {
            puck.transform.GetComponent<Rigidbody>().AddForce(positionTarget, ForceMode.Impulse);
            goal = true;
            speedPuck = slider.fillAmount * 25;
            effectShow.startSpeed = slider.fillAmount;
            effectShow.Play();

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Place")
        goal = false;
        if (collision.transform.tag == "Goalkeeper")
        {
            goal = false;
            gameData.GetHeal();
            respawnPuck();
            audioMiss.Play();
        }
    }
    /// <summary>
    /// Вернуть шайбу на исходную позицию
    /// </summary>
    public void respawnPuck()
    {
        effectShow.Stop();
        goalkeeper.UpdateSpeed();
        if (gameData.ViewHeal() <= 0) canvas.EndGame();
        puck.transform.position = StartTransform;
    }
}
