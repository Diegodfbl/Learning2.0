using DiagramadeClasse.Interface;
using System;


#region Anotação-Assinatura-de-Método
// nome do método e seus parâmentros(incluindo o tipo, a ordem, e a qdd de parâmetros 
//public int Soma(int x, int y)
//{
// return x + y;
//}
//Neste caso, a assinatura do método "Soma" é composta pelo seu nome "Soma" e pelos parâmetros "int x" e "int y"
#endregion

namespace DiagramadeClasse.Interface
{
    public interface Technology
    {
        string GetDescription();
    }
}

namespace DiagramadeClasse.Models
{
    public class Chip
    {
        public int ID { get; set; }
        public string Description { get; set; }
        private long calculator { get; set; }
        public void Increment(long add)
        {
            add++;
        }
        private void UpdateCalculator()
        {
           
        }
    }

    public class Dual
    {
        public int ID { get; set; }
        public string Description { get; set; }

        private void Synchronizeinfo()
        {
        
        }
    }

    public class Contract
    {
        public long ContractNumber { get; set; }
        public DateTime SignatureDate { get; set; }
        public bool Process()
        {
            return true;
        }
    }
}

namespace DiagramadeClasse.Regras
{
    public class Chip : Technology
    {
        DiagramadeClasse.Models.Chip chip = new DiagramadeClasse.Models.Chip { };
        public string GetDescription()
        {
            return chip.Description;
        }       
    }

    public class Dual : Technology
    {
        DiagramadeClasse.Models.Dual dual = new DiagramadeClasse.Models.Dual { };
        public string GetDescription()
        {
            return dual.Description;
        }
    }
    public class Contract : Dual
    {
        DiagramadeClasse.Models.Contract contract = new DiagramadeClasse.Models.Contract { };
        public bool Process()
        {
            return true;
        }
    }

}