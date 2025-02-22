﻿using Sandbox;
using SWB_Base;

/*
 * This serves as a code example, css models are not included! 
*/

namespace SWB_CSS;

[Library("swb_css_ak47", Title = "AK-47")]
public class AK47 : WeaponBase
{
    public override int Bucket => 3;
    public override HoldType HoldType => HoldType.Rifle;
    public override string ViewModelPath => "weapons/swb/css/ak47/css_v_rif_ak47.vmdl";
    public override string WorldModelPath => "weapons/swb/css/ak47/css_w_rif_ak47.vmdl";
    public override string Icon => "code/swb_css/textures/ui/css_icon_ak47.png";

    public AK47()
    {
        General = new WeaponInfo
        {
            FOV = 75,
            WalkAnimationSpeedMod = 0.85f,

            ReloadTime = 2.17f
        };

        Primary = new ClipInfo
        {
            Ammo = 30,
            AmmoType = AmmoTypes.Rifle,
            ClipSize = 30,

            BulletSize = 4f,
            BulletType = new HitScanBullet(),
            Damage = 15f,
            Force = 3f,
            Spread = 0.1f,
            Recoil = 0.5f,
            RPM = 600,
            FiringType = FiringType.auto,
            ScreenShake = new ScreenShake
            {
                Length = 0.08f,
                Delay = 0.02f,
                Size = 0.5f,
                Rotation = 0.1f
            },

            DryFireSound = "swb_rifle.empty",
            ShootSound = "css_ak47.fire",

            BulletEjectParticle = new("particles/pistol_ejectbrass.vpcf"),
            MuzzleFlashParticle = new("particles/swb/muzzle/flash.vpcf"),
            BulletTracerParticle = new("particles/swb/tracer/tracer.vpcf"),

            InfiniteAmmo = InfiniteAmmoType.reserve
        };

        ZoomAnimData = new AngPos
        {
            Angle = new Angles(-2.3f, -0.05f, 0),
            Pos = new Vector3(-6.085f, 0, 2.2f)
        };

        RunAnimData = new AngPos
        {
            Angle = new Angles(10, 40, 0),
            Pos = new Vector3(5, 0, 0)
        };
    }
}
