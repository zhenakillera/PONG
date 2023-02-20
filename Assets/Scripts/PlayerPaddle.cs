using UnityEngine;

public class PlayerPaddle : Paddle
{

    private void Update()
    {
        /*if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _movementDirection = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _movementDirection = Vector2.down;
        }
        else
        {
            _movementDirection = Vector2.zero;
        }*/
    }

    private void FixedUpdate()
    {
        float movementDirection = Input.GetAxis("Vertical");
        _rigidBody.AddForce(Vector2.up * paddleSpeed * movementDirection);
    }

}
