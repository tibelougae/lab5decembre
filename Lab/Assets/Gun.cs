using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private BulletPooler _bullerPooler;

	void FixedUpdate () {
        Fire();
    }

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bullet = _bullerPooler.GetBullet();
            bullet.SetActive(true);
            bullet.transform.position = transform.position;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 5, ForceMode.Impulse);
        }
    }
}
