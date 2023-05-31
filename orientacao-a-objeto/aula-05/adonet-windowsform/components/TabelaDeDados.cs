namespace adonet_windowsform.components;

public class TabelaDeDados : DataGridView
{
    public TabelaDeDados(int x, int y)
    {
        this.Location = new Point(x, y);
        this.Size = new Size(1440, 750);
        this.AutoSize = true;
        this.BackColor = Color.FromArgb(254, 254, 254);
        this.ForeColor = Color.FromArgb(0, 0, 0);
        this.Font = new Font("Regular", 8, FontStyle.Bold);
    }
}
