using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace unkoProject
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private Ball ballPrefab;

        public Ball CreateBall()
        {
            var prefab = Instantiate(ballPrefab);
            prefab.OnCollision += OnCollision;
            return prefab;
        }

        private void OnCollision(Collision collision)
        {
            Debug.Log(collision.gameObject.name);
        }
    }
}