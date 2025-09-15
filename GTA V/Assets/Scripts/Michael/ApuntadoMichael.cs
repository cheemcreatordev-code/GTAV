using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntadoMichael : MonoBehaviour
{
    [Header("Estado")]
    public bool EstaApuntadoMichael;

    [Header("Cameras")]
    public Transform CameraMichael;
    public Transform CameraApuntadoMichael;
    public Transform CameraNormalizadoMichael;

    [Header("Speed translation")]
    public float SpeedTranslationApuntadoMichael;

    // Start is called before the first frame update
    void Start()
    {
        CameraMichael.transform.position = CameraNormalizadoMichael.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Funcion_Apuntado_Trevor();
    }

    public void Funcion_Apuntado_Trevor()
    {
        if (InputController.Instance.MouseApuntado)
        {
            EstaApuntadoMichael = true;
            CameraMichael.transform.position = Vector3.Lerp(CameraMichael.transform.position, CameraApuntadoMichael.transform.position, SpeedTranslationApuntadoMichael * Time.deltaTime);
        }
        else
        {
            EstaApuntadoMichael = false;
            CameraMichael.transform.position = Vector3.Lerp(CameraMichael.transform.position, CameraNormalizadoMichael.transform.position, SpeedTranslationApuntadoMichael * Time.deltaTime);
        }
    }
}