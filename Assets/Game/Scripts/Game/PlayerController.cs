using Mirror;
using Space;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [Header("Components")]
    [SerializeField] SpriteRenderer spriteRenderer;

    [Header("Data")]
    [SerializeField] PlayerData data;

    [SyncVar(hook = "OnColorChanged")]
    private Color playerColor;
    public Color PlayerColor => playerColor;

    public void OnColorChanged(Color _old, Color _new)
        => spriteRenderer.color = _new;

    [Command]
    private void CmdInitializePlayer(Color _col)
        => playerColor = _col;

    public override void OnStartLocalPlayer()
    {
        transform.position = data.SpawnPos;

        Color randomColor = new(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);

        CmdInitializePlayer(randomColor);
    }

    private void Update()
    {
        if (!isLocalPlayer)
            return;

        Vector3 inputAxis = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"));

        inputAxis *= data.SpeedMod * Time.deltaTime;

        inputAxis += transform.position;
        inputAxis.x = Mathf.Clamp(inputAxis.x, GameManager.instance.MinBoundX, GameManager.instance.MaxBoundX);
        inputAxis.y = Mathf.Clamp(inputAxis.y, data.YBoundMin, data.YBoundMax);

        transform.position = inputAxis;
    }
}
