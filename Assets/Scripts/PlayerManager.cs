using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float slideSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] PlayerData playerData;


    private Endless playerInput;
    private void Awake()
    {
        playerData.jumpCounter = 0;
        playerInput = new Endless();
    }
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    void Update()
    {
        gameObject.GetComponent<Transform>().Translate(0f, 0f, playerSpeed * Time.deltaTime);
        Vector2 slideInput = playerInput.Player.Move.ReadValue<Vector2>();
        if (slideInput.x > 0)
        {
            gameObject.GetComponent<Transform>().Translate(slideSpeed * Time.deltaTime, 0f, 0f);
        }
        else if (slideInput.x < 0)
        {
            gameObject.GetComponent<Transform>().Translate(-slideSpeed * Time.deltaTime, 0f, 0f);
        }

        if (slideInput.y > 0.5f && playerData.jumpCounter == 0)
        {
            gameObject.transform.GetChild(0).GetComponent<Rigidbody>().AddForce(transform.up * jumpForce, ForceMode.Impulse);
            playerData.jumpCounter++;
        }
        else if (slideInput.y < -0.5f && playerData.jumpCounter > 0)
        {
            gameObject.transform.GetChild(0).GetComponent<Rigidbody>().AddForce(-transform.up * jumpForce/5, ForceMode.Impulse);
            //playerData.jumpCounter++;
        }
    }
}
