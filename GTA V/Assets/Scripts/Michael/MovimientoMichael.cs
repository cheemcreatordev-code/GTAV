using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMichael : MonoBehaviour
{
    private Rigidbody rigidbody;

    [Header("Speeds Movement")]
    [Range(0, 100f)]public float SpeedDefaultMichael;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Funcion_Movimiento_Michael();
    }

    public void Funcion_Movimiento_Michael()
    {
        Vector3 InputMovimientoMichael = new Vector3(InputController.Instance.InputHorizontal, 0, InputController.Instance.InputVertical);
        Vector3 VectorMovimientoMichael = transform.TransformDirection(InputMovimientoMichael.normalized) * SpeedDefaultMichael;
        rigidbody.velocity = new Vector3(VectorMovimientoMichael.x, rigidbody.velocity.y, VectorMovimientoMichael.z);

        Debug.Log("Speed Michael: " + SpeedDefaultMichael);
    }
}
