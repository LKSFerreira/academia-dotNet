namespace desafio_instituicao_wf.components;

public class Botao : Button
{   
    // Inicializa um botcao com o Texto e a Posicao
    public Botao(string texto, int x, int y)
    {
        this.Text = texto;
        this.Location = new Point(x, y);
        this.Size = new Size(175, 70);
        this.AutoSize = true;
        this.BackColor = Color.FromArgb(217, 217, 217);
        this.ForeColor = Color.FromArgb(0, 0, 0);
        this.Font = new Font("Inter", 12, FontStyle.Bold);        
    }
}
