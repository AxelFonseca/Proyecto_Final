using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionEscena : MonoBehaviour
{
    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
