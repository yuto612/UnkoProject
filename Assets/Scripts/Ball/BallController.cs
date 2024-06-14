using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace unkoProject
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private Ball ballPrefab;
        private Ball ball;
        [SerializeField] private float minupforce=70;
        [SerializeField] private float maxupforce=80;

        public Ball CreateBall()
        {
            ball= Instantiate(ballPrefab);
            ball.OnCollision += OnCollision;
            return ball;
        }

        private void OnCollision(Collision collision)
        {
            Debug.Log(collision.gameObject.name);
            var rand = Random.Range(minupforce, maxupforce);
            Debug.Log(rand);
            var force = new Vector3(0, rand, 0);
            ball.GetComponent<Rigidbody>().AddForce(force);
        }
    }
}