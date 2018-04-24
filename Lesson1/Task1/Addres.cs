using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Addres
    {
        //--- Создание полей класса
        private string index;
        private string countru;
        private string city;
        private string street;
        private string house;
        private string apartment;

        //--- Создание свойства для поля index
        public string Index
        {
            //--- Создание методов доступа для index
            set
            {
                index = "Post index: " + value;
            }

            get
            {
                return index;
            }
        }

        public string Countru
        {
            //--- Создание методов доступа для index
            set
            {
                countru = "Country: " + value;
            }

            get
            {
                return countru;
            }
        }

        public string City
        {
            //--- Создание методов доступа для index
            set
            {
                city = "City: " + value;
            }

            get
            {
                return city;
            }
        }

        public string Street
        {
            //--- Создание методов доступа для index
            set
            {
                street = "Street: " + value;
            }

            get
            {
                return street;
            }
        }

        public string House
        {
            //--- Создание методов доступа для index
            set
            {
                house = "House: " + value;
            }

            get
            {
                return house;
            }
        }

        public string Apartment
        {
            //--- Создание методов доступа для index
            set
            {
                apartment = "Apartment: " + value;
            }

            get
            {
                return apartment;
            }
        }

    }
}
