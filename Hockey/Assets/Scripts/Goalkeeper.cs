using UnityEngine;
public class Goalkeeper : MonoBehaviour
{
    [SerializeField] private float speedGoalkeeper = 2f, range;
    Vector3 startPosition;
    Vector3 direction = Vector3.right;

    void Start()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        transform.Translate(direction.x * Time.deltaTime * speedGoalkeeper,0,0);

        if (transform.position.x <= startPosition.x - range) direction.x = 1;
        else if (transform.position.x >= startPosition.x + range) direction.x = -1;
    }
    /// <summary>
    /// Обновить скорость вратаря
    /// </summary>
    public void UpdateSpeed()
    {
        speedGoalkeeper += 0.5f;
    }

}
