using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMichael : MonoBehaviour
{
    // Todos los scripts que quieres controlar
    public MonoBehaviour[] scripts;

    // Se llama automáticamente cuando este componente se activa
    private void OnEnable()
    {
        SetScripts(true);
    }

    // Se llama automáticamente cuando este componente se desactiva
    private void OnDisable()
    {
        SetScripts(false);
    }

    // Función para activar o desactivar todos los scripts
    private void SetScripts(bool estado)
    {
        foreach (MonoBehaviour script in scripts)
        {
            if (script != null)
                script.enabled = estado;
        }
    }
}
