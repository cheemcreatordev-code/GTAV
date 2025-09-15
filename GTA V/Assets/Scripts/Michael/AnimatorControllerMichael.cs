using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerMichael : MonoBehaviour
{
    public static AnimatorControllerMichael InstaceAnimatorMichael;

    private Animator animatorMichael;
    public float[] PesosDeCapasDeMichael;

    void Awake()
    {
        InstaceAnimatorMichael = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        animatorMichael = GetComponent<Animator>();
        PesosDeCapasDeMichael = new float[animatorMichael.layerCount];
    }

    // Update is called once per frame
    void Update()
    {
        Animator_Caminar_Mochael();
        Funcion_De_Capa_Animator_Franklin();
    }

    public void Animator_Caminar_Mochael()
    {
        animatorMichael.SetFloat("Horizontal", InputController.Instance.InputHorizontal);
        animatorMichael.SetFloat("Vertical", InputController.Instance.InputVertical);
    }

    public void Funcion_De_Capa_Animator_Franklin()
    {
        for (int i = 0; i < animatorMichael.layerCount; i++)
        {
            animatorMichael.SetLayerWeight(i, PesosDeCapasDeMichael[i]);
        }
    }
}