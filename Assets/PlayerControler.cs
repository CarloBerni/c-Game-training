using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]

public class PlayerControler : MonoBehaviour {

    [SerializeField]
    private float speed;

    private PlayerMotor motor;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        //on va calculer la vélocité du mouvement du personnage en un vecteur 3d
        float _xMov = Input.GetAxisRaw("horizontal");
        float _zMov = Input.GetAxisRaw("vertical");

        Vector3_movHorizontal = transform.right * _xMov;
        Vector3_movVertical = transform.forward * _xMov;

        Vector3_velocity = (_movHorizontal + _movVertical).normalized * speed;

        motor.Move(_velocity);
    }

}
