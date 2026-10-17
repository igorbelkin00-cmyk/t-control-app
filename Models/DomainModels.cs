using System;
namespace TControl.Core.Models {
    public enum SwipeDirection { Left, Up, Right }
    public enum ClinicalOutcomeType { Optimal, SuboptimalDelay, PreventableTourniquetSyndrome, LethalHemorrhageRisk }
    public class ClinicalScene {
        public string ImagePath { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Prompt { get; set; } = string.Empty;
    }
}
