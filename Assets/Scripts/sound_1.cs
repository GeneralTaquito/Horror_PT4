using UnityEngine;

public class sound_1 : MonoBehaviour
{
    public AudioSource AS1;
    public AudioSource AS2;
    public AudioSource AS3;
    private bool passCheck = false;
    public GameObject door;


    private void Start()
    {
        door.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!passCheck)
        {
            door.SetActive(true);
            AS1.Pause();
            AS2.Play();
            AS3.Play();
            passCheck = true;
        }
    }
}
