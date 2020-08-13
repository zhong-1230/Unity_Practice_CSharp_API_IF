using UnityEngine;

public class wasd : MonoBehaviour
{
    public Animator anin;

    public bool wating;
    public bool running;
    
    public float player_speed;

    private void start()
    {
        anin = GetComponent<Animator>();

        wating = true;
        running = false;

        player_speed = 3f;
    }



    private void Control()
    {
        
    

}
