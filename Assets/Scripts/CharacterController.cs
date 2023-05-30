using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] PlayerData playerData;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (playerData.jumpCounter != 0)
        {
            _animator.SetLayerWeight(0, 0);
            _animator.SetLayerWeight(1, 1);
        }
        else
        {
            _animator.SetLayerWeight(0, 1);
            _animator.SetLayerWeight(1, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Plane"))
        {
            playerData.jumpCounter = 0;
        }        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RotateCoin"))
        {
            Destroy(other.gameObject, 0.1f);
        }
    }
}
