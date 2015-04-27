using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessPesa
{
    class Data
    {

        protected String customer_name;
        protected int transaction_id;
        protected int transaction_value;
        protected int  balance;
        protected String date;
        protected int customer_phone_no;
        protected String customer_id_type;
        protected int customer_id;
        protected String transaction_type;
        public Data(){
        
        }
        public Data(String cn,int fb) {
            this.customer_name = cn;
            this.balance = fb;


        
        
        
        }



    }
}
