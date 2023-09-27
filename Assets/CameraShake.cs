using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update
    public IEnumerator Shake (float totalTime, float magnitude) {
        Vector3 originalPos = transform.position;

        float elapsedtime = 0f;

        while (elapsedtime < totalTime) {
            float xOffset = Random.Range(-0.5f, 0.5f) * magnitude;
            float yOffset = Random.Range(-0.5f, 0.5f) * magnitude;

            transform.position = new Vector3(xOffset, yOffset, originalPos.z);

            elapsedtime += Time.deltaTime;

            yield return 0;
        }
        transform.position = originalPos;
    }
}
