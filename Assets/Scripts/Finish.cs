using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishsound;

    private bool comepletelevel = false;
    // Start is called before the first frame update
    private void Start()
    {
        finishsound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !comepletelevel)
        {
            finishsound.Play();
            comepletelevel = true;
            Invoke("Completelevel", 2f);
        }
    }
    private void Completelevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
