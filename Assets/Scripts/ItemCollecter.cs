using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour
{

    private int strawberries = 0;

    [SerializeField] private Text FruitsText;
    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            strawberries++;
            FruitsText.text = "Strawberries: " + strawberries;

        }


    }
}
