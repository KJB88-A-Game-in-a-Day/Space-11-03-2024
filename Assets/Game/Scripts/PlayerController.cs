using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [Header("Modifiers")]
    [SerializeField] private float speedMod;

    public override void OnStartLocalPlayer()
    {

    }

    private void Update()
    {
        if (!isLocalPlayer)
            return;

        float x = Input.GetAxis("Horizontal");
        x = speedMod * Time.deltaTime;

        float currentX = transform.position.x + x;

        currentX = Mathf.Clamp(currentX, )

        transform.position = speedMod * Time.deltaTime * new Vector3(x, 0.0f);
    }
}
