
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    [SerializeField] protected float speed = 5f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidBody.position = Vector2.zero;
        _rigidBody.velocity = Vector2.zero;
    }

    public void AddStartingForce()
    {
        // Randomly pick a direction of ball flying in the start
        float startingX = Random.value < 0.5f ? -1f : 1f;
        // Randomly pick an angle of ball flying in the start
        float startingY = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                                Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(startingX, startingY);
        _rigidBody.AddForce(direction * this.speed);

        
    }

    public void AddForce(Vector2 force)
    {
        _rigidBody.AddForce(force);
    }
}
