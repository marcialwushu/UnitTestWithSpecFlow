using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace API.Test.Cenarios.Steps
{
    [Binding]
    public class APISteps
    {
        [Given(@"que a url do endpoint é '(.*)'")]
        [Obsolete]
        public void DadoQueAUrlDoEndpointE(string url)
        {
            ScenarioContext.Current["Endpoint"] = url;
        }
        
        [Given(@"o metodo http é '(.*)'")]
        [Obsolete]
        public void DadoOMetodoHttpE(string p0)
        {
            var metodo = Method.POST;

            switch (p0.ToUpper())
            {
                case "POST":
                    metodo = Method.POST;
                    break;
                case "GET":
                    metodo = Method.GET;
                    break;
                case "PUT":
                    metodo = Method.PUT;
                    break;
                case "DELETE":
                    metodo = Method.DELETE;
                    break;
                case "PATCH":
                    metodo = Method.PATCH;
                    break;
                default:
                    Assert.Fail("Método HTTP não esperado");
                    break;
            }

            ScenarioContext.Current["HttpMethod"] = metodo;
        }

        [When(@"chamar o serviço")]
        [Obsolete]
        public void QuandoChamarOServico()
        {
            var endpoint = (String)ScenarioContext.Current["Endpoint"];

            ExecutarRequest(endpoint);
        }

        #region Private
        [Obsolete]
        private void ExecutarRequest(string endpoint)
        {
            var url = endpoint;

            var request = new RestRequest();

            request.Method = (Method)ScenarioContext.Current["HttpMethod"];

            request.Parameters.Clear();
        }
        #endregion
    }
}
