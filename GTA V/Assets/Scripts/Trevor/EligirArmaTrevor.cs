using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EligirArmaTrevor : MonoBehaviour
{
    public static EligirArmaTrevor InstanceArmaTrevor;

    public GameObject RuletaTrevor;
    public bool EstaEligiendoArmaTrevor;

    void Awake()
    {
        InstanceArmaTrevor = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ActivarRuletaTrevor();
    }

    public void ActivarRuletaTrevor()
    {
        if (InputController.Instance.AccionCambiarArmas)
        {
            RuletaTrevor.SetActive(true);
            EstaEligiendoArmaTrevor = true;
        }
        else
        {
            RuletaTrevor.SetActive(false);
            EstaEligiendoArmaTrevor = false;
        }
    }
}