using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchEngineId ;
            string query = textBox1.Text;
            string apiKey;
            /////////////google
            if (Google1.Checked)
            {
                searchEngineId = "007392548452894505490:fmymsjjmcoy";
                apiKey = "AIzaSyAsaDlDiQqnb2vf_LAD - EmxaL0RS3WXLxo";
                Excute1(searchEngineId, query, apiKey);
               
            }  
                
        /////////////yahoo
            if (Yahoo.Checked)
            {
                searchEngineId = "007392548452894505490:xmzzydkes0i";
                apiKey = "AIzaSyAgz71LEfDkh6nnm2U8zF5yQbqgKZvun2Y";
                Excute1(searchEngineId, query , apiKey);

                
            }  
   
            ///////////////////////AOL

            if (Aol.Checked)
            {
                searchEngineId = "007392548452894505490:dcovgeihdwi";
                apiKey = "AIzaSyBwxpgPfPf6Pb29QTYgbNtIhOav6TyQzLA";
                Excute1(searchEngineId, query, apiKey);
            }  
   

            ///////////////ask
            if (Ask.Checked)
            {
                searchEngineId = "007392548452894505490:llabmmxkof8";
                apiKey = "AIzaSyCK5P__ore4z2lQow2Pbfda8DlzsGHKp_A";
                Excute1(searchEngineId, query, apiKey);
            }  
          

            //    ////////////bing
            if (Bing.Checked)
            {
                searchEngineId = "007392548452894505490:y_17m_5mhva";
                apiKey = "AIzaSyDAvdiSQyoabxwleeXwu0jZBRv775GYWMU";
                Excute1(searchEngineId, query, apiKey);
            }  
}
        public void Excute1(string searchEngineId, string query, string apiKey)
{
    if (textBox1.SelectedText == string.Empty)
    {
     //   listBox1.Items.Clear();
       
        Google.Apis.Customsearch.v1.CustomsearchService customSearchService = new Google.Apis.Customsearch.v1.CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer() { ApiKey = apiKey });
        Google.Apis.Customsearch.v1.CseResource.ListRequest listRequest = customSearchService.Cse.List(query);
        listRequest.Cx = searchEngineId;
       //listRequest.Start = 100;   
        listRequest.Num = 10;
        
        Google.Apis.Customsearch.v1.Data.Search search = listRequest.Execute();
        foreach (var item in search.Items)
        {

            listBox1.Items.Add("Title : " + item.Title + Environment.NewLine + "Link : " + item.Link + Environment.NewLine + Environment.NewLine);
        }

    }
}
        private void button2_Click(object sender, EventArgs e)
        {
          //  listBox1.GetNextControl();
        }

        private void Google_CheckedChanged(object sender, EventArgs e)
        {
           
        }

       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
