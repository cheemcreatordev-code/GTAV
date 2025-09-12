using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public static InputController Instance { get; private set; }

    public float InputVertical { get; private set; }
    public float InputHorizontal { get; private set; }

    public float MouseXInput { get; private set; }
    public float MouseYInput { get; private set; }

    public bool AccionSalto { get; private set; }
    public bool AccionCorrer { get; private set; }
    public bool AccionRecargar { get; private set; }
    public bool AccionCambiarArmas { get; private set; }
    public bool AccionLanzarHacha { get; private set; }
    public bool AccionCambioDePersonaje { get; private set; }
    public bool AccionEscape { get; private set; }

    public bool MouseApuntado { get; private set; }
    public bool MouseDisparando { get; private set; }
    public bool MouseAtacandoCentral { get; private set; }
    public bool MouseAtacandoDerecho { get; private set; }
    public bool MouseAtacandoIzquierdo { get; private set; }

    public bool Arma1;
    public bool Arma2;
    public bool Arma3;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        LeerInputsDeCamera();
        LeerInputsDeAccion();
        LeerInputsDelMouse();
        LeerEligirArmaInput();
        LeerInputsDeMovimiento();
    }

    public void LeerInputsDeMovimiento()
    {
        InputVertical = Input.GetAxis("Vertical");
        InputHorizontal = Input.GetAxis("Horizontal");
    }

    public void LeerInputsDeAccion()
    {
        AccionRecargar = Input.GetKeyDown(KeyCode.R);
        AccionSalto = Input.GetKeyDown(KeyCode.Space);
        AccionCorrer = Input.GetKey(KeyCode.LeftShift);
        AccionCambiarArmas = Input.GetKey(KeyCode.E);
        AccionLanzarHacha = Input.GetKeyDown(KeyCode.G);
        AccionEscape = Input.GetKeyDown(KeyCode.Escape);
        AccionCambioDePersonaje = Input.GetKey(KeyCode.Q);
    }

    public void LeerInputsDeCamera()
    {
        MouseXInput = Input.GetAxis("Mouse X");
        MouseYInput = Input.GetAxis("Mouse Y");
    }

    public void LeerInputsDelMouse()
    {
        MouseApuntado = Input.GetMouseButton(1);
        MouseDisparando = Input.GetMouseButton(0);
        MouseAtacandoCentral = Input.GetMouseButtonDown(2);
        MouseAtacandoDerecho = Input.GetMouseButtonDown(1);
        MouseAtacandoIzquierdo = Input.GetMouseButtonDown(0);
    }

    public void LeerEligirArmaInput()
    {
        Arma1 = Input.GetKeyDown(KeyCode.Alpha1);
        Arma2 = Input.GetKeyDown(KeyCode.Alpha2);
        Arma3 = Input.GetKeyDown(KeyCode.Alpha3);
    }
}