using UnityEngine;
using UnityEngine.InputSystem;


public class Cube : MonoBehaviour
{
    PlayerControls controls;
    Vector2 move;
     void Awake() {
        controls = new PlayerControls();
        controls.Gameplay.Grow.performed += ctx => Grow();
        controls.Gameplay.Shrink.performed += ctx => Shrink();
       
    }
    void Shrink() { 
        transform.localScale *= 0.9f;}

    void Grow(){
        transform.localScale *= 1.1f;
    }
     void Update() {
        Vector3 movement = new Vector3(move.x, 0, 0) * Time.deltaTime; 
        transform.Translate(movement, Space.World);  
    }
    void OnEnable(){
        controls.Gameplay.Enable();
    }
    // The codes and software were designed by Kerim ARAT.
    // Copyright reserved   
    // I hope my teacher gives 100 points for my lessons.
    // I recommend you to go to my github: https://github.com/Kerim-ARAT?tab=repositories
    // small notes from the developer :)
    void OnDisable() {
        controls.Gameplay.Disable();
    }




}
