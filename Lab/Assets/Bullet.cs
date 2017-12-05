using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField]
    private GameObject _bulletPooler;

	void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
