public class Banco{

    #region Atributos

        private Cliente Cliente1;
        private Cliente Cliente2;
        private Cliente Cliente3;

    #endregion

    #region Constructor 

        public Banco(){
            this.Cliente1 = new Cliente("Tobias");
            this.Cliente2 = new Cliente("Andrea");
            this.Cliente3 = new Cliente("Sofia")

        }

    #endregion

    #region Setters y Getters

        //Set
        public void SetCliente1(string cliente1){
            this.Cliente1 = cliente1;
        }
        public void SetCliente2(string cliente2){
            this.Cliente2 = cliente2;
        }
        public void SetCliente3(string cliente3){
            this.Cliente3 = cliente3;
        }

        //Get
        public string GetCliente1(){
            return this.Cliente1;
        }
        public string GetCliente2(){
            return this.Cliente2;
        }
        public string GetCliente3(){
            return this.Cliente3;
        }

    #region Metodos

        public void Operar(){
            this.Cliente1.Depositar(300);
            this.Cliente2.Depositar(500);
            this.Cliente3.Depositar(600);
            this.Cliente3.Extraer(100);
        }

        public void SaldosTotales()
        {
            int total = Cliente1.SaldoCliente() + Cliente2.SaldoCliente() + Cliente3.SaldoCliente();

            Console.WriteLine("El total de dinero en el banco es:" + total);
            cliente1.Resultados();
            cliente2.Resultados();
            cliente3.Resultados();
        }
    #endregion
}      