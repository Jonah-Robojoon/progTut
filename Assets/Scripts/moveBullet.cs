using UnityEngine;

public class moveBullet : MonoBehaviour
{

    public float speed = 500f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = rb.transform.forward * speed * Time.fixedDeltaTime;
    }
}
