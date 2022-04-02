using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ControleEstoque1
{
    public class Model
    {
        //Usuario
        public void SetUsuario(DtoUsuario u)
        {
            Context db = new Context();

            db.usuario.Add(u);
            db.SaveChanges();
        }
        //Produto

        public void SetProduto(DtoProduto u)
        {
            Context db = new Context();

            db.produto.Add(u);
            db.SaveChanges();
        }





        //usuario
        public void EditUsuario(DtoUsuario u)
        {
            Context db = new Context();
            DtoUsuario e = db.usuario.FirstOrDefault(p => p.id == u.id);
            e.nome = u.nome;
            e.login = u.login;
            e.senha = u.senha;

            db.SaveChanges();
        }
        //produto
        public void EditProduto(DtoProduto u)
        {
            Context db = new Context();
            DtoProduto e = db.produto.FirstOrDefault(p => p.id == u.id);
            e.nome = u.nome;
            e.codigobarras = u.codigobarras;
            e.fabricante = u.fabricante;
            e.validade = u.validade;

            db.SaveChanges();
        }


        //USUARIO2
        public List<DtoUsuario2> ListUsuarios()
        {
            Context db = new Context();
            List<DtoUsuario2> result = (from a in db.usuario
                                        select new DtoUsuario2
                                        {
                                            id = a.id,
                                            nome = a.nome
                                        }).ToList();

            return new List<DtoUsuario2>(result);


        }
        //PRODUTO2
        public List<DtoProduto2> ListProduto()
        {
            Context db = new Context();
            List<DtoProduto2> result = (from a in db.produto
                                        select new DtoProduto2
                                        {
                                            id = a.id,
                                            codigobarras = a.codigobarras
                                        }).ToList();

            return new List<DtoProduto2>(result);


        }
        //USUARIO
        public DtoUsuario2 GetUsuarioId(int id)
        {
            Context db = new Context();
            var result = (from a in db.usuario
                          where a.id == id
                          select new DtoUsuario2
                          {
                              id = a.id,
                              nome = a.nome
                          }).FirstOrDefault();

            var result1 = db.usuario.Where(p => p.id == id).FirstOrDefault();

            return result;
        }
        //PRODUTO
        public DtoProduto2 GetProdutoId(int id)
        {
            Context db = new Context();
            var result = (from a in db.produto
                          where a.id == id
                          select new DtoProduto2
                          {
                              id = a.id,
                              codigobarras = a.codigobarras
                          }).FirstOrDefault();

            var result1 = db.produto.Where(p => p.id == id).FirstOrDefault();

            return result;
        }


        //USUARIO
        public void DeletarUsuario(int id)
        {
            Context db = new Context();
            DtoUsuario u = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(u);
            db.SaveChanges();
        }

        public void DeletarProduto(int id)
        {
            Context db = new Context();
            DtoProduto u = db.produto.FirstOrDefault(p => p.id == id);
            db.produto.Remove(u);
            db.SaveChanges();
        }

    }

}



   