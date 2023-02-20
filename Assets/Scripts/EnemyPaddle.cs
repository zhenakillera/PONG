using UnityEngine;

public class EnemyPaddle : Paddle
{
    [SerializeField] private Rigidbody2D _ballRigidBody;

    private void FixedUpdate()
    {
        // Check if the ball flies towards the right side where enemy is located
        if (_ballRigidBody.velocity.x > 0f)
        {
            // Check if the ball is higher than enemy is
            if (_ballRigidBody.position.y > this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.up * paddleSpeed);
            }
            else if (_ballRigidBody.position.y < this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.down * paddleSpeed);
            }
        }

        else
        {
            if (this.transform.position.y > 0f)
            {
                _rigidBody.AddForce(Vector2.down * paddleSpeed);            
            }

            else if (this.transform.position.y < 0f)
            {
                _rigidBody.AddForce(Vector2.up * paddleSpeed);            
            }
        }
    }
}
