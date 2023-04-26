using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCollectible : MonoBehaviour
{
    public AudioClip coinsound;
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        {
            controller.speed = 5.0f;
            Destroy(gameObject);

            controller.PlaySound(coinsound);
        }
    }
}
