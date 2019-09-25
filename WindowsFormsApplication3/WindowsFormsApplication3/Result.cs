using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Result
    {
        public int A,AOral,APractical,P,POral,PPractical,B,BOral,BPractical,C,COral,CPractical,Foren,FOral,FPractical,Patho,PathoOral,PathoPrac;
        public int Micro, MicroOral, MicroPrac, Phar, PharOral, PharPrac, Sur, SurOral,SurPrac,SurClinic,Medic, MedicOral,MedicPrac,MedicClinic,Gyna, GynaOral,GynaPrac,GynaqClinic;
      
        //*****************First Prof************************//
        public string checkedAnatomy(int A, int AOral, int APractical)
        {
           
            if(A<120)
            {
                return "Fail";
            }
            else if(AOral<90)
            {
                return "Fail";
            }
            else if(APractical<90)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        public string checkedPhysiology(int P, int POral, int PPractical)
        {

            if (P < 120)
            {
                return "Fail";
            }
            else if (POral < 60)
            {
                return "Fail";
            }
            else if (PPractical < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        public string checkedBiochemistry(int B, int BOral, int BPractical)
        {

            if (B < 120)
            {
                return "Fail";
            }
            else if (BOral < 60)
            {
                return "Fail";
            }
            else if (BPractical < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }

         

         //*****************Second Prof************************//
        public string checkedCommunity(int C, int COral, int CPractical)
        {

            if (C < 60)
            {
                return "Fail";
            }
            else if (COral < 60)
            {
                return "Fail";
            }
            else if (CPractical < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        public string checkedForensic(int Foren, int FOral, int FPractical)
        {

            if (Foren < 60)
            {
                return "Fail";
            }
            else if (FOral < 60)
            {
                return "Fail";
            }
            else if (FPractical < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
         //*****************Third Prof************************//
        public string checkedPathology(int Patho,int PathoOral,int PathoPrac)
        {

            if (Patho < 60)
            {
                return "Fail";
            }
            else if (PathoOral < 60)
            {
                return "Fail";
            }
            else if (PathoPrac < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        public string checkedMicroBio(int Micro, int MicroOral, int MicroPrac)
        {

            if (Micro < 60)
            {
                return "Fail";
            }
            else if (MicroOral < 60)
            {
                return "Fail";
            }
            else if (MicroPrac < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        public string checkedPharmaco(int Phar, int PharOral, int PharPrac)
        {

            if (Phar < 60)
            {
                return "Fail";
            }
            else if (PharOral < 60)
            {
                return "Fail";
            }
            else if (PharPrac < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        //*****************Final Prof************************//
        public string checkedSurgary(int Sur, int SurOral, int SurPrac,int SurClinic)
        {

            if (Sur < 120)
            {
                return "Fail";
            }
            else if (SurOral < 60)
            {
                return "Fail";
            }
            else if (SurPrac < 60)
            {
                return "Fail";
            }
            else if (SurClinic < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        public string checkedMedicine(int Medic, int MedicOral, int MedicPrac,int MedicClinic)
        {
            if (Medic < 120)
            {
                return "Fail";
            }
            else if (MedicOral < 60)
            {
                return "Fail";
            }
            else if (MedicPrac < 60)
            {
                return "Fail";
            }
            else if (MedicClinic < 60)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        public string checkedGynacology(int Gyna, int GynaOral, int GynaPrac, int GynaqClinic)
        {

            if (Gyna < 120)
            {
                return "Fail";
            }
            else if (GynaOral < 90)
            {
                return "Fail";
            }
            else if (GynaPrac < 60)
            {
                return "Fail";
            }
            else if (GynaqClinic < 30)
            {
                return "Fail";
            }
            else
            {
                return "Pass";
            }
        }
        
    }
}
