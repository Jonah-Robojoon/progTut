using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject ob = Instantiate(bulletPrefab);
            ob.transform.rotation = transform.rotation;
            ob.transform.position = transform.position + transform.forward;
            Destroy(ob, 3f);
        }
    }
}
