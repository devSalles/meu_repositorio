/*
 * Created by SharpDevelop.
 * User: Cruz
 * Date: 27/12/2024
 * Time: 22:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace polimorfismo
{
	public class imposto{
		
		//virtual metodo que será substituido
		//metodo vale transporte
		public virtual void valetransporte(double salario){
			Console.WriteLine("Esse e valor do vale transporte:{0}",(salario*0.3));
		}
		
		//virtual metodo que será substituido
		//metodo vale alimentação
		public virtual void valealimentacao(double salario){
			Console.WriteLine("Esse e valor do desconto padrão do vale alimentação:{0}",(salario*0.4));
		}
	}
	
	public class gerente:imposto{
		
		//ovrride nova implementação do metdodo
		public override void valealimentacao(double salario){
			Console.WriteLine("Esse e o desconto do vale alimentação do gerente {0}",(salario*0.4));

		}
		
		//ovrride nova implementação do metdodo
		public override void valetransporte(double salario){
			Console.WriteLine("Esse e o desconto do vale transporte do gerente {0}",(salario*0.3));
			Console.WriteLine("--------------------------------------------------------------------");
		}
	}
	
	public class estagiario:imposto{
		
		//ovrride nova implementação do metdodo
		public override void valetransporte(double salario){
			Console.WriteLine("Esse e o desconto do vale transporte do estagiario:{0}",(salario*0.3));
			Console.WriteLine("--------------------------------------------------------------------");
		}
	}
	
	public class balconista:imposto{
		
		//ovrride nova implementação do metdodo
		public override void valetransporte(double salario){
			Console.WriteLine("Esse e o desconto do vale transporte do balconista: {0}",(salario*0.3));
			Console.WriteLine("--------------------------------------------------------------------");
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{	
			//Classe gerente tem acesso a vale transporte e alimentação
			imposto objA=new gerente();
			objA.valealimentacao(7000);
			objA.valetransporte(7000);
			
			//Classe estagiario tem acesso a vale transporte
			imposto objB=new estagiario();
			objB.valetransporte(1750);
			
			//Classe balconista tem acesso a vale transporte
			imposto objC=new balconista();
			objC.valetransporte(2000);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}