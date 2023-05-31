namespace adonet_windowsform.components;

public class CaixaDeTexto : TextBox
{
    public CaixaDeTexto(int x, int y)
    {
        Location = new Point(x, y);
        this.Size = new Size(500, 50);
        this.BackColor = Color.FromArgb(217, 217, 217);
        this.ForeColor = Color.FromArgb(0, 0, 0);
        this.Font = new Font("Inter", 12, FontStyle.Bold);
    }

}
