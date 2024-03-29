using UnityEngine;

public class MoveToLocation : MonoBehaviour{
    // Two possible positions to travel to
    public Vector3 positionQ;
    public Vector3 positionE;

    // Start is called before the first frame update
    void Start(){
        // Initialize positions
        positionQ = new Vector3(-10f, 20f, 4f);
        positionE = new Vector3(100f, 70f, -70f);
    }

    // Update is called once per frame
    void Update(){
        // Now we just see if the player presses any of the keys then set our position to there
        if (Input.GetKey("q")){
            transform.position = positionQ;
        }
        if (Input.GetKey("e")){
            transform.position = positionE;
        }
    }
}