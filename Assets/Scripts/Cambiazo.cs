using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiazo : MonoBehaviour
{
    public void CambiazoEscena(string name)
    {
        SceneManager.LoadScene(name);
    }
}