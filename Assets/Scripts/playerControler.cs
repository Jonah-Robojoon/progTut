using UnityEngine;

public class playerControler : MonoBehaviour
{

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            animator.SetTrigger("dance");
        }
    }
}
