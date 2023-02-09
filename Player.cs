using UnityEngine;
public class Player
{
    public Transform a;
    public Vector3 vector;
    public int count;
    private void Start() {
        count = 1;
        vector = new Vector3(0,0,0);
        Debug.Log("TODO: tao ra branch Feature3 trong branch Develop");
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        
    }
}