using UnityEngine;

[CreateAssetMenu]
public class VehicleModel : ScriptableObject {
    [SerializeField] private Vector3 meshRotation;
    [SerializeField] private Mesh mesh;
    [SerializeField] private Material[] materials;

    public Quaternion MeshRotation => Quaternion.Euler(meshRotation);
    public Mesh Mesh => mesh;
    public Material Material => materials[Random.Range(0, materials.Length)];
}