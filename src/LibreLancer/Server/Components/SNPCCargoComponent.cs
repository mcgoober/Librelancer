using System.Collections.Generic;
using System.Linq;
using LibreLancer.GameData;
using LibreLancer.GameData.Items;
using LibreLancer.World;
using LibreLancer.World.Components;

namespace LibreLancer.Server.Components;


public class SNPCCargoComponent : AbstractCargoComponent
{
    public List<BasicCargo> Cargo = new List<BasicCargo>();

    public SNPCCargoComponent(GameObject parent) : base(parent) { }

    public override int TryConsume(Equipment item, int maxCount = 1)
    {
        for (int i = 0; i < Cargo.Count; i++) {
            if (Cargo[i].Item == item)
            {
                if (Cargo[i].Count <= maxCount)
                {
                    Cargo.RemoveAt(i);
                    return Cargo[i].Count;
                }
                else
                {
                    Cargo[i] = new BasicCargo(Cargo[i].Item, Cargo[i].Count - maxCount);
                    return maxCount;
                }
            }
        }
        return 0;
    }

    public override T FirstOf<T>()
    {
        var slot = Cargo.FirstOrDefault(x => x.Item is T);
        return (T) slot.Item;
    }
}
