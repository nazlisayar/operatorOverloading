using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _11aralıkgörsel
{
    internal class prizma
    {
        private double boy, en, yukseklik;
        public void setboy(double a) { boy = a; }  
        public void seten(double b) { en = b; }
        public void setyukseklik (double c) { yukseklik = c; }
        public double gethacim()
        { return en*boy*yukseklik; }  
        public static prizma operator +(prizma x,prizma y)
        {
            prizma z = new prizma();
            z.en = x.en + y.en;
            z.boy=x.boy+y.boy;  
            z.yukseklik=x.yukseklik+y.yukseklik;
            return z;   
        }
        public static prizma operator -(prizma x, prizma y) 
        {
            prizma z=new prizma();
            z.en=x.en-y.en;
            z.boy = x.boy - y.boy;
            z.yukseklik=x.yukseklik-y.yukseklik;    
            return z;   
            


        }
        public static bool operator ==(prizma x,prizma y)
        {
            bool kosul;
            if((x.en==y.en)&&(x.boy==y.boy)&&(x.yukseklik==y.yukseklik))
            
                kosul=true; 
                else kosul=false;
            return kosul;
            
        }
        public static bool operator !=(prizma x, prizma y)
        {
            bool kosul = false;
            if((x.en!=y.en)&&(x.boy!=y.boy)&&(x.yukseklik!=y.yukseklik))    
                kosul=true;
            else kosul=false;
            return kosul;   

        }

















    }
}
