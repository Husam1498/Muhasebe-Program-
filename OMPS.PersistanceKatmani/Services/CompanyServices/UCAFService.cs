using AutoMapper;
using OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OMPS.ApplicationKatmanı.Services.CompanyServices;
using OMPS.DomainKatmani;
using OMPS.DomainKatmani.CompanyEnties;
using OMPS.DomainKatmani.Repository.UCAFRepos;
using OMPS.PersistanceKatmani.Context;


namespace OMPS.PersistanceKatmani.Services.CompanyServices
{
    public sealed class UCAFService : IUCAFServis
    {
        private readonly IUCAFCommandRepo _repository;
        private readonly IUCAFQueryRepo _queryRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _companyDbContext;

        public UCAFService(IUCAFCommandRepo ucafCommandRepository, IContextService contextService, IMapper mapper, IUnitOfWork unitOfWork, IUCAFQueryRepo query)
        {
            _repository = ucafCommandRepository;
            _contextService = contextService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _queryRepository = query;
        }

        public async Task CreateUCAFAsync(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            _companyDbContext=(CompanyDbContext) _contextService.CreateDbContextInstance(request.CompanyId) as CompanyDbContext;
            _repository.CreateDbContextInstance(_companyDbContext);
            _unitOfWork.CreateDbContextInstance(_companyDbContext);
            UCAF reques=_mapper.Map<UCAF>(request);
            await _repository.AddAsync(reques, cancellationToken);
           await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<UCAF> GetByCode( string code)
        {
            
            return await _queryRepository.GetFirstByExpression(u=> u.Code == code);
        }
    }
}
