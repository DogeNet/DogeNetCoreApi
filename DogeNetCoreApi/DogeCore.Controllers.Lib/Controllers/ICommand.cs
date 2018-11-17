using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogeNetCore.Controllers.lib.Controllers.Clips.Requests;
using DogeNetCore.Controllers.lib.Controllers.Clips.Responses;

namespace DogeNetCore.Controllers.lib.Controllers
{
    public interface ICommand<in TDataObject, in TRequestObject, out TResponseObject>
    where TDataObject: class
    where TRequestObject : BaseRequest
    where TResponseObject : BaseResponse
    {
        Task ExecuteAsync(TRequestObject requestObject);
        void HandleErrors(Exception e);
        TResponseObject MapResponse(TDataObject dataObject);
        TResponseObject MapResponse(IEnumerable<TDataObject> dataObjects);
    }
}
