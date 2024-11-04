using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    private void OnEnable()
    {
        GameController.OnVictory += LoadVictoryScene;
        GameController.OnDefeat += LoadDefeatScene;

        Ball.OnDefeat += LoadDefeatScene;
    }

    private void OnDisable()
    {
        GameController.OnVictory -= LoadVictoryScene;
        GameController.OnDefeat -= LoadDefeatScene;

        Ball.OnDefeat -= LoadDefeatScene;
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