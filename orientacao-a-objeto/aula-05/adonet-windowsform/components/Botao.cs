namespace adonet_windowsform.components;

public class Botao : Button
{
    // Inicializa um botao com o texto e a posicao
    public Botao(string texto, int x, int y)
    {
        Text = texto;
        Location = new Point(x, y);
        this.Size = new Size(150, 50);
        // this.AutoSize = true;
        this.BackColor = Color.FromArgb(217, 217, 217);
        this.ForeColor = Color.FromArgb(0, 0, 0);
        this.Font = new Font("Inter", 12, FontStyle.Bold);
    }
}
