using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ZP3_Animace
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			casovac.Stop();//zabranuje spusteni Timer1Tick
		}
		
		int cisloObrazku = 0;
		int otocka = 0; //int pro otoceni smeru animace
		
		void Button1Click(object sender, EventArgs e)
		{
			casovac.Start(); //spusti timer (Timer1Tick) po zmacknuti tlacitka
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			//prazdne
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			obrazekBox.Image = seznamObrazku.Images[cisloObrazku]; //Do obrazkoveho boxiku se nahraje obrazek ze seznamu. Poradi obrazku je v [] zavorkach.
			if (cisloObrazku < 4 && otocka == 0) {
				cisloObrazku ++;
				if (cisloObrazku == 4) {
					otocka = 1; //Kdyz dobehne animace na konec, prehodi se kontrolni int na 1 a aktivuje zpetny chod.
				}
			}else{
				cisloObrazku --;
				if (cisloObrazku == 0) {
					otocka = 0;
				}
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			casovac.Stop(); //ukonceni srandy
		}
	}
}
