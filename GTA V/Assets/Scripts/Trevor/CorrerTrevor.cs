using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrerTrevor : MonoBehaviour
{
    public float SpeedRunTrevor;
    public float SpeedNormalizedTrevor;

    // Start is called before the first frame update
    void Start()
    {
        SpeedNormalizedTrevor = MovimientoTrevor.InstanceMovimientoTrevor.SpeedDefaultTrevor;
    }

    // Update is called once per frame
    void Update()
    {
        Correr_Trevor();
    }

    public void Correr_Trevor()
    {
        if (InputController.Instance.AccionCorrer)
        {
            if (InputController.Instance.InputHorizontal != 0 || InputController.Instance.InputVertical != 0)
            {
                AnimatorControllerTrevor.InstanceAnimatorControllerTrevor.PesosDeCapasDeTrevor[1] = 1;
                MovimientoTrevor.InstanceMovimientoTrevor.SpeedDefaultTrevor = SpeedRunTrevor;
            }
        }
        else
        {
            AnimatorControllerTrevor.InstanceAnimatorControllerTrevor.PesosDeCapasDeTrevor[1] = 0;
            MovimientoTrevor.InstanceMovimientoTrevor.SpeedDefaultTrevor = SpeedNormalizedTrevor;
        }
    }
}