using UnityEngine;

public class GridArrangement : MonoBehaviour
{
    public int rows = 4;
    public int columns = 4;
    public float spacing = 1.5f;

    void Start()
    {
        ArrangeCardSlots();
    }

    void ArrangeCardSlots()
    {
        for (int i = 1; i <= 16; i++)
        {
            string slotName = "CardSlot" + i;
            Transform slotTransform = transform.Find(slotName);

            if (slotTransform != null)
            {
                int row = (i - 1) / columns;
                int column = (i - 1) % columns;

                Vector3 position = new Vector3(column * spacing, row * spacing, 0);
                slotTransform.localPosition = position;
            }
            else
            {
                Debug.LogWarning("Could not find " + slotName);
            }
        }
    }
}
