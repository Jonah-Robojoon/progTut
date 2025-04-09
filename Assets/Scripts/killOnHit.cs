using UnityEngine;
using UnityEngine.Audio;

public class killOnHit : MonoBehaviour
{

    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            expl.transform.position = gameObject.transform.position;
            Destroy(expl, 1.7f);
            Destroy(coll.gameObject, 0.1f);
            audioSource.Play();
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            expl.transform.position = gameObject.transform.position;
            Destroy(expl, 1.7f);
            Destroy(coll.gameObject, 0.1f);
            audioSource.Play();
        }
    }
}
