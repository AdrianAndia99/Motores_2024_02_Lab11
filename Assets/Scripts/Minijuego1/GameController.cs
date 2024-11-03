using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ColorRandomChange colorGuess;
    [SerializeField] private Vector3 AngleRotations;

    public event Action OnVictory;
    public event Action OnDefeat;

    private void Start()
    {
        colorGuess.SetRandomColor();
    }

    private void Update()
    {
        QuaternionRotation();
    }
    public void GuessColor(int colorIndex)
    {
        if (colorGuess.CheckColor(colorIndex))
        {
            OnVictory?.Invoke();
        }
        else
        {
            OnDefeat?.Invoke();
        }
    }
    private void QuaternionRotation()
    {
        transform.Rotate(AngleRotations * Time.deltaTime);
    }
}