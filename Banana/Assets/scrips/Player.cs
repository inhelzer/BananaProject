using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, Controls.IGameControlsActions
{
    [SerializeField] Sprite changeSprite;
    Controls controls;

    private void Awake()
    {
        controls = new Controls();
        controls.GameControls.SetCallbacks(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        controls.GameControls.Enable();
    }

    private void OnDestroy()
    {
        controls.GameControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().sprite = changeSprite;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
    }

    public void OnHit(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
