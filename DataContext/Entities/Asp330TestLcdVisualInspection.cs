using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_TEST_LCD_VISUAL_INSPECTION table
    /// This class may be accessed through its own Repository or as an element of the <see cref="Asp330Test"/> class
    /// </summary>
    public class Asp330TestLcdVisualInspection : IEquatable<Asp330TestLcdVisualInspection>
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public bool? LcdArtifactFree { get; set; }
        public bool? LcdBacklightEven { get; set; }
        public bool? LcdBlemishFree { get; set; }
        public bool? LcdContrastGood { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestLcdVisualInspection() { }

        public Asp330TestLcdVisualInspection(Asp330TestLcdVisualInspection that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
            LcdArtifactFree = that.LcdArtifactFree;
            LcdBacklightEven = that.LcdBacklightEven;
            LcdBlemishFree = that.LcdBlemishFree;
            LcdContrastGood = that.LcdContrastGood;
        }

        public bool Equals(Asp330TestLcdVisualInspection that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!LcdArtifactFree.Equals(that.LcdArtifactFree)) return false;
            if (!LcdBacklightEven.Equals(that.LcdBacklightEven)) return false;
            if (!LcdBlemishFree.Equals(that.LcdBlemishFree)) return false;
            if (!LcdContrastGood.Equals(that.LcdContrastGood)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestLcdVisualInspection)that);
        }
    }
}