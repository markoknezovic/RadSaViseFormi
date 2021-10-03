using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaVišeFormi
{
    public class Student
    {
        string ime;
        string prezime;
        string smjer;
        int brojIndexa;
        DateTime datumRodjenja;

        public class Student

        {


            private string ime;

            private string prezime;

            private string brojIndeksa;

            private string smjer;

            private DateTime datumRodjenja;
            public Student()

            {

            }
            public string Prezime

            {

                get
                {
                    return prezime;
                }
                set
                {
                    prezime = value;
                }

            }
            public string Prezime

            {
                get
                {
                    return prezime;
                }
                set
                {
                    prezime = value;
                }

            }
            public string Smjer

            {
                get
                {
                    return smjer;
                }

                set
                {
                    smjer = value;
                }

            }
            public override string ToString()

            {
                return ime + " " + prezime + " " +
                brojIndeksa + " " +
                datumRodjenja.ToShortDateString() + " " + smjer;
            }

        }
    }
    }
