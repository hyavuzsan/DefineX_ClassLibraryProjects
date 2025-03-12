using System;
using System.Reflection;

namespace AttributeLibrary
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class ZorunluAlanAttribute : Attribute
    {
        public static bool Dogrula(object dogrulanacakEntity)
        {
            Type dogrulamacakTur = dogrulanacakEntity.GetType();
            PropertyInfo[] dogrulanacakTurAlanlari = dogrulamacakTur.GetProperties(
                                                  BindingFlags.Public |
                                                  BindingFlags.Instance);
            foreach (PropertyInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakEntity) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

