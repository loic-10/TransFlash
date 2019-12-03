using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using Multicouche.DAL.Cryptographie;

namespace Multicouche.DAL.Activateur
{
    public class Activateur
    {
        CrypterMD5 crypterMD5 = new CrypterMD5();

        private string AnneeActuel()
        {
            return DateTime.Now.Year.ToString();
        }

        public string ActivateurDefaut()
        {
            return "LNW20520-D7JN-3BN0-CAMAR0DJJELN";
        }

        private string Part(string val1, string val2, string val3)
        {
            return val1 + val2 + val3;
        }

        static public string GetIdProcesseur()
        {
            string result = string.Empty;
            ManagementObjectSearcher objectSearcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_processor");
            ManagementObjectCollection collect = objectSearcher.Get();
            foreach (ManagementObject o in objectSearcher.Get())
            {
                result = o["ProcessorID"].ToString();
            }
            return result;
        }

        static public string GetIdCarteMere()
        {
            string result = string.Empty;
            ManagementObjectSearcher objectSearcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection collect = objectSearcher.Get();
            foreach (ManagementObject o in objectSearcher.Get())
            {
                result = o["SerialNumber"].ToString();
            }
            return result;
        }

        private string GetNumeroSerie()
        {
            NetworkInterface[] networks = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAdress = string.Empty;

            foreach (NetworkInterface network in networks)
            {
                if (sMacAdress == string.Empty)
                {
                    IPInterfaceProperties properties = network.GetIPProperties();
                    sMacAdress = network.GetPhysicalAddress().ToString();
                }
            }
            return sMacAdress;
        }

        private string GetCodeUnique()
        {
            string idCarteMere = GetIdCarteMere();
            string idProcesseur = GetIdProcesseur();
            string numeroSerie = GetNumeroSerie();
            string part1, part2, part3, part4, part5, part6, part7, part8, part9, part10;
            part1 = idProcesseur.Substring(11, 1) + numeroSerie.Substring(0, 2) + idCarteMere.Substring(9, 1);
            part2 = idProcesseur.Substring(1, 1) + idCarteMere.Substring(0, 2) + idProcesseur.Substring(5, 2);
            part3 = idCarteMere.Substring(13, 1) + numeroSerie.Substring(8, 1) + idCarteMere.Substring(6, 1);
            part4 = idProcesseur.Substring(14, 2) + numeroSerie.Substring(5, 1) + idProcesseur.Substring(9, 2);
            part5 = idCarteMere.Substring(10, 2) + idProcesseur.Substring(3, 2) + numeroSerie.Substring(11, 1);
            part6 = idProcesseur.Substring(0, 1) + numeroSerie.Substring(2, 1) + idCarteMere.Substring(2, 1);
            part7 = numeroSerie.Substring(9, 2) + idProcesseur.Substring(7, 1) + idCarteMere.Substring(12, 1);
            part8 = idProcesseur.Substring(12, 2) + idCarteMere.Substring(3, 2) + numeroSerie.Substring(7, 1);
            part9 = idProcesseur.Substring(8, 1) + numeroSerie.Substring(3, 2) + idProcesseur.Substring(2, 1);
            part10 = idCarteMere.Substring(5, 1) + numeroSerie.Substring(6, 1) + idCarteMere.Substring(7, 2);
            return part1 + part2 + part3 + part4 + part5 + part6 + part7 + part8 + part9 + part10;
        }

        public string ActivateurVrai()
        {
            string numeroUnique = GetCodeUnique();
            string unique1 = numeroUnique.Substring(0, 10);
            string unique2 = numeroUnique.Substring(10, 8);
            string unique3 = numeroUnique.Substring(18, 8);
            string unique4 = numeroUnique.Substring(26, 8);
            string unique5 = numeroUnique.Substring(34, 8);
            string AnneeActu = AnneeActuel();

            string part1 = Part
                                (
                                    unique3.Substring(1, 1) + unique2.Substring(5, 1) + unique5.Substring(4, 1),
                                    AnneeActu.Substring(3, 1) + unique5.Substring(3, 1),
                                    unique4.Substring(7, 1) + unique1.Substring(3, 1) + unique1.Substring(9, 1)
                                );

            string part2 = Part
                                (
                                    unique5.Substring(1, 1) + unique3.Substring(7, 1),
                                    AnneeActu.Substring(0, 1),
                                    unique1.Substring(7, 1)
                                );

            string part3 = Part
                                (
                                    unique2.Substring(0, 1),
                                    unique4.Substring(3, 1) + unique3.Substring(6, 1),
                                    unique2.Substring(3, 1)
                                );

            string part4 = Part
                                (
                                    AnneeActu.Substring(1, 1),
                                    unique3.Substring(0, 1) + unique4.Substring(1, 1),
                                    unique5.Substring(6, 1)
                                );

            string part5 = Part
                                (
                                    unique5.Substring(5, 1) + unique1.Substring(0, 1) + unique3.Substring(4, 1) + unique3.Substring(5, 1),
                                    unique2.Substring(2, 1) + AnneeActu.Substring(1, 1) + unique1.Substring(5, 1) + unique5.Substring(7, 1),
                                    unique2.Substring(6, 1) + unique3.Substring(3, 1) + AnneeActu.Substring(2, 1) + unique3.Substring(4, 1)
                                );

            return $"{crypterMD5.GetMd5Hash(MD5.Create(), part1).Substring(0, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part1).Substring(5, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part1).Substring(10, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part1).Substring(15, 5).ToUpper()}\n" +
                $"{crypterMD5.GetMd5Hash(MD5.Create(), part2).Substring(0, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part2).Substring(5, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part2).Substring(10, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part2).Substring(15, 5).ToUpper()}\n" +
                $"{crypterMD5.GetMd5Hash(MD5.Create(), part3).Substring(0, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part3).Substring(5, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part3).Substring(10, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part3).Substring(15, 5).ToUpper()}\n" +
                $"{crypterMD5.GetMd5Hash(MD5.Create(), part4).Substring(0, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part4).Substring(5, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part4).Substring(10, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part4).Substring(15, 5).ToUpper()}\n" +
                $"{crypterMD5.GetMd5Hash(MD5.Create(), part5).Substring(0, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part5).Substring(5, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part5).Substring(10, 5).ToUpper()}-{crypterMD5.GetMd5Hash(MD5.Create(), part5).Substring(15, 5).ToUpper()}";
        }
    }
}
