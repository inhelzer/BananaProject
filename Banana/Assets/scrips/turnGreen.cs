using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class turnGreen : MonoBehaviour, Controls.IGameControlsActions
{
    [SerializeField] Color colorChange;
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

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnHit(InputAction.CallbackContext context)
    {
        GetComponent<SpriteRenderer>().color = colorChange;
    }
}
