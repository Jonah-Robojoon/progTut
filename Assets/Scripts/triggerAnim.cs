using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class triggerAnim : MonoBehaviour
{

    public string triggerName;
    public float delay = 0f;
    public float resetTime;
    public KeyCode triggerKey = KeyCode.None;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(triggerKey))
        {
            CallTrigger();
        }
    }
    public void CallTrigger()
    {
        StartCoroutine(AwaitDelay(delay));
        StartCoroutine(AwaitReset(resetTime));
    }

    private IEnumerator AwaitDelay(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetTrigger(triggerName);
    }
    private IEnumerator AwaitReset(float time)
    {
        yield return new WaitForSeconds(time);
        animator.ResetTrigger(triggerName);
    }
}
