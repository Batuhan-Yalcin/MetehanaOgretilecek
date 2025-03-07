using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RastgeleListBoxV2
{
    public partial class Form1 : Form
    {
        private List<int> _numbers;
        private Random _rand;
        public Form1()
        {
            InitializeComponent();
            _numbers = new List<int>();
            _rand = new Random();
        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
                        /*
                 SABİT OLARAK 0-20 ARASINDA 20 SAYI ÜRETMESİ İÇİN BU METHOD KULLANILIR.
                 _numbers.Clear(); 
                int randomCount = 20; 
                for (int i = 0; i < randomCount; i++)
                {
                    _numbers.Add(_rand.Next(0, 21));  
                }
                UpdateListBox();
                 */
            _numbers.Clear(); 
            int randomCount = _rand.Next(1, 21); 

            for (int i = 0; i < randomCount; i++)
            {  
                _numbers.Add(_rand.Next(0, 21));
            }

            UpdateListBox(); 
        }

        private void btnEnBuyuk_Click(object sender, EventArgs e)
        {
            if (_numbers.Any())
            {
                var maxNumber = _numbers.Max(); 
                listBox.Items.Clear(); 
                listBox.Items.Add(maxNumber); 
            }
        }

        private void btnEnKucuk_Click(object sender, EventArgs e)
        {
            if (_numbers.Any()) // Liste Boş değilse -> Any 
            {
                var minNumber = _numbers.Min();
                listBox.Items.Clear(); 
                listBox.Items.Add(minNumber);
            }
        }

        private void btnOnDanBuyuk_Click(object sender, EventArgs e)
        {
            var result = _numbers.Where(num => num > 10).ToList();
            UpdateListBox(result); 
        }

        private void btnOnDanKucuk_Click(object sender, EventArgs e)
        {
            var result = _numbers.Where(num => num < 10).ToList();
            UpdateListBox(result);
        }

        private void btnAdetBul_Click(object sender, EventArgs e)
        {
            txtAdet.Text = _numbers.Count.ToString();
        }


        private void UpdateListBox(IEnumerable<int> numbers = null)
        {
            listBox.Items.Clear(); 
            var itemsToDisplay = numbers ?? _numbers; 
            foreach (var number in itemsToDisplay)
            {
                listBox.Items.Add(number); 
            }
        }

    }
}
