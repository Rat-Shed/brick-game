using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class SoundManager : MonoBehaviour
{
    private EventInstance brickPlaceInstance;
    [SerializeField] private EventReference _brickPlaceReference;

    private EventInstance brickStepInstance;
    [SerializeField] private EventReference _brickStepReference;
    private EventInstance brickJumpInstance;
    [SerializeField] private EventReference _brickJumpReference;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        brickPlaceInstance = RuntimeManager.CreateInstance(_brickPlaceReference);
        brickStepInstance = RuntimeManager.CreateInstance(_brickStepReference);
        brickJumpInstance = RuntimeManager.CreateInstance(_brickJumpReference);
    }

    public void SoundBrickPlace()
    {
        brickPlaceInstance.start();
    }

    public void SoundBrickStep()
    {
        brickStepInstance.start();
    }
    public void SoundBrickJump()
    {
        brickJumpInstance.start();
    }
}