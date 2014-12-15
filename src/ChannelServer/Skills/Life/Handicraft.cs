using Aura.Channel.Network.Sending;
using Aura.Channel.Skills.Base;
using Aura.Channel.Skills;
using Aura.Channel.World.Entities;
using Aura.Shared.Mabi.Const;
using Aura.Shared.Network;
using Aura.Shared.Util;
using Aura.Channel.World;
using Aura.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Aura.Channel.Skills.Life
{
    [Skill(SkillId.Handicraft)]
    public class Handicraft : IPreparable, ICompletable, ICancelable, IUseable
    {
        private const int HandicraftWindowID = 5;
        private const int PropID = 0;

        public void Use(Creature creature, Skill skill, Packet packet)
        {
            //0001 [............271D] Short  : Skill ID
            //0002 [............0005] Short  : Window layout
            //0003 [............0006] Short  : Skill window ID
            //0004 [........00000001] Int    : ProductionID 
            //0005 [0000000000000000] Long   : Maybe prop target
            var WindowID = packet.GetShort();
            var SkillID = packet.GetShort();
            var ProdID = packet.GetInt();
            Send.SystemMessage(creature, WindowID.ToString());
            Send.SystemMessage(creature, SkillID.ToString());
            Send.SystemMessage(creature, ProdID.ToString());

        }

        public void Prepare(Creature creature, Skill skill, int castTime, Packet packet)
        {
            
            var QueStatus = packet.GetByte();
            var ProdID = packet.GetInt();
            var AmountMade = packet.GetShort();
            var WindowID = packet.GetShort();
            var QueC = packet.GetShort();
            var QueL = packet.GetByte();
            
            



        }
        //0002 [..............02] Byte   : QueStatus
        //0003 [........00000006] Int    : SkillWindow
        //0004 [............0001] Short  : Amount to be made
        //0005 [............0006] Short  : ProdID
        //0006 [............0001] Short  : Currently que
        //0007 [..............01] Byte   : Currently left in que

        public void Complete(Creature creature, Skill skill, Packet packet)
        {
            var Uk1 = packet.GetByte();
            var ProdID = packet.GetInt();
            var SkillID = packet.GetShort();
            var Uk2 = packet.GetShort();
            var WindowID = packet.GetShort();
            var Uk3 = packet.GetByte();

            Send.SystemMessage(creature, WindowID.ToString());
            Send.SystemMessage(creature, SkillID.ToString());
            Send.SystemMessage(creature, ProdID.ToString());
            creature.Skills.ActiveSkill = null;
            Send.SystemMessage(creature, "DONE");
            creature.Skills.Callback(SkillId.Handicraft);
        }

        public void Cancel(Creature creature, Skill skill)
        {
        }
    }
}
