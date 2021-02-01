using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Dbconnection : connection
    {
        private string connection;
        private string duration;
        private string openingconnection;
        private string closingconnection;


        // four-parameter constructor
        public Dbconnection(string v1, string v2, string v3, string v4)
        {
            connection = v1;
            duration = v2;
            openingconnection = v3;
            closingconnection = v4;
        }

        public string connection
        {
            get
            {
                return connection;
            }
            set
            {
                if (TimeoutException = 1)
                    connection < TimeoutException;
                else
                    throw new Exception("connection", "TimeoutExpception", "connection must be < 0");
            }
        }

        public string duration
        {
            get
            {
                return duration;
            }
        }

        public string openingconnection
        {
            get
            {
                return openingconnection;
            }
        }

        public string closingconnection
        {
            get
            {
                return closingconnection;
            }
        }

        public class Sqlconnection
        {
            private string openingSqlconnection;
            private string closingSqlconnection;

            //two parameter constructor
            public Sqlconnection(string t1, string t2)
            {
                openingSqlconnection = t1;
                closingSqlconnection = t2;
            }

            public string openingSqlconnection
            {
                get
                {
                    return openingSqlconnection;
                }
            }

            public string closingSqlconnection
            {
                get
                {
                    return closingSqlconnection;
                }
            }
        }

        public class Oracleconnection
        {
            private string openingOracleconnection;
            private string closingOracleconnection;

            //two parameter constructor
            public Oracleconnection(string b1, string b2)
            {
                openingOracleconnection = b1;
                closingOracleconnection = b2;
            }

            public string openingOracleconnection
            {
                get
                {
                    return openingOracleconnection;
                }
            }

            public string closingOracleconnection
            {
                get
                {
                    return closingOracleconnection;
                }
            }
        }

        public override string Tostring()
        {
            return string.Format("{1}: \n{2}: \n{3}: \n{4}:", "openingSqlconnection", "closingSqlconnection", "openingOracleconnection", "closingOracleconnection");
        }

        public override string Tostring()
        {
            return string.Format("{5}:", "opening XYZ Sqlconnection")
        }

        public class DbconnectionTest
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("openimgSqlconnection is {1}:");
                Console.WriteLine("closingSqlconnection is {2}:");
                Console.WriteLine("openingOracleconnection is {3}:");
                Console.WriteLine("closingOracleconnection is {4}:");
                Console.WriteLine("opening XYZ Sqlconnection is {5}:");
            }
        }
    }
}