using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
public partial class JIMMY : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtDateTime.Text = DateTime.Today.ToString("dd/MM/yyyy");
        
        OleDbConnection connStart = new OleDbConnection(GetConnectionString());
        string initialSql = "select SurchargesFuelLastUpdate from SurchargesFuelUpdateDate where SurchargePlanID in (SELECT SurchargePlanID FROM [CourierComplete].dbo.SurchargePlans WHERE Description LIKE '%Standard%')";
        OleDbDataAdapter myCommand = new OleDbDataAdapter(initialSql, connStart);
        connStart.Open();
        myCommand.SelectCommand.CommandType = CommandType.Text;
        myCommand.SelectCommand.ExecuteNonQuery();
        
        using (OleDbDataReader oReader = myCommand.SelectCommand.ExecuteReader())
        {
            while (oReader.Read())
            {
                if(oReader["SurchargesFuelLastUpdate"]!=DBNull.Value)
                txtDateTime2.Text = Convert.ToDateTime(oReader["SurchargesFuelLastUpdate"]).ToString("dd/MM/yyyy");
            }

            //myConnection.Close();
        }
        connStart.Close();      
    }
    protected void tb1_TextChanged(object sender, EventArgs e)
    {
        

    }
    public string GetConnectionString(){
        //sets the connection string from your web config file "ConnString" is the name of your Connection String
        return System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
}


    protected void magic_Click(object sender, EventArgs e)
    {
        
        OleDbConnection conn = new OleDbConnection(GetConnectionString());

        string sql = "exec [UpdateFuel] @Update=?,@Rate1=?,@Rate2=?,@Rate3=?,@Rate4=?,@Rate5=?,@Rate6=?,@Rate7=?,@Rate8=?;";

        try
        {
            bool radiovalue =false;
            bool isChecked = noupdate.Checked;
            if (isChecked)
                radiovalue =false;
            else
                radiovalue = true;

            OleDbDataAdapter myCommand = new OleDbDataAdapter(sql,conn);

            myCommand.SelectCommand.Parameters.Add("@p1", OleDbType.Boolean).Value = radiovalue;

            myCommand.SelectCommand.Parameters.Add("@p2", OleDbType.Single).Value = rate1.Text;
            myCommand.SelectCommand.Parameters.Add("@p3", OleDbType.Single).Value = rate2.Text;

            myCommand.SelectCommand.Parameters.Add("@p4", OleDbType.Single).Value = rate3.Text;
            myCommand.SelectCommand.Parameters.Add("@p5", OleDbType.Single).Value = rate4.Text;

            myCommand.SelectCommand.Parameters.Add("@p6", OleDbType.Single).Value =rate5.Text;
            myCommand.SelectCommand.Parameters.Add("@p7", OleDbType.Single).Value = rate6.Text;

            myCommand.SelectCommand.Parameters.Add("@p8", OleDbType.Single).Value =rate7.Text;
            myCommand.SelectCommand.Parameters.Add("@p9", OleDbType.Single).Value = rate8.Text;
           

            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            
            
            conn.Open();
            myCommand.SelectCommand.CommandType = CommandType.Text;
            myCommand.SelectCommand.ExecuteNonQuery();


            DataView source = new DataView(ds.Tables[0]);
            MyDataGrid.DataSource = source;
            MyDataGrid.DataBind();   
                

             
            
            
          
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Insert Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            conn.Close();
        }
        
    }
    protected void yesupdate_CheckedChanged(object sender, EventArgs e)
    {

        bool yesisChecked = yesupdate.Checked;
        
        if (yesisChecked)
        {
            magic.Text="Update";
        }

    }
    protected void noupdate_CheckedChanged(object sender, EventArgs e)
    {
        bool noisChecked = noupdate.Checked;
        if (noisChecked)
        {
            magic.Text = "Test";
        }

    }
    

}
