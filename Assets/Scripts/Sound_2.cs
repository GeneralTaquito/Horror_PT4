using System.Collections;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Sound_2 : MonoBehaviour
{
    public AudioSource Stepping1;
    public AudioSource Stepping2;
    private bool Swap;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(startStepping());
    }

    IEnumerator startStepping()
    {
        float RNG = Random.Range(2f, 4f);
        yield return new WaitForSeconds(RNG);

        if (Swap)
        {
            Stepping1.Play();
            yield return new WaitForSeconds(RNG);
            Stepping1.Pause();
        }
        else
        {
            Stepping2.Play();
            yield return new WaitForSeconds(RNG);
            Stepping2.Pause();
        }

        Swap = !Swap;
    }

    private void OnTriggerExit(Collider other)
    {
        StopCoroutine(startStepping());
    }
}
