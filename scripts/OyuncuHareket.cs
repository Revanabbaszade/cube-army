using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    public float hareketHizi = 5f;
    public float minX = -5f; // Sol sınırlar
    public float maxX = 5f;  // Sağ sınırlar
    public float minY = -3f; // Aşağı sınırlar
    public float maxY = 3f;  // Yukarı sınırlar

    void Update()
    {
        float hareketX = Input.GetAxis("Horizontal");
        float hareketY = Input.GetAxis("Vertical");

        Vector2 hareket = new Vector2(hareketX, hareketY) * hareketHizi * Time.deltaTime;
        Vector2 yeniPozisyon = (Vector2)transform.position + hareket;

        // Sınırları kontrol et
        yeniPozisyon.x = Mathf.Clamp(yeniPozisyon.x, minX, maxX);
        yeniPozisyon.y = Mathf.Clamp(yeniPozisyon.y, minY, maxY);

        transform.position = yeniPozisyon;
    }
}
