using UnityEngine;

public class AvatarAssembler : MonoBehaviour
{
    public Transform partParent;
    private GameObject currentHair, currentTop, currentBottom, currentAccessory;

    public void ApplyConfig(AvatarConfig config)
    {
        ClearParts();

        if (config.hair) currentHair = Instantiate(config.hair.prefab, partParent);
        if (config.top) currentTop = Instantiate(config.top.prefab, partParent);
        if (config.bottom) currentBottom = Instantiate(config.bottom.prefab, partParent);
        if (config.accessory) currentAccessory = Instantiate(config.accessory.prefab, partParent);
    }

    void ClearParts()
    {
        foreach (Transform child in partParent)
        {
            Destroy(child.gameObject);
        }
    }
}
