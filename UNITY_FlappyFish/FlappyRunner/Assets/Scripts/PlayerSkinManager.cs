using UnityEngine;

public class PlayerSkinManager : MonoBehaviour
{
    public Animator animator;
    public AnimationClip defaultFlyClip;   // The original "fly" clip in the Animator
    public AnimationClip[] skinFlyClips;  

    private AnimatorOverrideController overrideController;

    void Start()
    {
        overrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = overrideController;
    }

    public void ApplySkin(int skinIndex)
    {
        AnimationClip newFlyClip = skinFlyClips[skinIndex];

        overrideController[defaultFlyClip] = newFlyClip;
    }
}
