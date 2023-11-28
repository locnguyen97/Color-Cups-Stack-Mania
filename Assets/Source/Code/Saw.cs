using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    [SerializeField] private ParticleSystem eff;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (GameManager.Instance.isStartGame)
        {
            if (other.transform.CompareTag("objMove")) return;
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].RemoveObject(other.gameObject);
            Destroy(other.gameObject);
            eff.Play();
        }
    }
}
