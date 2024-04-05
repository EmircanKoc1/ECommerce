using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Coupon;
using BusinessLogicLayer.CQRS.Commands.Responses.Coupon;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Coupon
{
    public class CreateCouponCommandHandler : IRequestHandler<CreateCouponCommandRequest, CreateCouponCommandResponse>
    {
        IMapper _mapper;
        ICouponService _couponService;
        IValidator<CouponDto> _validator;

        public CreateCouponCommandHandler(IMapper mapper, ICouponService couponService, IValidator<CouponDto> validator)
        {
            _mapper = mapper;
            _couponService = couponService;
            _validator = validator;
        }

        public async Task<CreateCouponCommandResponse> Handle(CreateCouponCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<CouponDto>(request);
            var validationReslt = await _validator.ValidateAsync(dto);

            if (!validationReslt.IsValid)
                return (null);

            var responseDto = await _couponService.AddAsync(dto);


            return _mapper.Map<CreateCouponCommandResponse>(responseDto);

        }
    }
}
