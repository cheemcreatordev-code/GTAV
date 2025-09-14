using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMichael : MonoBehaviour
{
    [Header("Speeds Rotation")]
    [Range(0, 1000f)] public float RotationSpeedMichael;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Funcion_Rotar_Michael();
    }

    public void Funcion_Rotar_Michael()
    {
        transform.Rotate(new Vector3(0, InputController.Instance.MouseXInput, 0) * RotationSpeedMichael * Time.deltaTime);
    }
}
