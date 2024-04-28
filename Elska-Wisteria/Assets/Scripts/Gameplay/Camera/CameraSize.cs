using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class CameraSize : MonoBehaviour
    {

        /// <summary>
        /// cards in the game
        /// </summary>
        [SerializeField] Transform[] cards;

        /// <summary>
        /// called when cards are generated in the game.
        /// </summary>
        public void OnCardsGenerate(int noOfRow)
        {

            this.cards = cards;

            Camera.main.transform.position = new Vector3(0, 0, -noOfRow * 3);
        }
    }
}
