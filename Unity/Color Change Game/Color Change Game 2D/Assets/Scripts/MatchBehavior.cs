using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
   public ID idObj;
   public UnityEvent matchEvent, noMatchEvent;
   
   private void OnTriggerEnter(Collider other)
   {
        var tempObj = other.GetComponent<IDContainerBehavior>().idObj;
        if (tempObj == null) 
            return;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
        else
        {
            noMatchEvent.Invoke();

        }
   }

}
