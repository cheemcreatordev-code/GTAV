using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerFlanklin : MonoBehaviour
{
    public static AnimatorControllerFlanklin InstaceAnimatorFlanklin;

    private Animator animatorFranklin;

    [Header("Capa")]
    //[Range(0f, 100f)] public int CapaAnimatorFranklin;
    public float[] PesosDeCapasDeFranklin;

    void Awake()
    {
        InstaceAnimatorFlanklin = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        animatorFranklin = GetComponent<Animator>();
        PesosDeCapasDeFranklin = new float[animatorFranklin.layerCount];
    }

    // Update is called once per frame
    void Update()
    {
        Animator_Caminar_Franklin();
        Funcion_De_Capa_Animator_Franklin();
    }

    public void Animator_Caminar_Franklin()
    {
        animatorFranklin.SetFloat("Horizontal", InputController.Instance.InputHorizontal);
        animatorFranklin.SetFloat("Vertical", InputController.Instance.InputVertical);
    }
    
    public void Funcion_De_Capa_Animator_Franklin()
    {
        for (int i = 0; i < animatorFranklin.layerCount; i++)
        {
            animatorFranklin.SetLayerWeight(i, PesosDeCapasDeFranklin[i]);
        }
    }
}