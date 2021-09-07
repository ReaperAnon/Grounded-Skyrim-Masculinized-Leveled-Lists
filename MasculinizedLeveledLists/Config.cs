using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace MasculinizedLeveledLists
{
    public class PatcherConfig
    {
        [Tooltip("This option will allow mages to be in any faction regardless of the other options set.")]
        public bool AllowMages = false;

        [Tooltip("Whether to remove female draugr from the leveled lists.")]
        public bool AllowDraugr = false;

        [Tooltip("Whether to remove female forsworn from the leveled lists.")]
        public bool AllowForsworn = true;

        [Tooltip("Whether to remove female vampires from the leveled lists.")]
        public bool AllowVampires = true;

        [Tooltip("Whether to remove female falmer from the leveled lists.")]
        public bool AllowFalmer = true;
    }
}
