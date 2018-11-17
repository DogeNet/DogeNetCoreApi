using DogeNetCore.Controllers.lib.Controllers;
using DogeNetCore.Controllers.lib.Controllers.Clips.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogeNetCore.Controllers.lib.Controllers.Clips.Requests;

namespace DogeNetCore.Controllers.lib.implementations.Controllers
{
    public abstract class HttpGetCommand<TDataObject,TRequestObject, TResponseObject> :
        ICommand<TDataObject,TRequestObject, TResponseObject>
        where TDataObject : class
        where TRequestObject : BaseRequest
        where TResponseObject : BaseResponse
    {
        protected TResponseObject Response;

        protected HttpGetCommand(TResponseObject response)
        {
            Response = response;
        }

        public void HandleErrors(Exception e)
        {
            //TODO: Map error handling for get requests here
        }

        public abstract Task ExecuteAsync(TRequestObject requestObject);
        public abstract TResponseObject MapResponse(TDataObject dataObject);
        public abstract TResponseObject MapResponse(IEnumerable<TDataObject> dataObjects);
    }
}
