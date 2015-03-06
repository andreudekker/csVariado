using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;

namespace LayerEncriptation
{
    public class Encriptation
    {
        private String ClavePrincipal;
        public Encriptation()
        {
            ClavePrincipal = "SistemaInformatico";
        }

        public String Encriptar(String texto)
        {
            Byte[] ArrayClavePrincipal;

            Byte[] Arreglo_a_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

            ArrayClavePrincipal = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(ClavePrincipal));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = ArrayClavePrincipal;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            Byte[] ArrayResuelto = cTransform.TransformFinalBlock(Arreglo_a_a_Cifrar, 0, Arreglo_a_a_Cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(ArrayResuelto, 0, ArrayResuelto.Length);

        }

        public String Desencriptar(String textoEncriptado)
        {
            Byte[] ArrayClavePrincipal;

            Byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            ArrayClavePrincipal = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(ClavePrincipal));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = ArrayClavePrincipal;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform CtRANSFORM = tdes.CreateDecryptor();
            Byte[] ResultArray = CtRANSFORM.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
            tdes.Clear();

            return UTF8Encoding.UTF8.GetString(ResultArray);
        }
    }
}
