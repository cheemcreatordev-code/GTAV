using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFlanklin : MonoBehaviour
{
    [Header("Speeds Rotation")]
    [Range(0, 1000f)] public float RotationSpeedFlanklin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Funcion_Rotar_Flanklin();
    }

    public void Funcion_Rotar_Flanklin()
    {
        transform.Rotate(new Vector3(0, InputController.Instance.MouseXInput, 0) * RotationSpeedFlanklin * Time.deltaTime);
    }
}
