using UnityEngine;

public class VehicleGenerator : MonoBehaviour {
    [SerializeField] private Transform plane;
    [SerializeField] private Vehicle vehiclePrefab;
    [SerializeField] private VehicleModel[] vehicleModels;

    [SerializeField] private int lanes = 3;
    [SerializeField] private float laneWidth;

    private void Awake() {
        for (var lane = 0; lane < lanes; lane++) {
            var z = 0f;

            while (z < 10 * plane.localScale.z) {
                // Player car position
                if (lane == lanes / 2 && z < 6f) {
                    z += 6;
                    continue;
                }

                var position = new Vector3((lane - lanes / 2) * laneWidth, 2, z);
                var vehicle = Instantiate(vehiclePrefab, position, Quaternion.identity);
                vehicle.SetModel(vehicleModels[Random.Range(0, vehicleModels.Length)]);

                var distance = Random.Range(.5f, 2f);
                z += vehicle.Length + distance;
            }
        }
    }
}