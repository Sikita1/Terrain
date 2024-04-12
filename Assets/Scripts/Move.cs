using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Moved();
    }

    private void Moved() =>
        transform.Translate(0, 0, _speed);
}
