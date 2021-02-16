using System;
using System.Threading.Tasks;
using URLCounter.Dto;

namespace URLCounter
{
    public interface IRequestSender
    {
        Task<GetRequestDto> SendRequest(string fileName);
    }
}