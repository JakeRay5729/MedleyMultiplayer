using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public int _ammoCount = 15;

public class AmmoCounter : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void AmmoCount(int bullets)
    {
        _ammoCount += bullets
    }

    public void FireBullet()
    {
        AmmoCount(-1);
        _nextShot = Time.time + _fireRate;
        Vector3 _laserOffset = new Vector3(0, 1.04f, 0);

        if( Input.GetKeyDown(KeyCode.Space) && Time.time> _nextShot)
        {
            if(_ammoCount == 0)
            {
                return;
            }
            FireBullet();
        }
    }
}
