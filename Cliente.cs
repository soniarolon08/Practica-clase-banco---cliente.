public class Cliente{

    #region Atributos

        private string Nombre;
        private int Saldo;

    #endregion
    
    #region Constructor

        public Cliente(){
            this.Nombre = ""
            this.Saldo = 0;
        }
        public Cliente(string nombre, int saldo){
            this.Nombre = nombre;
            this.Saldo = saldo;
        }

    #endregion

    #region Setters y Getters

        //Set
        public void SetNombre(string nombre){
            this.Nombre = nombre;
        }
        public void SetSaldo(int saldo){
            this.Saldo = saldo;
        }

        //Get
        public string GetNombre(){
            return this.Nombre;
        }
        public int GetSaldo(){
            return this.Saldo;
        }

    #region Metodos

        public void Depositar(int saldo_disponible){
            Saldo = Saldo + saldo_disponible;
        }

        public void Extraer(int saldo_disponible){
            Saldo = Saldo - saldo_disponible;
        }

        public int SaldoCliente(){
            return Saldo
        }

        public void Resultados(){

        Console.WriteLine(nombre + " tiene depositado la suma de " + saldo);
        }
        
    #endregion
}