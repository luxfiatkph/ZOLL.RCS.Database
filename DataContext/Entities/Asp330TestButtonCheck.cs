using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_TEST_BUTTON_CHECK table
    /// This class may be accessed through its own Repository or as an element of the <see cref="Asp330Test"/> class
    /// </summary>
    public class Asp330TestButtonCheck : IEquatable<Asp330TestButtonCheck>
    {
        public Guid Asp330TestId { get; set; }
        public bool? CheckPassedSmartFlowOnButton { get; set; }
        public bool? CheckPassedSmartFlowCalButton { get; set; }
        public bool? CheckPassedModeButton { get; set; }
        public bool? CheckPassedSelectConfirmButton { get; set; }
        public bool? CheckPassedSurgicalButton { get; set; }
        public bool? CheckPassedPharyngealButton { get; set; }
        public bool? CheckPassedTrachealButton { get; set; }
        public bool? CheckPassedCassButton { get; set; }
        public bool? CheckPassedMenuButton { get; set; }
        public bool? ResultCheckBox { get; set; }
        public bool? CheckPassedMuteCancelButton { get; set; }
        public bool? CheckPassedStandbyButton { get; set; }
        public Asp330Test Asp330Test { get; set; }

        public Asp330TestButtonCheck() { }

        public Asp330TestButtonCheck(Asp330TestButtonCheck that)
        {
            Asp330TestId = that.Asp330TestId;
            CheckPassedSmartFlowOnButton = that.CheckPassedSmartFlowOnButton;
            CheckPassedSmartFlowCalButton = that.CheckPassedSmartFlowCalButton;
            CheckPassedModeButton = that.CheckPassedModeButton;
            CheckPassedSelectConfirmButton = that.CheckPassedSelectConfirmButton;
            CheckPassedSurgicalButton = that.CheckPassedSurgicalButton;
            CheckPassedPharyngealButton = that.CheckPassedPharyngealButton;
            CheckPassedTrachealButton = that.CheckPassedTrachealButton;
            CheckPassedCassButton = that.CheckPassedCassButton;
            CheckPassedMenuButton = that.CheckPassedMenuButton;
            ResultCheckBox = that.ResultCheckBox;
            CheckPassedMuteCancelButton = that.CheckPassedMuteCancelButton;
            CheckPassedStandbyButton = that.CheckPassedStandbyButton;
        }

        public bool Equals(Asp330TestButtonCheck that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!CheckPassedSmartFlowOnButton.Equals(that.CheckPassedSmartFlowOnButton)) return false;
            if (!CheckPassedSmartFlowCalButton.Equals(that.CheckPassedSmartFlowCalButton)) return false;
            if (!CheckPassedModeButton.Equals(that.CheckPassedModeButton)) return false;
            if (!CheckPassedSelectConfirmButton.Equals(that.CheckPassedSelectConfirmButton)) return false;
            if (!CheckPassedSurgicalButton.Equals(that.CheckPassedSurgicalButton)) return false;
            if (!CheckPassedPharyngealButton.Equals(that.CheckPassedPharyngealButton)) return false;
            if (!CheckPassedTrachealButton.Equals(that.CheckPassedTrachealButton)) return false;
            if (!CheckPassedCassButton.Equals(that.CheckPassedCassButton)) return false;
            if (!CheckPassedMenuButton.Equals(that.CheckPassedMenuButton)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!CheckPassedMuteCancelButton.Equals(that.CheckPassedMuteCancelButton)) return false;
            if (!CheckPassedStandbyButton.Equals(that.CheckPassedStandbyButton)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestButtonCheck)that);
        }
    }
}