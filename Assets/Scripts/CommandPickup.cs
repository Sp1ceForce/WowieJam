using UnityEngine;

public class CommandPickup : MonoBehaviour
{
    [SerializeField] AICommand pickupCommand;
    public AICommand PickupCommand { get => pickupCommand; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AvailableCommandsList availableCommandsList = collision.gameObject.GetComponent<AvailableCommandsList>();
        if (availableCommandsList != null)
        {
            availableCommandsList.AddCommand(pickupCommand);
            gameObject.SetActive(false);
        }
    }
}
