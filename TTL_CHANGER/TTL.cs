using Microsoft.Win32;

namespace TTL_CHANGER
{
    public class TTL
    {
        //HKEY_LOCAL_MACHINE => SYSTEM => CurrentControlSet => services
        private static RegistryKey services = Registry.LocalMachine
                .OpenSubKey("SYSTEM", true)
                .OpenSubKey("CurrentControlSet", true)
                .OpenSubKey("services", true);

        //...services => Tcpip => Parameters            
        private static RegistryKey Parameters = services
                .OpenSubKey("Tcpip", true)
                .OpenSubKey("Parameters", true);

        //...services => TCPIP6
        private static RegistryKey TCPIP6 = services
                .OpenSubKey("TCPIP6", true);

        public static void SetMobileTTL()
        {
            //QWord DefaultTTL = 65 X32
            Parameters.SetValue("DefaultTTL", 65, RegistryValueKind.DWord);

            //QWord DefaultTTL = 65 X32
            TCPIP6.SetValue("DefaultTTL", 65, RegistryValueKind.DWord);
        }

        public static void SetToDefault()
        {
            //QWord DefaultTTL = 65 X32            
            Parameters.SetValue("DefaultTTL", 128, RegistryValueKind.DWord);

            //QWord DefaultTTL = 65 X32            
            TCPIP6.SetValue("DefaultTTL", 128, RegistryValueKind.DWord);
        }
    }
}
