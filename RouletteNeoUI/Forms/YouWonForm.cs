using RouletteNeoLibrary;
using RouletteNeoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteNeoUI.Forms
{
    public partial class YouWonForm : Form
    {
        public YouWonForm(UserModel user, IRouletteSession rouletteSessionForm)
        {
            InitializeComponent();
        }
    }
}
