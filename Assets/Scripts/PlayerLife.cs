using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }

    }

    private void Update()
    {
        Invoke(nameof(DeathFallFunction), 1.3f);
    }

    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Movement>().enabled = false;
        Invoke(nameof(ReloadLevel), 1.3f);

    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void DeathFallFunction()
    {
        if (gameObject.transform.position.y <= -1)
        {
            ReloadLevel();
        }
    }

}