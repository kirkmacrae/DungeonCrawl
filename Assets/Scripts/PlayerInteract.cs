using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    Animator playerAnimator;
    private Vector2 playerFacing;
    public float interactRange = 0.6f;
    public LayerMask interactLayer;
    public DialogBox dialogBox;

    // Update is called once per frame
    private void Start()
    {
        playerAnimator = GetComponent<Animator>();        
    }
    void Update()
    {

        if(dialogBox.isActiveAndEnabled && Input.anyKeyDown)
        {
            print("active dialog box needs disabling");
            dialogBox.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            //TODO smooth this out to avoid diagonal interactions (since player sprite always faces orthogonal direction)
            playerFacing = new Vector2((float)playerAnimator.GetFloat("Horizontal"), (float)playerAnimator.GetFloat("Vertical"));
            RaycastHit2D hit = Physics2D.Raycast(transform.position, playerFacing, interactRange, interactLayer);
            
            if (hit)
            {
                print("interacting with: " + hit.collider.name);
                hit.collider.GetComponent<Interactable>().interact();
            }
        }
    }
}
