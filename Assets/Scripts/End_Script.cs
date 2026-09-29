using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Script : MonoBehaviour
{
    public GameObject Monster;
    private Vector3 startpos;
    public Vector3 endpos;
    void Start()
    {
        startpos = Monster.transform.position;
        Monster.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Monster.SetActive(true);

        StartCoroutine(justwait()); 
    }

    IEnumerator justwait()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Game");
    }
}
