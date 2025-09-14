using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFlanklin : MonoBehaviour
{
    private Rigidbody rigidbody;

    [Header("Speeds Movement")]
    [Range(0, 100f)]public float SpeedDefaultFlanklin;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Funcion_Movimiento_Flanklin();
    }

    public void Funcion_Movimiento_Flanklin()
    {
        Vector3 InputMovimientoFlanklin = new Vector3(InputController.Instance.InputHorizontal, 0, InputController.Instance.InputVertical);
        Vector3 VectorMovimientoFlanklin = transform.TransformDirection(InputMovimientoFlanklin.normalized) * SpeedDefaultFlanklin;
        rigidbody.velocity = new Vector3(VectorMovimientoFlanklin.x, rigidbody.velocity.y, VectorMovimientoFlanklin.z);

        Debug.Log("Speed Flanklin: " + SpeedDefaultFlanklin);
    }
}
