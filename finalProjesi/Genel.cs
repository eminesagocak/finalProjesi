using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace finalProjesi
{ 

public abstract class Genel
{
    public string Ad { get; set; }

    public string Mail {  get; set; }
    public abstract void BilgiGetir();
    public abstract string Listele();
}
}