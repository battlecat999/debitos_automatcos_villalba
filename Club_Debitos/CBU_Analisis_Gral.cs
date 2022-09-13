using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Debitos
{
    public class CBU_Analisis_Gral
    {
        string CBU_General;
        string CBU_Parte_Banco_Adhe;
        string CBU_Parte_Sucursal;
        string CBU_Parte_Tipo_Cuenta;
        string CBU_Cuenta_Adhe;
        string Cbu_Cuenta;

        public string CBU_General1 { get => CBU_General; set => CBU_General = value; }
        public string CBU_Parte_Sucursal1 { get => CBU_Parte_Sucursal; set => CBU_Parte_Sucursal = value; }
        public string CBU_Parte_Tipo_Cuenta1 { get => CBU_Parte_Tipo_Cuenta; set => CBU_Parte_Tipo_Cuenta = value; }
        public string CBU_Cuenta_Adhe1 { get => CBU_Cuenta_Adhe; set => CBU_Cuenta_Adhe = value; }
        public string Cbu_Cuenta1 { get => Cbu_Cuenta; set => Cbu_Cuenta = value; }
        public string CBU_Parte_Banco_Adhe1 { get => CBU_Parte_Banco_Adhe; set => CBU_Parte_Banco_Adhe = value; }

        public void Formato_CBU_Macro()
        {
            string tmp_cbu_sucursal = CBU_General1.Substring(0,3);
            if (tmp_cbu_sucursal == "285")
            {
                // cbu: 2850376740017060836315

                CBU_Parte_Banco_Adhe1 = CBU_General1.Substring(0, 3);//285

                CBU_Parte_Sucursal1 = '0'+ CBU_General1.Substring(4, 3);//5to digito, 4 numeros//0376

                CBU_Parte_Tipo_Cuenta1 = CBU_General1.Substring(8,1);// 4

                CBU_Cuenta_Adhe1 = CBU_General1.Substring(10, 11);//15 posiciones

                Cbu_Cuenta1 = CBU_Parte_Tipo_Cuenta1  + CBU_General1.Substring(4, 3) + CBU_Cuenta_Adhe1;
            }
            else//otros bancos
            {
                //0340145908145028808000
                CBU_Parte_Banco_Adhe1 = CBU_General1.Substring(0, 3);// tres primeros digitos

                CBU_Parte_Sucursal1 = CBU_General1.Substring(3, 4);// cuatro digitos

                CBU_Parte_Tipo_Cuenta1 = "0";

                CBU_Cuenta_Adhe1 = CBU_General1.Substring(8, 14).PadLeft(15, '0');//CBU_Parte_Sucursal1+ CBU_Parte_Tipo_Cuenta1  +"0" +CBU_General1.Substring(11, 11);
                Cbu_Cuenta1 =  CBU_Cuenta_Adhe1;
            }

            
        }
    }
}
