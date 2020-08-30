using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using UniSolution.Models;
using UniSolution.Models.Repositories;

namespace UniSolution.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class TanquesController : ApiController
    {
        // GET api/tanques
        public HttpResponseMessage GetAll()
        {
            try
            {
                var tanques = TanqueRepository.GetTanques();

                if (tanques.Count == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }

                return Request.CreateResponse(HttpStatusCode.OK, tanques);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        // GET api/tanques/{deposito}
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var tanque = TanqueRepository.GetTanque(id);

                if (tanque == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, tanque);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        // POST api/tanques
        public HttpResponseMessage Post([FromBody] Tanque tanque)
        {
            try
            {
                TanqueRepository.SaveTanque(tanque);
                var inserido = TanqueRepository.GetTanque(tanque.Deposito);

                if (inserido == null)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }

                return Request.CreateResponse(HttpStatusCode.Created, tanque);

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        // PUT api/tanques
        public HttpResponseMessage Put([FromBody] Tanque tanque)
        {
            try
            {
                Tanque localizado = TanqueRepository.GetTanque(tanque.Deposito);

                if (localizado == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                TanqueRepository.UpdateTanque(tanque);

                Tanque alterado = TanqueRepository.GetTanque(tanque.Deposito);

                if (alterado == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, alterado);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            
        }

        // DELETE api/tanques/{deposito}
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                var tanque = TanqueRepository.GetTanque(id);

                if (tanque == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                TanqueRepository.DeleteTanque(id);
                var deletado = TanqueRepository.GetTanque(id);

                if (deletado == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }

                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            
        }

    }
}
