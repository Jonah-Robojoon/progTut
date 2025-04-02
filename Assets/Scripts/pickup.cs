using UnityEngine;

public class pickup : MonoBehaviour
{
    private Renderer r;
    private Collider c;
    private AudioSource source;
    private ParticleSystem ps;
    private keepScore scoreScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        r = GetComponent<Renderer>();
        c = GetComponent<Collider>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        scoreScript = FindFirstObjectByType<keepScore>();
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ps.Play();
            source.Play();
            r.enabled = false;
            c.enabled = false;
            scoreScript.AddScore(5);
            GameObject.Destroy(gameObject, 0.5f);
        }
    }
}
