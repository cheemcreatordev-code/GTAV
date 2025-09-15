using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrerFranklin : MonoBehaviour
{
    public float SpeedRunFranklin;
    public float SpeedNormalizedFranklin;

    // Start is called before the first frame update
    void Start()
    {
        SpeedNormalizedFranklin = MovimientoFlanklin.InstaceMovimientoFranklin.SpeedDefaultFlanklin;
    }

    // Update is called once per frame
    void Update()
    {
        Correr_Franklin();
    }

    public void Correr_Franklin()
    {
        if (InputController.Instance.AccionCorrer)
        {
            AnimatorControllerFlanklin.InstaceAnimatorFlanklin.PesosDeCapasDeFranklin[1] = 1;
            MovimientoFlanklin.InstaceMovimientoFranklin.SpeedDefaultFlanklin = SpeedRunFranklin;
        }
        else
        {
            AnimatorControllerFlanklin.InstaceAnimatorFlanklin.PesosDeCapasDeFranklin[1] = 0;
            MovimientoFlanklin.InstaceMovimientoFranklin.SpeedDefaultFlanklin = SpeedNormalizedFranklin;
        }
    }
}
