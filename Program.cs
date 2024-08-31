namespace JuegosContruccion
{

    interface ICastillo
    {
        void Construir();
    }

    interface ITorre
    {
        void Construir();
    }

    interface IMuralla
    {
        void Construir();
    }

    class Castillo : ICastillo
    {
        public void Construir()
        {
            Console.WriteLine("Construcción del castillo en proceso.");
        }
    }

    class Torre : ITorre
    {
        public void Construir()
        {
            Console.WriteLine("Construcción de la torre en proceso.");
        }
    }

    class Muralla : IMuralla
    {
        public void Construir()
        {
            Console.WriteLine("Construcción de la muralla en proceso.");
        }
    }

    interface IEdificioFactory
    {
        ICastillo CrearCastillo();
        ITorre CrearTorre();
        IMuralla CrearMuralla();
    }

    class CastilloFactory : IEdificioFactory
    {
        public ICastillo CrearCastillo()
        {
            return new Castillo();
        }

        public ITorre CrearTorre()
        {
            return new Torre();
        }

        public IMuralla CrearMuralla()
        {
            return new Muralla();
        }
    }

    class TorreFactory : IEdificioFactory
    {
        public ICastillo CrearCastillo()
        {
            return new Castillo();
        }

        public ITorre CrearTorre()
        {
            return new Torre();
        }

        public IMuralla CrearMuralla()
        {
            return new Muralla();
        }
    }

    class MurallaFactory : IEdificioFactory
    {
        public ICastillo CrearCastillo()
        {
            return new Castillo();
        }

        public ITorre CrearTorre()
        {
            return new Torre();
        }

        public IMuralla CrearMuralla()
        {
            return new Muralla();
        }
    }

    class Program
    {
        static void Main()
        {
            IEdificioFactory factory = new CastilloFactory();
            ICastillo castillo = factory.CrearCastillo();
            ITorre torre = factory.CrearTorre();
            IMuralla muralla = factory.CrearMuralla();

            castillo.Construir();
            torre.Construir();
            muralla.Construir();
        }
    }
}