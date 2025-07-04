using Application.Features.Mediator.Commands.TestimonialCommand;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.TestimonialHandlers.Write
{
	public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
	{
		private readonly IRepository<Testimonial> _repository;
		private readonly IMapper _mapper;
		public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
		{
			var result= await _repository.GetByIdAsync(request.TestimonialId);
			_mapper.Map(request, result);
			await _repository.UpdateAsync(result);
		}
	}
}
