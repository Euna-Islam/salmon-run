using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Game State")]
    [Tooltip("Current Game State")]
    [SerializeField]
    private GameState GameState;

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        GameState.CurrentState = GameState.State.GAME_RUNNING;
    }

    public void GameOver() {
        GameState.CurrentState = GameState.State.GAMEOVER;
    }

    public void GameLost()
    {
        GameState.CurrentState = GameState.State.GAME_LOST;
    }
}
