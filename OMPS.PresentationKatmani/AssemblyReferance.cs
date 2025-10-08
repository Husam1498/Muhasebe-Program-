using System.Reflection;

namespace OMPS.PresentationKatmani
{
    /// <summary>
    /// bu assembly i oluşturmamızın amacı web api tarafında
    /// oluşacak olan controllerı presentatiion katmanına taşımamızdan kayunaklıdır.
    /// controller sınıfını web api katmanında tanıtmamız için bu gereklidir
    public static  class AssemblyReferance
    {
        public static readonly Assembly Assembly = typeof(AssemblyReferance).Assembly; 

    }
}
