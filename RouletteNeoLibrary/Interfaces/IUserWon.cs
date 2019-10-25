using RouletteNeoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteNeoLibrary
{
    public interface IUserWon
    {
        UserModel CurrentUser { get; set; }
        IRouletteSession rouletteSessionForm { get; set; }
        DialogResult ShowDialog();
    }
}
