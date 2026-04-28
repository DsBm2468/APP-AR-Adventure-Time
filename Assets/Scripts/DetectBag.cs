using UnityEngine;

public class DetectBag : MonoBehaviour
{
    public GameObject imagenGuardianes;
    public AudioSource musica8Bits;
    public AudioSource musicaFondo;

    // Cuando BMO se acerca a la maleta
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            imagenGuardianes.SetActive(true);

            if (musicaFondo != null) musicaFondo.Pause(); // Pausa la música de fondo
            if (musica8Bits != null) musica8Bits.Play();  // Empieza la música del videojuego
        }
    }

    // Cuando BMO se aleja de la maleta
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            imagenGuardianes.SetActive(false);

            if (musica8Bits != null) musica8Bits.Stop();   // Para la música del videojuego
            if (musicaFondo != null) musicaFondo.UnPause(); // Sigue la música de fondo donde iba
        }
    }
}
