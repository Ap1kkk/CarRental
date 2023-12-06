using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp1
{
    abstract public class Field
    {
        protected string name_field;
        protected string value;
        protected string field_type;

        abstract public string get_value(Firm firma);
        virtual public void set_value(string new_value) { value = new_value; }
        virtual public string get_type() { return field_type; }
    }

    class NameField :Field {
        public NameField() { name_field = "Название фирмы"; field_type = "string"; }
        public override string get_value(Firm firma)
        {
            return firma.Name;
        }
    }

    class RegionField : Field {
        public RegionField() { name_field = "Регион"; field_type = "string"; }
        public override string get_value(Firm firma)
        {
            return firma.Region;
        }
    }

    class TownField : Field {
        public TownField() { name_field = "Город"; field_type = "string"; }
        public override string get_value(Firm firma)
        {
            return firma.Town;
        }
    }

    class PostInxField : Field {

        public PostInxField() { name_field = "Индекс"; field_type = "string"; }
        public override string get_value(Firm firma)
        {
            return firma.PostInx;
        } 
    }

    class DateInField : Field {
        public DateInField() { name_field = "Дата ввода"; field_type = "date"; }
        public override string get_value(Firm firma)
        {
            return firma.DateIn;
        }
    }

    class DateBegField : Field {
        public DateBegField() { name_field = "Дата начала"; field_type = "date"; }
        public override string get_value(Firm firma)
        {
            return firma.DateIn;
        }
    }

    class WebField : Field {
        public WebField() { name_field = "Web"; field_type = "string"; }
        public override string get_value(Firm firma)
        {
            return firma.Web;
        }
    }

    class UsrField : Field {
        public UsrField() { name_field = "Описание"; field_type = "string"; }
        public override string get_value(Firm firma)
        {
            return firma.U;
        }
    }

    class CountContField : Field {
        public CountContField() { name_field = "Число контактов"; field_type = "int"; }
        public override string get_value(Firm firma)
        {
           return firma.GetContactsCount().ToString();
        }
    }

    class CountryField : Field {
        public CountryField() { name_field = "Страна"; field_type = "string"; }
        public override string get_value(Firm firma)
        {
            return firma.Country;
        }
    }
}
