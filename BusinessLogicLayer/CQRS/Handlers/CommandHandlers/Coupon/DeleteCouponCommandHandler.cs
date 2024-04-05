using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Coupon;
using BusinessLogicLayer.CQRS.Commands.Responses.Coupon;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Coupon
{
    public class DeleteCouponCommandHandler : IRequestHandler<DeleteCouponCommandRequest, DeleteCouponCommandResponse>
    {
        IMapper _mapper;
        ICouponService _couponService;

        public DeleteCouponCommandHandler(IMapper mapper, ICouponService couponService)
        {
            _mapper = mapper;
            _couponService = couponService;
        }

        public Task<DeleteCouponCommandResponse> Handle(DeleteCouponCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<CouponDto>(request);
            var responseDto = _couponService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteCouponCommandResponse>(responseDto));


        }
    }
}
