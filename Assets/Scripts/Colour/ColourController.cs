using UnityEngine;

public class ColourController : MonoBehaviour
{
    public DataContainer data;

    public FlameColour defaultColour;
    public FlameColour currentColour;
    public ParticleSystem fireParticles;
    public Light fireLight;
    private bool visible;


    private void Start()
    {
        visible = fireParticles.isPlaying;
        UpdateColour(defaultColour);
    }

    public void ChangeVisibility(bool newVis)
    {
        visible = newVis;
        fireParticles.Play(newVis);
        fireLight.enabled = newVis;
    }

    public void UpdateColour(FlameColour newFlameColour)
    {
        currentColour = newFlameColour;
        Color newColour = data.GetColour(newFlameColour);
        //TODO: this
        var main = fireParticles.main;
        main.startColor = newColour;
        fireLight.color = newColour;
    }
}
