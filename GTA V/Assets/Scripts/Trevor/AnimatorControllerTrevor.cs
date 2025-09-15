using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerTrevor : MonoBehaviour
{
    private Animator animatorTrevor;

    // Start is called before the first frame update
    void Start()
    {
        animatorTrevor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator_Caminar();
    }

    public void Animator_Caminar()
    {
        animatorTrevor.SetFloat("Horizontal", InputController.Instance.InputHorizontal);
        animatorTrevor.SetFloat("Vertical", InputController.Instance.InputVertical);
    }
}
