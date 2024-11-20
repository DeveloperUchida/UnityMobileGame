using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerJoistickControl : MonoBehaviour
{
    private float PlayerSpeed = 10;
    private Rigidbody PlayerRigid; //プレイヤーのRigidBodyの名前を PlayerRigidへ
    
    private Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        PlayerRigid.MovePosition(PlayerRigid.position + movement.normalized * PlayerSpeed * Time.fixedDeltaTime);
    }
}
