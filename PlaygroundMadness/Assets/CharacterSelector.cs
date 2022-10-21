using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
   public Character character;
   
   public void ChooseCharacter()
   {
      GameManager.Instance.StoreSelectedCharacter(character);
   }
}
