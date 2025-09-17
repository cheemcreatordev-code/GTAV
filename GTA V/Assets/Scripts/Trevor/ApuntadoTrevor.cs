using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntadoTrevor : MonoBehaviour
{
    [Header("Estado")]
    public bool EstaApuntadoTrevor;

    [Header("Cameras")]
    public Transform CameraTrevor;
    public Transform CameraApuntadoTrevor;
    public Transform CameraNormalizadoTrevor;

    [Header("Speed translation")]
    public float SpeedTranslationApuntadoTrevor;

    // Start is called before the first frame update
    void Start()
    {
        CameraTrevor.transform.position = CameraNormalizadoTrevor.transform.position;
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
            EstaApuntadoTrevor = true;
            CameraTrevor.transform.position = Vector3.Lerp(CameraTrevor.transform.position, CameraApuntadoTrevor.transform.position, SpeedTranslationApuntadoTrevor * Time.deltaTime);
            AnimatorControllerTrevor.InstanceAnimatorControllerTrevor.PesosDeCapasDeTrevor[2] = 1;

        }
        else
        {
            EstaApuntadoTrevor = false;
            CameraTrevor.transform.position = Vector3.Lerp(CameraTrevor.transform.position, CameraNormalizadoTrevor.transform.position, SpeedTranslationApuntadoTrevor * Time.deltaTime);
            AnimatorControllerTrevor.InstanceAnimatorControllerTrevor.PesosDeCapasDeTrevor[2] = 0;
        }
    }
}