using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VCompass
{

    public class Ways
    {
        /* public Sprite PassengerFace;
         public Text Distance;
         public PassDestination DesiredLocation;
         public CanvasGroup canGroup;*/

            public Transform PassengerFace;
            public Transform Player;
            public Transform DesiredLocation;
            public CanvasGroup canGroup;
    }


    public class HoriCompass : MonoBehaviour
    {
        public static HoriCompass Compass;

        public Transform PlayerTaxi;

        [Space]
        [Header("NEWS")]

        public Transform North, South, East, West;

        [Space]
        [Header("Target Points")]

        public Transform Waypoints;
        public Dictionary<string, Ways> locs = new Dictionary<string, Ways>();
        public Dictionary<string, Ways> news = new Dictionary<string, Ways>();

        float width = 0;
        float widthOff = 15f;

        void Awake()
        {
            if (Compass != null && Compass != this)
            {
                //Debug.LogWarning("More than one Compass instance?");
                return;
            }

            Compass = this;
        }

        void Update()
        {
            this.Arrows();

            if(this.locs.Count > 0)
            {
                List<string> wapoKeys = new List<string>(this.locs.Keys);

                foreach(string key in wapoKeys)
                {
                    this.CreateWayPoints(key, Vector3.zero);
                }

            }

        }

        void Start()
        {
            this.width = this.GetComponent<RectTransform>().sizeDelta.x - this.widthOff;

            //North
            news.Add("north", new Ways()
            {
                canGroup = this.North.GetComponent<CanvasGroup>(),
                PassengerFace = this.North,
                Player = this.PlayerTaxi, DesiredLocation = this.North
            });

            //South
            news.Add("south", new Ways()
            {
                canGroup = this.South.GetComponent<CanvasGroup>(),
                PassengerFace = this.South,
                Player = this.PlayerTaxi,
                DesiredLocation = this.South
            });

            //East
            news.Add("east", new Ways()
            {
                canGroup = this.East.GetComponent<CanvasGroup>(),
                PassengerFace = this.East,
                Player = this.PlayerTaxi,
                DesiredLocation = this.East
            });

            //West
            news.Add("west", new Ways()
            {
                canGroup = this.West.GetComponent<CanvasGroup>(),
                PassengerFace = this.West,
                Player = this.PlayerTaxi,
                DesiredLocation = this.West
            });

            Arrows();

        }

        // creating North, east, south and west
        void Arrows()
        {
            CreateWayPoints("north", Vector3.forward, true);
            CreateWayPoints("south", Vector3.back, true);
            CreateWayPoints("east", Vector3.right, true);
            CreateWayPoints("west", Vector3.left, true);
        }

        void CreateWayPoints(string key, Vector3 directions, bool pole = false)
        {
            Ways wapo = null;

            if (pole)
            {
                if (!this.news.TryGetValue(key, out wapo)) return;
            }
            else if (!this.locs.TryGetValue(key, out wapo)) return;
         

            if (wapo == null || wapo.Player == null) return;

            Vector3 offset = PlayerTaxi.InverseTransformPoint(wapo.Player.position + directions);
            float angle = Mathf.Atan2(offset.x, offset.z);
            Vector3 pos = Vector3.right * (this.width * 2) * angle / (2f * Mathf.PI);

            if(wapo.DesiredLocation != null)
            {
                wapo.DesiredLocation.localPosition = new Vector3(pos.x, wapo.DesiredLocation.localPosition.y, 0);
            }

            if(wapo.canGroup != null)
            {
                if (angle < -1.58f || angle > 1.58f)   wapo.canGroup.alpha = 0;
                else if (wapo.canGroup.alpha < 1f)   wapo.canGroup.alpha = 1;
            }

            if (pole) this.news[key] = wapo;
            else this.locs[key] = wapo;

        }


        //Adding a waypoint
        public bool add(string key, Ways waypo, bool fade = true)
        {
            if (locs.ContainsKey(key)) return false;

            waypo.DesiredLocation = Instantiate(waypo.PassengerFace, Waypoints, false);
            waypo.canGroup = waypo.DesiredLocation.GetComponent<CanvasGroup>();
            waypo.canGroup.alpha = 0;

            locs.Add(key, waypo);

            if (fade)
            {
                waypo.canGroup.alpha = 0.25f;
            }
            else
            {
                waypo.canGroup.alpha = 1;
            }

            return true;

        }


        // Recieving waypoints
        public Ways getway(string key)
        {
            Ways wapo = null;
            locs.TryGetValue(key, out wapo);
            return wapo;
        }


        //removing a waypoint
        public bool remove(string key)
        {
            Ways wp = null;
            locs.TryGetValue(key, out wp);
            if(wp != null)
            {
                locs.Remove(key);
                wp.canGroup.alpha = 0;
                //Destroy(wp, 0.25f);
                return true;
            }
            return false;
        }


    }
}