using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrerMichel : MonoBehaviour
{
    public float SpeedRunMichael;
    public float SpeedNormalizedMichael;

    // Start is called before the first frame update
    void Start()
    {
        SpeedNormalizedMichael = MovimientoMichael.InstanceMovimientoMichael.SpeedDefaultMichael;
    }

    // Update is called once per frame
    void Update()
    {
        Correr_Michael();
    }

    public void Correr_Michael()
    {
        if (InputController.Instance.AccionCorrer)
        {
            AnimatorControllerMichael.InstaceAnimatorMichael.PesosDeCapasDeMichael[1] = 1;
            MovimientoMichael.InstanceMovimientoMichael.SpeedDefaultMichael = SpeedRunMichael;
        }
        else
        {
            AnimatorControllerMichael.InstaceAnimatorMichael.PesosDeCapasDeMichael[1] = 0;
            MovimientoMichael.InstanceMovimientoMichael.SpeedDefaultMichael = SpeedNormalizedMichael;
        }
    }
}