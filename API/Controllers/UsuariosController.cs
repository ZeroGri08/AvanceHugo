using System.Collections.Generic;
using Dominio;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Persistencia;

namespace API.Controllers
{

   // [Route("api/[controller]")]
    public class UsuariosController : Controller
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();
        private DataContext _data;
      public UsuariosController(DataContext data)
      {
          _data = data;
      }
/*
        public UsuariosController()
        {
            _usuarios.Add(new Usuario{ID = 1, Nombre="Hugo Gomez"});
            _usuarios.Add(new Usuario{ID = 2, Nombre="Lilian Gomez Marin"});
        }
*/
/*
        [HttpGet]
       public IEnumerable<Usuario> GetUsuario()
       {
           return _usuarios;
           
       } 
       */
        

         [HttpGet]
         [Route("api/[controller]")]
       public ActionResult<IEnumerable<Usuario>> GetUsuario()
       {

         var usuarios = _data.Usuarios.ToList();
         return Ok(usuarios);
          // return Ok(_usuarios);
           
       } 

         [HttpGet]
         [Route("api/[controller]/{id}")]
       public ActionResult<IEnumerable<Usuario>> GetUsuario(int id)
       {
        var usuario = _data.Usuarios.ToList().Find(u => u.ID == id);
          if(usuario!=null)
            return Ok(usuario);
         
          return NotFound();
          
          
        
        
         /*
           var usuario = _usuarios.FirstOrDefault(u=> u.ID == id);

            if(usuario!=null)
            return Ok(usuario);
           return NotFound();*/
           
       } 

 [HttpDelete]
         [Route("api/[controller]/{id}")]
       public ActionResult DeleteUsuario(int id){
         var usuario = new Usuario{ID = id};
         
        _data.Usuarios.Remove(usuario);
         _data.SaveChanges();
            return Ok();
       }

        [HttpPost]
        [Route("api/[controller]")]
       public ActionResult CreateUsuario([FromBody] Usuario usuario)
       {
         _data.Usuarios.Add(usuario);
         _data.SaveChanges();
        return Ok();
       }

       [HttpPut]
        [Route("api/[controller]/{id}")]
       public ActionResult UpdateUsuario(int id,[FromBody] Usuario usuario)
       {
        
_data.Usuarios.Update(usuario);
         _data.SaveChanges();
        return Ok();
       }
       
    }
}