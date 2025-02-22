﻿using System.Collections.Generic;
using Sandbox;
using SWB_Base;

/*
 * This serves as a code example, css models are not included! 
*/

namespace SWB_CSS;

[Library("swb_css_m4a1", Title = "M4A1")]
public class M4A1 : WeaponBase
{
    public override int Bucket => 3;
    public override HoldType HoldType => HoldType.Rifle;
    public override string ViewModelPath => "weapons/swb/css/m4a1/css_v_m4a1.vmdl";
    public override string WorldModelPath => "weapons/swb/css/m4a1/css_w_m4a1.vmdl";
    public override string Icon => "code/swb_css/textures/ui/css_icon_m4a1.png";

    public M4A1()
    {
        General = new WeaponInfo
        {
            FOV = 75,
            WalkAnimationSpeedMod = 0.85f,

            ReloadTime = 3.05f
        };

        Primary = new ClipInfo
        {
            Ammo = 30,
            AmmoType = AmmoTypes.Rifle,
            ClipSize = 30,

            BulletSize = 3.5f,
            BulletType = new HitScanBullet(),
            Damage = 13f,
            Force = 2.5f,
            Spread = 0.08f,
            Recoil = 0.45f,
            RPM = 700,
            FiringType = FiringType.auto,
            ScreenShake = new ScreenShake
            {
                Length = 0.08f,
                Delay = 0.02f,
                Size = 0.5f,
                Rotation = 0.1f
            },

            DryFireSound = "swb_rifle.empty",
            ShootSound = "css_m4a1.fire",

            BulletEjectParticle = new("particles/pistol_ejectbrass.vpcf"),
            MuzzleFlashParticle = new("particles/swb/muzzle/flash.vpcf"),
            BulletTracerParticle = new("particles/swb/tracer/tracer.vpcf"),

            InfiniteAmmo = InfiniteAmmoType.reserve
        };

        AnimatedActions = new List<AnimatedAction>
        {
            new AnimatedAction
            {
                ActionButtons = new List<string>
                {
                    InputButtonHelper.Use,
                    InputButtonHelper.Reload
                },
                OnAnimation = "add_silencer",
                OnAnimationDuration = 2f,
                OffAnimation = "remove_silencer",
                OffAnimationDuration = 2f,
                AnimationStatus = "silenced",
                NewWorldModel = "weapons/swb/css/m4a1/css_w_m4a1_silencer.vmdl",
                NewShootSound = "css_m4a1.fire_silenced"
            }
        };

        ZoomAnimData = new AngPos
        {
            Angle = new Angles(-2.8f, -1.5f, -4f),
            Pos = new Vector3(-6.34f, 6, 0.57f)
        };

        RunAnimData = new AngPos
        {
            Angle = new Angles(10, 40, 0),
            Pos = new Vector3(5, 0, 0)
        };
    }
}
