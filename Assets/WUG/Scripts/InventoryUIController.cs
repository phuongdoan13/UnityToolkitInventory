using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace WUG.Scripts
{
    public class InventoryUIController : MonoBehaviour
    {
        public List<InventorySlot> InventoryItems = new List<InventorySlot>();

        VisualElement m_Root;
        VisualElement m_SlotsContainer;

        void Start()
        {
        }
        
        void Awake()
        {
            //Store the root from the UI Document component
            m_Root = GetComponent<UIDocument>().rootVisualElement;

            //Search the root for the SlotContainer Visual Element
            m_SlotsContainer = m_Root.Q<VisualElement>("SlotsContainer");

            //Create InventorySlots and add them as children to the SlotContainer
            for (int i = 0; i < 20; i++)
            {
                InventorySlot item = new InventorySlot();
                InventoryItems.Add(item);
                m_SlotsContainer.Add(item);
            }
        }
        
    }
}