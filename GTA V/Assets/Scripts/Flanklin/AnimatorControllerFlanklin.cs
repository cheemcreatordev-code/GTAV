using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerFlanklin : MonoBehaviour
{
    private Animator animatorFlanklin;

    [Header("Capa")]
    [Range(0f, 100f)]public int CapaAnimatorJason;
    public float[] PesosDeCapasDeJason;


    // Start is called before the first frame update
    void Start()
    {
        animatorFlanklin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator_Caminar();
    }

    public void Animator_Caminar()
    {
        animatorFlanklin.SetFloat("Horizontal", InputController.Instance.InputHorizontal);
        animatorFlanklin.SetFloat("Vertical", InputController.Instance.InputVertical);
    }
}