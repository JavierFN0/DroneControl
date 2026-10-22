using UnityEngine;

public class Movement : MonoBehaviour
{
    const float speed = 10f;
    [SerializeField] private float _speedX = 5f;
    [SerializeField] private float _speedY = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0f, moveZ) * (_speedX * Time.deltaTime);
        transform.Translate(movement);
        
    }
}
