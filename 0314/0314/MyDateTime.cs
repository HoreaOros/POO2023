// See https://aka.ms/new-console-template for more information
using System.Text;

internal class MyDateTime
{
    private int zi;
    private int luna;
    private int an;
    private int ora;
    private int minut;
    private int secunda;

    public MyDateTime(int zi = 0, int luna = 0, int an = 0, int ora = 0, int minut = 0, int secunda = 0)
    {
        this.zi = zi;
        this.luna = luna;
        this.an = an;
        this.ora = ora;
        this.minut = minut;
        this.secunda = secunda;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.zi)
          .Append(".")
          .Append(string.Format("{0,2:D2}", this.luna))
          .Append(".")
          .Append(this.an)
          .Append(" ")
          .Append(this.ora)
          .Append(".")
          .Append(this.minut)
          .Append(".")
          .Append(this.secunda);
        return sb.ToString();
    }

}