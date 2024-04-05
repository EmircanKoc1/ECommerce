namespace BusinessLogicLayer.CQRS.Commands.Responses.Base
{
    public abstract class BaseProductImageCommandResponse : BaseCommandResponse
    {
        public string ImagePath { get; set; }
        public long? ProductId { get; set; }
    }
}
