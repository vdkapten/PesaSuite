using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;



namespace AccessPesa
{


    class Databasecon : Data
    {
        private SQLiteConnection sqlite;
        private String tablename = "null";
        //note the connection string needs to be edited for packaging
        private String conn = @"Data Source=C:\Users\CIU\Desktop\PESA SUITE\AccessPesa\AccessPesa\pesasuite.db";


        public Databasecon() 
        {
            sqlite = new SQLiteConnection(conn);
            //this class contructor

        }
        public void selectdata() {
            Console.Write("THIS IS COOL");
            using (SQLiteConnection con = sqlite)
            {
                con.Open();

                string stm = "SELECT *FROM mpesa LIMIT 5";

                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {

                        do
                        {
                            rdr.Read();
           //hapa chacha

                        } while (rdr.NextResult());
                    }
                }

                con.Close();
                //end of the f(*)
            }
        


        
        }
        public void Insertdata(String tablename, int transaction_id, String transaction_type, int transaction_value, String customer_name, int customer_phone_no, int customer_id, String customer_id_type,int balance)
        {
 
            this.customer_id = customer_id;
            this.balance = balance;
            this.customer_id_type = customer_id_type;
            this.customer_phone_no = customer_phone_no;
            this.transaction_id = transaction_id;
            this.transaction_value = transaction_value;
            this.transaction_type = transaction_type;
            this.customer_name = customer_name;
            this.tablename = tablename;
            this.date = DateTime.Now.ToString("d/M/yyyy");
            //important connection starts here
            if (tablename =="null") {

                MessageBox.Show("table name was not provided");
            
            }else {

          
            using (this.sqlite)
            {
                try
                {
                    
                    this.sqlite.Open();
                    if (this.sqlite.State == ConnectionState.Open)
                    {
                    
                        SQLiteCommand cmd = new SQLiteCommand(this.sqlite);
                        if (tablename == "mpesa")
                       cmd.CommandText = "INSERT INTO mpesa (customer_id,customer_name,customer_id_type,customer_phone_no,date,transaction_id, transaction_value,transaction_type,mpesabalance)  VALUES (@customer_id,@customer_name,@customer_id_type,@customer_phone_no,@date,@transaction_id, @transaction_value,@transaction_type,@mpesabalance)";
                       else if (tablename == "tigopesa") 
                       cmd.CommandText = "INSERT INTO tigopesa (customer_id,customer_name,customer_id_type,customer_phone_no,date,transaction_id, transaction_value,transaction_type,tigobalance)  VALUES (@customer_id,@customer_name,@customer_id_type,@customer_phone_no,@date,@transaction_id, @transaction_value,@transaction_type,@tigobalance)";
                        //more if statement for other tables here
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@customer_id", this.customer_id);
                            cmd.Parameters.AddWithValue("@customer_name", this.customer_name);
                            cmd.Parameters.AddWithValue("@customer_id_type", this.customer_id_type);
                            cmd.Parameters.AddWithValue("@customer_phone_no", this.customer_phone_no);
                            cmd.Parameters.AddWithValue("@date", this.date);
                            cmd.Parameters.AddWithValue("@transaction_id", this.transaction_id);
                            cmd.Parameters.AddWithValue("@transaction_value", this.transaction_value);
                            cmd.Parameters.AddWithValue("@transaction_type", this.transaction_type);

                        if(tablename=="mpesa")
                            cmd.Parameters.AddWithValue("@mpesabalance", this.balance);
                        else if (tablename == "tigopesa")
                            cmd.Parameters.AddWithValue("@tigobalance", this.balance);
                        //more if statement for other tables

                            cmd.ExecuteNonQuery();

                            this.sqlite.Close();
                        

                        //end
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
//important connection ends here

        }
    }

}
