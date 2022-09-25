using System;
using System.Collections.Generic;
using System.Numerics;

namespace LibreLancer
{
    public class ShipFormation
    {
        public GameObject LeadShip;
        public List<GameObject> Followers = new List<GameObject>();

        public Vector3[] Offsets = new[]
        {
            new Vector3(-60, 0, 0),
            new Vector3(60, 0, 0),
            new Vector3(0, -60, 0),
            new Vector3(0, 60, 0)
        };

        public Vector3 GetOffset(GameObject self)
        {
            if (LeadShip == self) return Vector3.Zero;
            var idx = Followers.IndexOf(self);
            if (idx == -1) throw new InvalidOperationException("Ship not in formation");
            return Vector3.Transform(Offsets[idx], LeadShip.WorldTransform);
        }

        public ShipFormation()
        {
        }

        public ShipFormation(GameObject lead, GameObject follow)
        {
            LeadShip = lead;
            Followers.Add(follow);
        }
    }
}