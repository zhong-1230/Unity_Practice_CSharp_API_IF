using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度"),Range(0,100)]
    public float speed = 0.5f;

    public Animator ani;


    private void Start()
    {
        
    }



    private void Move()
    {
        bool W = Input.GetKey(KeyCode.W);
        ani.SetBool("走路開關", W);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,speed * Time.deltaTime);
        }
          
    }

    private void Update()
    {
        Move();
    }

}
