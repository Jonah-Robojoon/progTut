using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class cubePlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public int speed = 4;
    public int rotSpeed = 5;
    public float Jumpforce = 20f;
    private bool onFloor = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        onFloor = false;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        transform.position = positionUpdate;

        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));

        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            rb.AddForce(transform.up * Jumpforce, ForceMode.Impulse);
            onFloor = false;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
    }
}


