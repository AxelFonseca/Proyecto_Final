using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionUsuarios : MonoBehaviour
{
    [Header("Campos para registro")]
    public TMP_InputField[] campos_registro;

    [Header("Campos Inicio")]
    public TMP_InputField[] campos_inicio;

    [Header("Sistema Alertas")]
    public string[] texto_alertas;

    public GameObject panel_Alerta;
    public TMP_Text alerta_Actual;


    public void RegistrarUsuario()
    {
       for (int i = 0; i < campos_registro.Length; i++)
       {
            //Primer alerta campos vacios.
            if (string.IsNullOrEmpty(campos_registro[i].text))
            {
                panel_Alerta.SetActive(true);
                alerta_Actual.text = texto_alertas[0];
            }
            else
            {
                if (Manager.instance.usuarios.Contains(campos_registro[0].text))
                {
                    // Segunda Alerta
                    panel_Alerta.SetActive(true);
                    alerta_Actual.text = texto_alertas[1];
                }
                else
                {
                    Manager.instance.usuarios.Add(campos_registro[0].text);
                    Manager.instance.nombre_usuarioActual = campos_registro[0].text;
                    Manager.instance.correo_usuarioActual = campos_registro[1].text;
                    Manager.instance.contraseņa_usuarioActual = campos_registro[2].text;

                    GestionEscena cambioEscena = FindObjectOfType<GestionEscena>();
                    cambioEscena.CambiarEscena("Principal");
                }
            }
       }
    }


    public void IniciarSesion()
    {
        for (int i = 0; i < campos_inicio.Length; i++)
        {
            if (string.IsNullOrEmpty(campos_inicio[i].text))
            {
            panel_Alerta.SetActive(true);
                alerta_Actual.text = texto_alertas[0];
            }
            else
            {
                if (Manager.instance.usuarios.Contains(campos_inicio[0].text))
                {
                    Manager.instance.usuarios.Add(campos_inicio[0].text);
                    Manager.instance.nombre_usuarioActual = campos_inicio[0].text;
                    Manager.instance.contraseņa_usuarioActual = campos_registro[1].text;

                    GestionEscena cambioEscena = FindObjectOfType<GestionEscena>();
                    cambioEscena.CambiarEscena("Principal");
                }
                else
                {
                    //Tercer Alerta
                    panel_Alerta.SetActive(true);
                    alerta_Actual.text = texto_alertas[2];
                }
            }
        }
    }
}
