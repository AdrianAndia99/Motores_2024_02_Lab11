using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameController colorGuessGame;

    private void OnEnable()
    {
        colorGuessGame.OnVictory += LoadVictoryScene;
        colorGuessGame.OnDefeat += LoadDefeatScene;
    }

    private void OnDisable()
    {
        colorGuessGame.OnVictory -= LoadVictoryScene;
        colorGuessGame.OnDefeat -= LoadDefeatScene;
    }

    private void LoadVictoryScene()
    {
        SceneManager.LoadScene("Victory");
    }

    private void LoadDefeatScene()
    {
        SceneManager.LoadScene("Defeat");
    }
}