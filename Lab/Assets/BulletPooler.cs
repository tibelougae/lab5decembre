using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : MonoBehaviour {

    [SerializeField]
    private GameObject _bulletPrefab;
    Stack<GameObject> readyBullets;
    Stack<GameObject> activeBullets;
    private const int START_NB_BULLETS = 10;

	void Start () {
        readyBullets = new Stack<GameObject>();
        activeBullets = new Stack<GameObject>();

        for (int i = 0; i < START_NB_BULLETS; i++)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.parent = this.gameObject.transform;
            readyBullets.Push(bullet);
        }
    }
	
    public GameObject GetBullet()
    {
        GameObject bullet = readyBullets.Pop();
        activeBullets.Push(bullet);
        return bullet;
    }

    public void ReturnBullet(GameObject bullet)
    {
        readyBullets.Push(bullet);
    }
}
