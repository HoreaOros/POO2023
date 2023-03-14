// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
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
        if (isValid(zi, luna, an, ora, minut, secunda))
        {
            this.zi = zi;
            this.luna = luna;
            this.an = an;
            this.ora = ora;
            this.minut = minut;
            this.secunda = secunda;
        }
        else
            throw new ArgumentException("Invalid date");
    }

    private bool isValid(int zi, int luna, int an, int ora, int minut, int secunda)
    {
        if(ora <  0 || ora > 23) 
            return false;
        if (minut < 0 || minut > 59)
            return false;
        if (secunda < 0 || secunda > 59)
            return false;
        if (an < 0)
            return false;
        if (luna < 1 || luna > 12)
            return false;

        int[] zile = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (zi < 1)
            return false;
        if (luna == 2)
            if(IsLeapYear(an))
            {
                if(zi > zile[luna - 1] + 1)
                    return false;
            }
            else
            {
                 if (zi > zile[luna - 1])
                     return false;
            }
        else
            if (zi > zile[luna - 1])
                return false;
        
        return true;
    }

    public bool IsLeapYear(int an)
    {
        return ((an % 4 == 0) && (an % 100 != 0)) || (an % 400 == 0);
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

    public int Zi => zi;
    public int Luna
    { 
        get 
        {
            return luna;
        }
    }
    public int An => an;
    public int Ora => ora;
    public int Minut => minut;
    public int Secunda => secunda;



}