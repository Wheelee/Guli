using UnityEngine;
using TMPro;

public class WeatherManager : MonoBehaviour
{
    [Header("Affichage UI")]
    public TextMeshProUGUI text_temperature;
    public TextMeshProUGUI text_city;
    public TextMeshProUGUI text_country;

    [Header("Saisons (Objets)")]
    public GameObject saison_ete;
    public GameObject saison_automne;
    public GameObject saison_hiver;

    [Header("Sols (Grounds)")]
    public GameObject Ground_ete;
    public GameObject Ground_automne;
    public GameObject Ground_hiver;

    public void ChangerMeteoEte()
    {
        MettreAJour("Nice", "France", "28°C", 0);
    }

    public void ChangerMeteoAutomne()
    {
        MettreAJour("Paris", "France", "12°C", 1);
    }

    public void ChangerMeteoHiver()
    {
        MettreAJour("Montréal", "Canada", "-5°C", 2);
    }

    private void MettreAJour(string ville, string pays, string temp, int index)
    {
        // Mise à jour du texte
        text_city.text = ville;
        text_country.text = pays;
        text_temperature.text = temp;

        // Gestion des Saisons (Arbres/VFX)
        saison_ete.SetActive(index == 0);
        saison_automne.SetActive(index == 1);
        saison_hiver.SetActive(index == 2);

        // Gestion des Sols (Grounds)
        Ground_ete.SetActive(index == 0);
        Ground_automne.SetActive(index == 1);
        Ground_hiver.SetActive(index == 2);
    }
}