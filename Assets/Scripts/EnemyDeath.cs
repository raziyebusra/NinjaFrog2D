using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    [SerializeField] private AudioSource enemySoundEffect;

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            enemySoundEffect.Play();

            yield return new WaitForSeconds(0.1f);
            Destroy(gameObject);
        }
    }


}
