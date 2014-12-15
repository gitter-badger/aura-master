// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;

namespace Aura.Data.Database
{
    [Serializable]
    public class ProductionData
    {
        public int WindowId { get; set; }
        public int Id { get; set; }
        public int Product { get; set; }
        public int Amount { get; set; }
        public int Rank { get; set; }
        public int merchExp { get; set; }
        public string recipe { get; set; }
        public int manaReq { get; set; }

        public int RNsuccessProcent { get; set; }
        public int RFsuccessProcent { get; set; }
        public int REsuccessProcent { get; set; }
        public int RDsuccessProcent { get; set; }
        public int RCsuccessProcent { get; set; }
        public int RBsuccessProcent { get; set; }
        public int RAsuccessProcent { get; set; }
        public int R9successProcent { get; set; }
        public int R8successProcent { get; set; }
        public int R7successProcent { get; set; }
        public int R6successProcent { get; set; }
        public int R5successProcent { get; set; }
        public int R4successProcent { get; set; }
        public int R3successProcent { get; set; }
        public int R2successProcent { get; set; }
        public int R1successProcent { get; set; }

    }

    /// <summary>
    /// Contains Information about walking speed of several races.
    /// This is for information purposes only, actually changing
    /// the speed would require client modifications.
    /// Indexed by group identification.
    /// </summary>
    public class ProdDb : Database<string, ProductionData>
    {
        [MinFieldCount(2)]
        protected override void ReadEntry(CsvEntry entry)
        {
            var info = new ProductionData();
                info.WindowId = entry.ReadInt();
                info.Id = entry.ReadInt();
                info.Product = entry.ReadInt();
                info.Amount = entry.ReadInt();
                info.Rank = entry.ReadInt();
                info.merchExp = entry.ReadInt();
                info.recipe = entry.ReadString();
                info.manaReq = entry.ReadInt();

                info.RNsuccessProcent = entry.ReadInt();
                info.RFsuccessProcent = entry.ReadInt();
                info.REsuccessProcent = entry.ReadInt();
                info.RDsuccessProcent = entry.ReadInt();
                info.RCsuccessProcent = entry.ReadInt();
                info.RBsuccessProcent = entry.ReadInt();
                info.RAsuccessProcent = entry.ReadInt();
                info.R9successProcent = entry.ReadInt();
                info.R8successProcent = entry.ReadInt();
                info.R7successProcent = entry.ReadInt();
                info.R6successProcent = entry.ReadInt();
                info.R5successProcent = entry.ReadInt();
                info.R4successProcent = entry.ReadInt();
                info.R3successProcent = entry.ReadInt();
                info.R2successProcent = entry.ReadInt();
                info.R1successProcent = entry.ReadInt();
        }
    }
}
