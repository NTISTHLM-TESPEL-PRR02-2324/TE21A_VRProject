using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionController : MonoBehaviour
{
  [SerializeField]
  GameObject bulletPrefab;

  void Start()
  {
    ActionBasedController controller = GetComponent<ActionBasedController>();

    controller.activateAction.action.started += OnTrigger;

  }

  void OnTrigger(InputAction.CallbackContext ctx)
  {
    Debug.Log("BANG!");
    Instantiate(bulletPrefab, transform.position, transform.rotation);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
