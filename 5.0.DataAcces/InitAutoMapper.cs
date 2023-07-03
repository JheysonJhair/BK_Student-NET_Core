using _0._0.DataTransfer.DTO;
using _5._0.DataAcces.Entity;
using AutoMapper;

namespace _5._0.DataAcces
{
    public static class InitAutoMapper
    {
        public static bool _initMapper = true;
        //codigo olor: Cambie la visibilidad de '_initMapper' o conviértala en 'const' o 'readonly'.
        //Haga que este campo sea "privado" y encapsularlo en una propiedad "pública".
        //Los campos no constantes no deben ser visibles
        public static IMapper mapper;
        //codigo olor: Cambie la visibilidad de 'mapper' o conviértala en 'const' o 'readonly'.
        //Haga que este campo sea "privado" y encapsularlo en una propiedad "pública".
        //Los campos no constantes no deben ser visibles

        public static void Start()
        {
            if (_initMapper)
            {
                var config = new MapperConfiguration(cfg =>
                {

                    cfg.CreateMap<Student, DtoStudent>().MaxDepth(7);

                    cfg.CreateMap<DtoStudent, Student>().MaxDepth(7);

                });
                mapper = config.CreateMapper();
                _initMapper = false;
            }
        }
    }
}
