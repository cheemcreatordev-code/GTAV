using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerMichael : MonoBehaviour
{
    private Animator animatorMichael;

    // Start is called before the first frame update
    void Start()
    {
        animatorMichael = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator_Caminar();
    }

    public void Animator_Caminar()
    {
        animatorMichael.SetFloat("Horizontal", InputController.Instance.InputHorizontal);
        animatorMichael.SetFloat("Vertical", InputController.Instance.InputVertical);
    }
}
