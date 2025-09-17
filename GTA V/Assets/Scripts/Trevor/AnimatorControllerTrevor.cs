using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerTrevor : MonoBehaviour
{
    public static AnimatorControllerTrevor InstanceAnimatorControllerTrevor;

    private Animator animatorTrevor;
    public float[] PesosDeCapasDeTrevor;

    void Awake()
    {
        InstanceAnimatorControllerTrevor = this;    
    }

    // Start is called before the first frame update
    void Start()
    {
        animatorTrevor = GetComponent<Animator>();
        PesosDeCapasDeTrevor = new float[animatorTrevor.layerCount];
    }

    // Update is called once per frame
    void Update()
    {
        Animator_Caminar();
        Funcion_De_Capa_Animator_Trevor();
    }

    public void Animator_Caminar()
    {
        animatorTrevor.SetFloat("Horizontal", InputController.Instance.InputHorizontal);
        animatorTrevor.SetFloat("Vertical", InputController.Instance.InputVertical);
    }

    public void Funcion_De_Capa_Animator_Trevor()
    {
        for (int i = 0; i < animatorTrevor.layerCount; i++)
        {
            animatorTrevor.SetLayerWeight(i, PesosDeCapasDeTrevor[i]);
        }
    }
}