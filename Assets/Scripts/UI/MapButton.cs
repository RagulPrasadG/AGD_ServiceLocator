using UnityEngine;
using UnityEngine.UI;
using ServiceLocator.Main;
using ServiceLocator.Events;

namespace ServiceLocator.UI
{
    public class MapButton : MonoBehaviour
    {
        [SerializeField] private int MapId;
        private EventService eventservice;

        //private void Start() => GetComponent<Button>().onClick.AddListener(OnMapButtonClicked);
        public void SetListener(EventService eventService)
        {
            this.eventservice = eventService;
            GetComponent<Button>().onClick.AddListener(OnMapButtonClicked);
        }

        // To Learn more about Events and Observer Pattern, check out the course list here: https://outscal.com/courses
        private void OnMapButtonClicked() => eventservice.OnMapSelected.InvokeEvent(MapId);
    }
}