using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntadoFranklin : MonoBehaviour
{
    [Header("Estado")]
    public bool EstaApuntadoFlanklin;

    [Header("Cameras")]
    public Transform CameraFranklin;
    public Transform CameraApuntadoFranklin;
    public Transform CameraNormalizadoFranklin;

    [Header("Speed translation")]
    public float SpeedTranslationApuntadoFranklin;

    // Start is called before the first frame update
    void Start()
    {
        CameraFranklin.transform.position = CameraNormalizadoFranklin.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Funcion_Apuntado_Fraklin();
    }

    public void Funcion_Apuntado_Fraklin()
    {
        if (InputController.Instance.MouseApuntado)
        {
            EstaApuntadoFlanklin = true;
            CameraFranklin.transform.position = Vector3.Lerp(CameraFranklin.transform.position, CameraApuntadoFranklin.transform.position, SpeedTranslationApuntadoFranklin * Time.deltaTime);
        }
        else
        {
            EstaApuntadoFlanklin = false;
            CameraFranklin.transform.position = Vector3.Lerp(CameraFranklin.transform.position, CameraNormalizadoFranklin.transform.position, SpeedTranslationApuntadoFranklin * Time.deltaTime);
        }
    }
}
