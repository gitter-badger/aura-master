// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Channel.Util;
using Aura.Shared.Network;
using Aura.Channel.Network.Sending;
using Aura.Shared.Util;
using Aura.Shared.Mabi.Const;
using Aura.Channel.Skills.Base;


namespace Aura.Channel.Network.Handlers
{

    public partial class CraftUIHandler : PacketHandlerManager<ChannelClient>
    {

        [PacketHandler(Op.CraftWindow)]
        public void UiOpen(ChannelClient client, Packet packet)
        {
            var skillId = (SkillId)packet.GetUShort();
            var creature = client.GetCreatureSafe(packet.Id);
            var skill = creature.Skills.GetSafe(skillId);
            var propId = packet.GetLong();
            var ProdId = packet.GetInt();
            
        }

    }
}
