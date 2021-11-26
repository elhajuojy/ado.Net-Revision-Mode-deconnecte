using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
namespace Ado.Net_RevsionNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection ctn = new SqlConnection(@"Data Source=ELHAJUOJY-LAPTO\MEHDI;Initial Catalog=db_firstLastName;Integrated Security=True");
        
        SqlDataAdapter da;
        DataSet ds;
        BindingSource Tbiding = new BindingSource();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            da.Fill(ds,"personne");
            textid.Text = ds.Tables["personne"].Rows[0][0].ToString();
            textFirstName.Text = ds.Tables["personne"].Rows[0][1].ToString();
            textLastName.Text= ds.Tables["personne"].Rows[0][2].ToString();

        }
        
        int pos=-1;
        int i;
        private void btnRecherche_Click(object sender, EventArgs e)
        {

           

            for ( i = 0; i < ds.Tables["personne"].Rows.Count; i++)
            {
                if(textid.Text==ds.Tables["personne"].Rows[i][0].ToString())
                {
                    pos = i;
                    break;
                }
            }
            textid.Text = ds.Tables["personne"].Rows[pos][0].ToString();
            textFirstName.Text = ds.Tables["personne"].Rows[pos][1].ToString();
            textLastName.Text = ds.Tables["personne"].Rows[pos][2].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from personne", ctn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "personne");

            Tbiding.DataSource = ds.Tables["personne"];
            textid.DataBindings.Add(new Binding("Text", Tbiding, "id"));
            textFirstName.DataBindings.Add(new Binding("Text", Tbiding, "firstName"));
            textLastName.DataBindings.Add(new Binding("Text", Tbiding, "lastName"));
        }

        private void btnShowInDgv_Click(object sender, EventArgs e)
        {
            this.dgv.Rows.Clear();
            dgv.DataSource = ds.Tables["personne"];

            //for (i = 0; i < ds.Tables["personne"].Rows.Count; i++)
            //{
            //    dgv.Rows.Add(ds.Tables["personne"].Rows[i][0]);
            //    dgv.Rows.Add(ds.Tables["personne"].Rows[i][1]);
            //    dgv.Rows.Add(ds.Tables["personne"].Rows[i][2]);

            //}

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ds.Tables["personne"].Rows.Add(textid.Text,textFirstName.Text,textLastName.Text);
            MessageBox.Show("Ajouter bien effected");
        }

        private void btnUpadte_Click(object sender, EventArgs e)
        {
            //enregistrer sur bd :
            SqlCommandBuilder bld = new SqlCommandBuilder(da);
            bld.GetUpdateCommand();
            da.Update(ds.Tables["personne"]);
           
            
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            for (i = 0; i < ds.Tables["personne"].Rows.Count; i++)
            {
                if (textid.Text == ds.Tables["personne"].Rows[i][0].ToString())
                {
                    pos = i;
                    break;
                }
                
            }
            ds.Tables["personne"].Rows[pos].Delete();

        }

        private void btnModifere_Click(object sender, EventArgs e)
        {
            for (i = 0; i < ds.Tables["personne"].Rows.Count; i++)
            {
                if (textid.Text == ds.Tables["personne"].Rows[i][0].ToString())
                {
                    pos = i;
                    break;
                }

            }
            ds.Tables["personne"].Rows[pos][1]=textFirstName.Text;
            ds.Tables["personne"].Rows[pos][2] = textLastName.Text;
            MessageBox.Show("modefication good");








        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //textid.Text = ds.Tables["personne"].Rows [0][0].ToString();
            //textFirstName.Text = ds.Tables["personne"].Rows [0][1].ToString();
            //textLastName.Text = ds.Tables["personne"].Rows[0][2].ToString();
            Tbiding.MoveFirst();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {

            //textid.Text = ds.Tables["personne"].Rows[ds.Tables["personne"].Rows.Count-1][0].ToString();
            //textFirstName.Text = ds.Tables["personne"].Rows[ds.Tables["personne"].Rows.Count-1][1].ToString();
            //textLastName.Text = ds.Tables["personne"].Rows[ds.Tables["personne"].Rows.Count-1][2].ToString();
            Tbiding.MoveLast();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            //for (i = 0; i < ds.Tables["personne"].Rows.Count; i++)
            //{
            //    if (textid.Text == ds.Tables["personne"].Rows[i][0].ToString())
            //    {
            //        pos = i;
            //        break;
            //    }

            //}
            //textid.Text = ds.Tables["personne"].Rows[pos+1][0].ToString();
            //textFirstName.Text = ds.Tables["personne"].Rows[pos+1][1].ToString();
            //textLastName.Text = ds.Tables["personne"].Rows[pos+1][2].ToString();
            Tbiding.MoveNext();

        }

        private void btnpervouis_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    for (i = 0; i < ds.Tables["personne"].Rows.Count; i++)
            //    {
            //        if (textid.Text == ds.Tables["personne"].Rows[i][0].ToString())
            //        {
            //            pos = i;
            //            break;
            //        }

            //    }
            //    textid.Text = ds.Tables["personne"].Rows[pos - 1][0].ToString();
            //    textFirstName.Text = ds.Tables["personne"].Rows[pos - 1][1].ToString();
            //    textLastName.Text = ds.Tables["personne"].Rows[pos - 1][2].ToString();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString(),"exception");
            //}

            Tbiding.MovePrevious();
            
        }
    }
}
