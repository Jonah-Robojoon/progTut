using UnityEngine;

public class Launch : MonoBehaviour
{
    public Rigidbody rb;
    public int jumpStrengh;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpStrengh * Time.deltaTime);
        }
    }
}
