//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {
        public Train(string name){ //Metodo constructor que ademas suma 1 a la variable instancias
            this.SetId(name);
            instancias++;
        }
        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
        private static int instancias = 0; //Variable de clase que cuenta la cnatidad de trenes creados
        public static int GetInstancias(){ //Metodos get y set de la variable instancias
            return Train.instancias;
        }
        public static void SetInstancias(int nueva){
            Train.instancias = nueva;
        }
        private string id; //Variable de instancia para identificar cada tren
        public string GetId(){ //Metodos get y set para la variable id
            return this.id;
        }
        public void SetId(string nuevaid){
            id = nuevaid;
        }
        
        ~Train(){ //Metodo destructor de la clase Train
            instancias--;
        }

        public override string ToString()
        {
            return "NO IMPLEMENTADO";
        }

        public override bool Equals(object obj)
        {
            return this.id == ((Train)obj).id;
        }
    }
}            
