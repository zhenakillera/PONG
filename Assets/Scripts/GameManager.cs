using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Paddle _playerPaddle;
    [SerializeField] private Paddle _enemyPaddle;
    private int _playerScore;
    private int _enemyScore;

    [SerializeField] private Text _playerScoreText;
    [SerializeField] private Text _enemyScoreText;

    public void AddPlayerScore()
    {
        _playerScore++;

        _playerScoreText.text = _playerScore.ToString();

        ResetRound();
    }

    public void AddEnemyScore()
    {
        _enemyScore++;

        _enemyScoreText.text = _enemyScore.ToString();

        ResetRound();

    }

    private void ResetRound()
    {
        _ball.ResetPosition();
        _ball.AddStartingForce();
        _playerPaddle.ResetPosition();
        _enemyPaddle.ResetPosition();
    }
}
