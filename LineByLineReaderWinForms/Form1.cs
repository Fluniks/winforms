using System;
using System.Windows.Forms;

namespace LineByLineReaderWinForms
{
    public partial class Form1 : Form
    {
        private int _i;

        private string[] _lines =
        {
            "Litwo! Ojczyzno moja! ty jesteś jak zdrowie:",
            "Ile cię trzeba cenić, ten tylko się dowie,",
            "Kto cię stracił. Dziś piękność twą w całej ozdobie",
            "Widzę i opisuję, bo tęsknię po tobie."
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void NextLineBtn_Click(object sender, EventArgs e)
        {
            if (_i >= _lines.Length) return;
            label1.Text = _lines[_i];
            _i++;
        }
    }
}