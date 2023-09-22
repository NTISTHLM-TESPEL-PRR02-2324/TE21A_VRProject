using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
  [SerializeField]
  float force = 5;

  void Start()
  {
    GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
  }
}
