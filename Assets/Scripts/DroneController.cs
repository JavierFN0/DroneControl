using UnityEngine;

public class Status : MonoBehaviour
{
    [SerializeField] private float hp = 100;
    [SerializeField] private float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0f, moveZ) * (speed * Time.deltaTime);
        transform.Translate(movement);
    }

    void TakeDamage(float damage)
    {
        hp -= damage;
    }
}
