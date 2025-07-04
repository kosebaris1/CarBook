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
	public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
	{
		private readonly IRepository<Testimonial> _repository;
		private readonly IMapper _mapper;

		public CreateTestimonialCommandHandler(IRepository<Testimonial> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
		{
			var result= _mapper.Map<Testimonial>(request);
			await _repository.CreateAsync(result);
		}
	}

}
