using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadDelEcenario : MonoBehaviour
{
    public int SpeedNormal = 1;
    [Range(0, 1)] public float SpeedSelecionDelPersonaje = 0.5f;

    void Update()
    {
        Speed_Ecenario();
    }

    public void Speed_Ecenario()
    {
        if (MenuDeCambioDePersonaje.InstanceMenuDePersonajes.ActivacionDelMenuDeSelecionDePersonaje || InputController.Instance.AccionCambiarArmas)
        {
            Time.timeScale = SpeedSelecionDelPersonaje;
        }
        else
        {
            Time.timeScale = SpeedNormal;
        }
    }

}