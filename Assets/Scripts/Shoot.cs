using UnityEngine;
using System.Collections;
public class Shoot : MonoBehaviour
{
    public KeyCode shootKey = KeyCode.LeftControl;
    public float delay = 0.45f;

    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftControl))
        //{
        //    GameObject ob = Instantiate(bulletPrefab);
        //    ob.transform.rotation = transform.rotation;
        //    ob.transform.position = transform.position + transform.forward;
        //    Destroy(ob, 3f);
        //}

        if (Input.GetKeyDown(shootKey))
        {
            CallShot();
        }
    }

    public void CallShot()
    {
        StartCoroutine(AwaitDelay(delay));
    }

    
    private IEnumerator AwaitDelay(float time)
    {
        yield return new WaitForSeconds(time); 
        createProjectile();
    }
    public void createProjectile()
    {
        Debug.Log("shoot");
        GameObject ob = Instantiate(bulletPrefab);
        ob.transform.rotation = transform.rotation;
        ob.transform.position = transform.position + transform.forward; 
        Destroy(ob, 3f);
    }
}
