using Unity.VisualScripting;
using UnityEngine;

public class PlayerMvmt : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotateSpeed = 120f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }






    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(x, y, 0f);
        //transform.Rotate(0.8f, 0f, 0f);
        transform.Translate(Move * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
        }
    }
}
