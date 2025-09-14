using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTrevor : MonoBehaviour
{
    private Rigidbody rigidbody;

    [Header("Speeds Movement")]
    [Range(0, 100f)]public float SpeedDefaultTrevor;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Funcion_Movimiento_Trevor();
    }

    public void Funcion_Movimiento_Trevor()
    {
        Vector3 InputMovimientoTrevor = new Vector3(InputController.Instance.InputHorizontal, 0, InputController.Instance.InputVertical);
        Vector3 VectorMovimientoTrevor = transform.TransformDirection(InputMovimientoTrevor.normalized) * SpeedDefaultTrevor;
        rigidbody.velocity = new Vector3(VectorMovimientoTrevor.x, rigidbody.velocity.y, VectorMovimientoTrevor.z);

        Debug.Log("Speed Trevor: " + SpeedDefaultTrevor);
    }
}
