using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Coupon;
using BusinessLogicLayer.CQRS.Commands.Responses.Coupon;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Coupon
{
    public class UpdateCouponCommandHandler : IRequestHandler<UpdateCouponCommandRequest, (UpdateCouponCommandResponse, UpdateCouponCommandResponse)>
    {
        IMapper _mapper;
        ICouponService _couponService;
        IValidator<CouponDto> _validator;

        public UpdateCouponCommandHandler(IMapper mapper, ICouponService couponService, IValidator<CouponDto> validator)
        {
            _mapper = mapper;
            _couponService = couponService;
            _validator = validator;
        }

        public async Task<(UpdateCouponCommandResponse, UpdateCouponCommandResponse)> Handle(UpdateCouponCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<CouponDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (validationResult.IsValid)
                return (null, null);

            var tupleDto = _couponService.Update(dto);
            var old = _mapper.Map<UpdateCouponCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateCouponCommandResponse>(tupleDto.Item2);

            return (old, @new);

        }
    }
}
