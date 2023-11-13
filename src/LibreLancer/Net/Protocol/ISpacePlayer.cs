namespace LibreLancer.Net.Protocol;

[RPCInterface]

public interface ISpacePlayer
{
    void RequestDock(ObjNetId id);
    void FireProjectiles(ProjectileSpawn[] projectiles);
    void FireMissiles(MissileFireCmd[] missiles);
    void EnterFormation(int ship);
    void LeaveFormation();

    void UseRepairKits();
    void UseShieldBatteries();
}
