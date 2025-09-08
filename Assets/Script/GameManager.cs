using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public RectTransform waterRegion;
    public GameObject fishPrefab;
    void Start()
    {
        CreateFish();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateFish()
    {
        int fishCount = Random.Range(5, 20);
        for(int i =0;i< fishCount;i++)
        {
            GameObject fish = Instantiate(fishPrefab, waterRegion.position, waterRegion.rotation);
            fish.transform.SetParent(waterRegion, false);

            RectTransform fishRect = fish.GetComponent<RectTransform>();
            float with = Random.Range(-waterRegion.rect.width / 2, waterRegion.rect.width / 2);
            float height = Random.Range(-waterRegion.rect.height / 2, waterRegion.rect.height / 2);

            fishRect.anchoredPosition = new Vector2(with, height);
        }    
    }    
}
