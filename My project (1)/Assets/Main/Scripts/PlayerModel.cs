using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField]
    private PlayerControlerScript playerControler;
    public Rigidbody rb;
    public bool isMove;
    float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        if (isMove)
        {
            rb.linearVelocity = playerControler.DireccionJugador() * velocidad;
        }
    }
}
