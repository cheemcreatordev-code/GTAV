using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDeCambioDePersonaje : MonoBehaviour
{
    public static MenuDeCambioDePersonaje InstanceMenuDePersonajes;

    public GameObject MenuDeSelecionDePersonaje;
    public bool ActivacionDelMenuDeSelecionDePersonaje;


    public Transform MainCamera;
    public Transform CameraTrevor;
    public Transform CameraMichael;
    public Transform CameraFlanklin;

    public bool IsTrevor = false;
    public bool IsMichael = false;
    public bool IsFranklin = false;

    public ControladorMichael controladormichael;
    public ContenedorFranklin contenedorfranklin;
    public ContenedorDeScriptTrevor contenedordescripttrevor;

    public bool EstaEligiendoPersonaje;

    void Awake()
    {
        InstanceMenuDePersonajes = this;
    }

    // Update is called once per frame
    void Update()
    {
        Activar_Contenedores();
        Activar_Menu_De_Cambio_De_Personaje();
    }

    public void Activar_Contenedores()
    {
        controladormichael.enabled = IsMichael;
        contenedorfranklin.enabled = IsFranklin;
        contenedordescripttrevor.enabled = IsTrevor;
    }


    public void Activar_Menu_De_Cambio_De_Personaje()
    {
        if (InputController.Instance.AccionCambioDePersonaje)
        {
            MenuDeSelecionDePersonaje.SetActive(true);
            ActivacionDelMenuDeSelecionDePersonaje = true;
            EstaEligiendoPersonaje = true;
        }
        else
        {
            MenuDeSelecionDePersonaje.SetActive(false);
            ActivacionDelMenuDeSelecionDePersonaje = false;
            EstaEligiendoPersonaje = false;
        }
    }

    public void Yo_Te_Eligo_Trevor()
    {
        MainCamera.SetParent(CameraTrevor);
        MainCamera.transform.position = CameraTrevor.transform.position;
        MainCamera.transform.rotation = CameraTrevor.transform.rotation;
        IsTrevor = true;
        IsMichael = false;
        IsFranklin = false;
    }

    public void Yo_Te_Eligo_Michael()
    {
        MainCamera.SetParent(CameraMichael);
        MainCamera.transform.position = CameraMichael.transform.position;
        MainCamera.transform.rotation = CameraMichael.transform.rotation;
        IsTrevor = false;
        IsMichael = true;
        IsFranklin = false;
    }

    public void Yo_Te_Eligo_Flanklin()
    {
        MainCamera.SetParent(CameraFlanklin);
        MainCamera.transform.position = CameraFlanklin.transform.position;
        MainCamera.transform.rotation = CameraFlanklin.transform.rotation;
        IsTrevor = false;
        IsMichael = false;
        IsFranklin = true;
    }
}