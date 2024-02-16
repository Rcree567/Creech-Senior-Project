using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class EnemySpawn : MonoBehaviour
    {
        public GameObject[] enemiesToSpawn;
        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("SpawnNow", 4, Random.Range(2, 4));
        }

        Vector3 getRandomPos()
        {
            float _x = Random.Range(-16, 16);
            float _y = 0.5f;
            float _z = Random.Range(-16, 16);

            Vector3 newPos = new Vector3(_x, _y, _z);
            return newPos;



        }

        void SpawnNow()
        {
            Instantiate(enemiesToSpawn[Random.Range(0, 3)], getRandomPos(), Quaternion.identity);
        }
        private float lateUpdateCount = 0;
        private void LateUpdate()
        {
            lateUpdateCount += 1;
        }
    }
}