using UnityEngine;

public class Augmentation : MonoBehaviour
{
    [SerializeField] private float _growthRate;

    private void Update()
    {
        Enlarge();
    }

    private void Enlarge() =>
        transform.localScale += new Vector3(_growthRate, _growthRate, _growthRate);
}
