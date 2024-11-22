using UnityEngine;
// using UnityEngine.InputSystem;
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
        Vector3 movement3D = new Vector3(movement.x, 0,movement.y);
        PlayerRigid.MovePosition(PlayerRigid.position + movement3D.normalized * PlayerSpeed * Time.fixedDeltaTime);
    }

}
