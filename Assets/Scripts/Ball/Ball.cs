using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace unkoProject
{
    public class Ball : MonoBehaviour
    {
        public event Action<Collision> OnCollision;

        private void OnCollisionEnter(Collision collision)
        {
            OnCollision.Invoke(collision);
        }
    }
}