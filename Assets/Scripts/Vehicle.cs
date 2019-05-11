using UnityEngine;

public class Vehicle : MonoBehaviour {
    [SerializeField] private MeshFilter meshFilter;
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private MeshCollider meshCollider;

    public float Length => meshCollider.bounds.size.z;

    public void SetModel(VehicleModel vehicleModel) {
        meshFilter.mesh = vehicleModel.Mesh;
        meshRenderer.material = vehicleModel.Material;
        meshCollider.sharedMesh = vehicleModel.Mesh;

        meshRenderer.transform.localRotation = vehicleModel.MeshRotation;
        meshRenderer.transform.localPosition = new Vector3(0, 0, meshCollider.bounds.size.z / 2);
    }
}