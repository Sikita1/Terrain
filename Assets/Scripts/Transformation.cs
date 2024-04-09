using UnityEngine;

public class Transformation : MonoBehaviour
{
    [SerializeField] private Character _sphere;
    [SerializeField] private Character _rotatingCube;
    [SerializeField] private Character _capsule;
    [SerializeField] private Character _cube;

    [SerializeField] private float _speed;
    [SerializeField] private float _slewingSpeed;
    [SerializeField] private float _growthRate;

    private void Update()
    {
        Move(_sphere);
        Rotate(_rotatingCube);
        Enlarge(_capsule);

        Move(_cube);
        Rotate(_cube);
        Enlarge(_cube);
    }

    private void Move(Character character) =>
        character.transform.Translate(0, 0, _speed);

    private void Rotate(Character character) =>
        character.transform.Rotate(0, _slewingSpeed, 0);

    private void Enlarge(Character character) =>
        character.transform.localScale += new Vector3(_growthRate, _growthRate, _growthRate);
}
