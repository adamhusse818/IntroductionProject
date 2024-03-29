using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PlayerMovement : MonoBehaviour{
    public float horizontalMovement; // Players horizontal (x) movement
    public float verticalMovement; // Player's vertical (z) movement

    public float speed = 0.01f; // Speed at which the player moves

    // Have a volume component which includes a vignette
    public Volume vol;
    private Vignette vig;
    
    // Update is called once per frame
    void Update(){
        vol.profile.TryGet(out vig); // Get vignette from volume component
        
        // Read values from keyboard
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
        
        // Call function to move player
        MovePlayer();
    }

    private void MovePlayer(){
        // We activate the vignette if the player is moving(ie. the movement variables are not 0)
        if (horizontalMovement != 0 || verticalMovement != 0) {
            vig.intensity.value = 0.75f;
        }
        else{
            vig.intensity.value = 0f;
        }
        
        // Move player position
        transform.Translate(Vector3.forward * verticalMovement * speed);
        transform.Translate(Vector3.right * horizontalMovement * speed);
    }
}