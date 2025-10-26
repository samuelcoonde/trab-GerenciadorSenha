using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSenhaSingleton.Model
{
    public class GerenciadorSenha
    {
        private static GerenciadorSenha _instance;
        public List<int> listaSenhas = new List<int>();
        public int proxSenha = 1;

        private GerenciadorSenha() { }

        public static GerenciadorSenha Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GerenciadorSenha();
                }
                return _instance;
            }
        }

        public int GetNovaSenha()
        {
            listaSenhas.Add(proxSenha);
            return proxSenha++;
        }

        public List<int> GetListaSenhas()
        {
            return listaSenhas;
        }

        public void ChamarProximaSenha()
        {
            if (listaSenhas.Count == 0)
            {
                Console.WriteLine("Nenhuma senha na fila!");
                return;
            }

            int senha = listaSenhas[0];
            listaSenhas.RemoveAt(0);
            Console.WriteLine($"Chamando senha: {senha}");
        }

    }
}
