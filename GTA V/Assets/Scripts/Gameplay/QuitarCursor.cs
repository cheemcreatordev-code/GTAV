using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarCursor : MonoBehaviour
{
    public static QuitarCursor InstanceCursor;

    [Header("Configuracion de la visibilidad del cursor")]
    public bool Visibilidad = false;
    public CursorLockMode EstadoCursor = CursorLockMode.Locked;

    void Awake()
    {
        InstanceCursor = this;
    }

    // Update is called once per frame
    void Update()
    {
        Funcion_Quitar_Cursor();
        Actualizar_Cursor();

    }

    public void Funcion_Quitar_Cursor()
    {
        Cursor.visible = Visibilidad;
        Cursor.lockState = EstadoCursor;
    }

    public void Actualizar_Cursor()
    {
        bool eligiendoArma = EligirArmaTrevor.InstanceArmaTrevor.EstaEligiendoArmaTrevor;
        bool eligiendoPersonaje = MenuDeCambioDePersonaje.InstanceMenuDePersonajes.EstaEligiendoPersonaje;

        if (eligiendoArma || eligiendoPersonaje)
        {
            Visibilidad = true;
            EstadoCursor = CursorLockMode.None;
        }
        else
        {
            Visibilidad = false;
            EstadoCursor = CursorLockMode.Locked;
        }
    }

}