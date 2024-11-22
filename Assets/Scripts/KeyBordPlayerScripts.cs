using UnityEngine;

public class KeyBordPlayerScripts : MonoBehaviour
{
    private float PlayerWorkSpeed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, PlayerWorkSpeed * Time.deltaTime);
            Debug.Log("Push!WKey");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-PlayerWorkSpeed * Time.deltaTime, 0, 0);
            Debug.Log("Push!AKey");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -PlayerWorkSpeed * Time.deltaTime);
            Debug.Log("Push!SKey");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(PlayerWorkSpeed * Time.deltaTime, 0, 0);
            Debug.Log("Push!DKey");
        }
    }
}
