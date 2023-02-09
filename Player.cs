using UnityEngine;
public class Player
{
    public Transform a;
    public Vector3 vector;
    public int count;
    private void Start() {
        count = 1;
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        
    }
}