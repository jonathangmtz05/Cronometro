using System.Diagnostics;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        int hh, mm, ss ;
        string m, s,h;
        public Form1()
        {
            InitializeComponent();
        }

        public void reiniciar()
        {
            hh = 0;
            mm = 0;
            ss = 0;
            lblcronos.Text = "00:00:00";
            //tmrCronos.Stop();
        }
        private void tmrCronos_Tick(object sender, EventArgs e)
        {
            s = Convert.ToString(ss);
            m = Convert.ToString(mm);
            h = Convert.ToString(hh);
            if(mm<10)
            {
                m = Convert.ToString("0"+mm);
            }
            if(ss<10)
            {
                s = Convert.ToString("0"+ss);
            }
            if(hh<10)
            {
                h = Convert.ToString("0"+hh);
            }
            ss += 1;
            lblcronos.Text = Convert.ToString(h + ":" + m + ":" + s);

            //lblcronos.Text = Convert.ToString(hh + ":" + mm + ":" + ss);
            if (ss >= 59)
            {
                mm = +1;
                ss = 0;
                if(mm >= 59)
                {
                    hh += 1;
                    mm = 0;
                }
            }

        }

        private void butIniciar_Click(object sender, EventArgs e)
        {

            tmrCronos.Start();
        }

        private void butDetener_Click(object sender, EventArgs e)
        {
            tmrCronos.Stop();
        }

        private void butReinicio_Click(object sender, EventArgs e)
        {
            reiniciar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
