using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIApuntado : MonoBehaviour
{
    [Header("Sprite")]
    public GameObject ApuntadoSprite;

    [Header("Estado")]
    public bool ActivarApuntado;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UI_Apuntado();
    }

    public void UI_Apuntado()
    {
        ApuntadoSprite.SetActive(ActivarApuntado);

        if (InputController.Instance.MouseApuntado)
        {
            ActivarApuntado = true;
        }
        else
        {
            ActivarApuntado = false;
        }
    }
}