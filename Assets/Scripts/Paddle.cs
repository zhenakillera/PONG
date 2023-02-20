using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidBody;
    [SerializeField] protected float paddleSpeed = 10f;

    private void Awake()
    {
        
    }

    public void ResetPosition()
    {
        _rigidBody.position = new Vector2(_rigidBody.position.x, 0f);
        _rigidBody.velocity = Vector2.zero;
    }
}
