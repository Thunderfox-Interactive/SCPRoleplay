﻿using System.Collections.Generic;
using Sandbox;
using SWB_Base;
using SWB_Base.Attachments;
using SWB_Base.Bullets;

namespace SWB_WEAPONS;

[Library("swb_spas12", Title = "SPAS-12")]
public class SPAS12 : WeaponBaseShotty
{
    public override int Bucket => 2;
    public override HoldType HoldType => HoldType.Shotgun;
    public override string HandsModelPath => "weapons/swb/hands/swat/v_hands_swat.vmdl";
    public override string ViewModelPath => "weapons/swb/shotguns/spas/v_spas12.vmdl";
    public override string WorldModelPath => "weapons/swb/shotguns/spas/w_spas12.vmdl";
    public override string Icon => "materials/swb/weapons/spas12.png";

    public override float ShellReloadTimeStart => 0.4f;
    public override float ShellReloadTimeInsert => 0.65f;
    public override float ShellEjectDelay => 0.5f;

    public SPAS12()
    {
        General = new WeaponInfo
        {
            FOV = 60,
            ZoomWeaponFOV = 50,
            WalkAnimationSpeedMod = 0.9f
        };

        Primary = new ClipInfo
        {
            Ammo = 8,
            AmmoType = AmmoTypes.Shotgun,
            ClipSize = 8,

            Bullets = 8,
            BulletSize = 2f,
            BulletType = new ShotgunBullet(),
            Damage = 15f,
            Force = 5f,
            HitFlinch = 2.5f,
            Spread = 0.2f,
            Recoil = 2f,
            RPM = 60,
            FiringType = FiringType.semi,
            ScreenShake = new ScreenShake
            {
                Length = 0.08f,
                Delay = 0.02f,
                Size = 2f,
                Rotation = 0.15f
            },

            DryFireSound = "swb_shotty.empty",
            ShootSound = "spas12.fire",

            BulletEjectParticle = new("particles/pistol_ejectbrass.vpcf"),
            MuzzleFlashParticle = new("particles/swb/muzzle/flash.vpcf", 3f, 2f),
            BarrelSmokeParticle = new("particles/swb/muzzle/barrel_smoke.vpcf", 3f, 2f),
            BulletTracerParticle = new("particles/swb/tracer/phys_tracer.vpcf"),

            InfiniteAmmo = InfiniteAmmoType.reserve
        };

        ZoomAnimData = new AngPos
        {
            Angle = new Angles(0.08f, -0.06f, 0f),
            Pos = new Vector3(-5f, 0f, 1.95f)
        };

        RunAnimData = new AngPos
        {
            Angle = new Angles(10, 50, 0),
            Pos = new Vector3(10, -2, 0)
        };

        CustomizeAnimData = new AngPos
        {
            Angle = new Angles(-2.25f, 51.84f, 0f),
            Pos = new Vector3(11.22f, -4.96f, 1.078f)
        };

        // Attachments //
        AttachmentCategories = new List<AttachmentCategory>()
        {
            new AttachmentCategory
            {
                Name = AttachmentCategoryName.Muzzle,
                BoneOrAttachment = "muzzle",
                Attachments = new List<AttachmentBase>()
                {
                    new ShotgunSilencer
                    {
                        MuzzleFlashParticle = "particles/swb/muzzle/flash_silenced.vpcf",
                        ShootSound = "swb_shotgun.silenced.fire",
                        ViewParentBone = "shotgun",
                        ViewTransform = new Transform {
                            Position = new Vector3(0.004f, 3.4f, 36.623f),
                            Rotation = Rotation.From(new Angles(90f, 0f, -90f)),
                            Scale = 12f
                        },
                        WorldParentBone = "shotgun",
                        WorldTransform = new Transform {
                            Position = new Vector3(-0.011f, 3.4f, 36.616f),
                            Rotation = Rotation.From(new Angles(90f, 0f, -90f)),
                            Scale = 12f
                        },
                    }
                }
            },
            new AttachmentCategory
            {
                Name = AttachmentCategoryName.Tactical,
                BoneOrAttachment = "",
                Attachments = new List<AttachmentBase>()
                {
                    new SmallLaserRed
                    {
                        Color = Color.Red,
                        ViewParentBone = "shotgun",
                        ViewTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                        WorldParentBone = "shotgun",
                        WorldTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                    },
                    new SmallLaserBlue
                    {
                        Color = Color.Blue,
                        ViewParentBone = "shotgun",
                        ViewTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                        WorldParentBone = "shotgun",
                        WorldTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                    },
                    new SmallLaserGreen
                    {
                        Color = Color.Green,
                        ViewParentBone = "shotgun",
                        ViewTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                        WorldParentBone = "shotgun",
                        WorldTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                    },
                    new SmallLaserRainbow
                    {
                        RainbowColor = true,
                        ViewParentBone = "shotgun",
                        ViewTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                        WorldParentBone = "shotgun",
                        WorldTransform = new Transform {
                            Position = new Vector3(0f, 1.5f, 31.2f),
                            Rotation = Rotation.From(new Angles(-90f, 0f, 180f)),
                            Scale = 5.269f
                        },
                    },
                }
            }
        };
    }
}
