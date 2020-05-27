using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_TEST_LED_CHECK table
    /// This class may be accessed through its own Repository or as an element of the <see cref="Asp330Test"/> class
    /// </summary>
    public class Asp330TestLedCheck : IEquatable<Asp330TestLedCheck>
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public bool? LedCheckPassedYellow { get; set; }
        public bool? LedCheckPassedRed { get; set; }
        public bool? LedCheckPassedMuteButton { get; set; }
        public bool? LedCheckPassedIr { get; set; }
        public bool? LedCheckPassedGreen { get; set; }
        public bool? LedCheckPassedSelectButton { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestLedCheck() { }

        public Asp330TestLedCheck(Asp330TestLedCheck that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
            LedCheckPassedYellow = that.LedCheckPassedYellow;
            LedCheckPassedRed = that.LedCheckPassedRed;
            LedCheckPassedMuteButton = that.LedCheckPassedMuteButton;
            LedCheckPassedIr = that.LedCheckPassedIr;
            LedCheckPassedGreen = that.LedCheckPassedGreen;
            LedCheckPassedSelectButton = that.LedCheckPassedSelectButton;
        }

        public bool Equals(Asp330TestLedCheck that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!LedCheckPassedYellow.Equals(that.LedCheckPassedYellow)) return false;
            if (!LedCheckPassedRed.Equals(that.LedCheckPassedRed)) return false;
            if (!LedCheckPassedMuteButton.Equals(that.LedCheckPassedMuteButton)) return false;
            if (!LedCheckPassedIr.Equals(that.LedCheckPassedIr)) return false;
            if (!LedCheckPassedGreen.Equals(that.LedCheckPassedGreen)) return false;
            if (!LedCheckPassedSelectButton.Equals(that.LedCheckPassedSelectButton)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestLedCheck)that);
        }
    }
}