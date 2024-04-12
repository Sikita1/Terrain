using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _slewingSpeed;

    private void Update()
    {
        Rotate();
    }

    private void Rotate() =>
        transform.Rotate(0, _slewingSpeed, 0);
}
