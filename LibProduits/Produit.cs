using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibProduits
{
    public class Produit
    {
        private int _code;
        private string _libellé;
        private string _catégorie;
        private int _prixht;

        public int Code { get => _code; set => _code = value; }
        public string Libellé { get => _libellé; set => _libellé = value; }
        public string Catégorie { get => _catégorie; set => _catégorie = value; }
        public int Prixht { get => _prixht; set => _prixht = value; }


        public Produit(int code, string libellé, string catégorie, int prixht)
        {
            _code = code;
            _libellé = libellé;
            _catégorie = catégorie;
            _prixht = prixht;
        }
    }
}
