using GDLib.Comms;
using Mirror;
using Space;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [Header("Data")]
    [SerializeField] PlayerData data;

    public override void OnStartLocalPlayer()
    {
        transform.position = data.SpawnPos;
    }

    private void Update()
    {
        if (!isLocalPlayer)
            return;

        float x = Input.GetAxis("Horizontal");
        x *= data.SpeedMod * Time.deltaTime;

        float currentX = transform.position.x + x;

        currentX = Mathf.Clamp(
            currentX, 
            GameManager.MinBoundX, 
            GameManager.MaxBoundX);

        transform.position = new Vector2(currentX, transform.position.y);
    }
}
