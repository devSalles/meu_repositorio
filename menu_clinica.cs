/*
 * Created by SharpDevelop.
 * User: Aluno_Noite
 * Date: 28/05/2024
 * Time: 18:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Bem_estar
{
	struct Cliente{
		public string nome;
		public int CPF;
		public string gmail;
		public int ID;
		
		public Cliente(String nome, int CPF,string gmail, int ID){
			this.nome=nome;
			this.CPF=CPF;
			this.gmail=gmail;
			this.ID=ID;
		}
	}
	
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			//criação de variáveis
			string casoD,casoE;
			string endereço="",gmail="";
			string MP = "";
			string M2 = "",M3 = "",M4 ="",inicio;
			string nome="";
			float CPF;
			int cep=0,num=0,ID=0,num1=0;
		//Comando goto
		inicio:
			//Tela de Bem-Vindo exibido na tela
			Console.WriteLine("=========================================");
			Console.WriteLine("");
			Console.Write("                 BEM-VINDO                 ");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("=========================================");
			Console.Write("Pressione qualquer tecla para continuar . . . ");
			Console.ReadKey(true);
			Console.Clear();
			//Opções de Menu
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("=========================================");		
			Console.WriteLine(" A. Pré-Cadastro                     ");
			Console.WriteLine(" B. Cliente                          ");
			Console.WriteLine(" C. Médicos                          ");
			Console.WriteLine(" D. Remarcar conuslta                ");
			Console.WriteLine(" E. Cancelar Consulta                ");
			Console.WriteLine(" F. Fale Conosco                     ");
			Console.WriteLine(" G. Sobre                            ");
			Console.WriteLine(" H. Orçamento                        ");
			Console.WriteLine(" I. Dúvidas Frequentes               ");
			Console.WriteLine(" J. Sair                             ");
			Console.WriteLine("=========================================");
			MP = Console.ReadLine().ToUpper();
			Console.Clear();
			//Processamento dos menus e sub-menus
			switch (MP) {
				// caso A pré cadastro caso o cliente tenha se interessado pela clínica
				case "A":
				case "a":
					Console.WriteLine("Voce entrou na opção de Pré-Cadastro");
					Console.WriteLine("Caso voce tenha se interessado em nossa clínica faça seu pré-cadastro: ");
					Console.WriteLine("");
					Console.Write("Digite quantas pessoas você desejar realizar o pré cadastro: ");
					   num1=int.Parse(Console.ReadLine());
					for (int i = 1; i <= num1; i++){
					Console.WriteLine("Digite o seu nome completo para o pré cadastro: ");
					   nome=Console.ReadLine();
					Console.WriteLine("Digite seu CPF: ");
					   CPF=float.Parse(Console.ReadLine());
					Console.WriteLine("Digite seu e-mail");
					   gmail=Console.ReadLine();
					Console.WriteLine("Digite seu endereço: ");
					   endereço=Console.ReadLine();
					Console.WriteLine("Digite o número da sua casa: ");
					   num=int.Parse(Console.ReadLine());
					Console.WriteLine("Digite seu CEP: ");
					   cep=int.Parse(Console.ReadLine());
					Console.WriteLine("");
					Console.WriteLine("================================================");
					Console.WriteLine("Campos Obrigátorios Preenchido com sucesso !");
					Console.WriteLine("================================================");
					Console.WriteLine("");
					}
					//Pré-cadastro feito com sucesso 
					Console.WriteLine("");
					Console.WriteLine("=======================================================================================================================================");
					Console.WriteLine("Voce receberá um e-mail com o endereço da nossa clínica pedindo para ir até uma únidade no bairro Savassi para terminar o seu cadastro");
					Console.WriteLine("=======================================================================================================================================");
					Console.Clear();
					break;
			//caso B CLIENTE cadastrado apenas fazer login
				case "B":
			    case "b":
					Console.WriteLine("Você selecionou a opção CLIENTE.");
					Console.Write("Faça o Login no nosso site: ");
						Console.Write("Digite o nome cadastrado: ");
						   nome=Console.ReadLine();
						Console.Write("Digite o CPF cadastrado: ");
						   CPF=int.Parse(Console.ReadLine());
						Console.Write("Digite o e-mail cadastrado: ");
						   gmail=Console.ReadLine();
						Console.Write("Digite o ID cadastrado: ");
						   ID=int.Parse(Console.ReadLine());
						Console.Clear();
						Console.WriteLine("Login feito com sucesso");
				break;
				// caso C MÉDICOS seleção da consulta
				case "C":
				case "c":
      				Console.WriteLine("Você selecionou a opção MÉDICOS.");
            		Console.Write("");
             		Console.WriteLine("Digite qual especialidade você deseja consultar:  ");
             		Console.WriteLine("*Digite entre A e D*"); 
             		Console.WriteLine("");
            		Console.WriteLine("A - Geriatra - Doutora Ana Clara - 13:30h - terça-feira - (25/08/2024)");
            		Console.WriteLine("B - Cardiologísta - Doutor Pedro - 14:00h - sexta-feira - (29/08/2024)");
            		Console.WriteLine("C - Pediatra - Doutor Bernardo - 09:00h - segunda-feira - (01/09/2024)");
            		Console.WriteLine("D - Clínico Geral - Doutora Angela - 11:00h - quinta-feira - (04/09/2024)");
            		M2 = Console.ReadLine().ToUpper();
            		   //SubMenu caso C
            		   switch(M2){
            		   	   //Opção de marcar consulta selecionada
            		   	   case "A":
            		   	   case "a":
            				   Console.WriteLine("Geriatra - Doutora Ana Clara - 13:30h - terça feira - (25/08/2024)");
            				   Console.WriteLine("Sua consulta foi marcada !");
            				   break;
            			   //Opção de marcar consulta selecionada
            			   case "B":
            			   case "b":
            				   Console.WriteLine("Cardiologísta - Doutor Pedro - 14:00h - sexta feira - (29/08/2024)");
            				   Console.WriteLine("Sua consulta foi marcada !");
            				   break;
            			   //Opção de marcar consulta selecionada
            			   case "C":
            			   case "c":
            				   Console.WriteLine("Pediatría - Doutor Bernardo - 09:00h - Segunda Feira- (01/09/2024)");
            				   Console.WriteLine("Sua consulta foi marcada !");
            				   break;
            			   //Opção de marcar consulta selecionada
            			   case "D":
            			   case "d":
            				   Console.WriteLine("Clínico Geral - Doutora Angela - 11:00h - Quinta Feira - (04/09/2024)");
            				   Console.WriteLine("Sua consulta foi marcada !");
            				   break;
            			   //outra opção digitada pelo usuário
            			   default:
            				   Console.WriteLine("Voce selecionou alguma opção errda");
            				   break;
            		  
            		  }
            		break;
				
            	//caso D Remarcar Consulta
                case"D":
				Console.WriteLine("Voce clicou na opção Remarcar Consulta");
				Console.WriteLine("Você deseja Remarcar a consulta ? [s/n]");	
				Console.WriteLine("*Digite apenas s ou n*");
				casoD= Console.ReadLine().ToUpper();
				if(casoD=="s"||casoD=="S"){
					Console.WriteLine("Digite apenas Letras");
					Console.WriteLine("A - Geriatra - Doutora Ana Clara - 07:30h - Quarta-feira- (27/09/2024)");
				    Console.WriteLine("B - Geriatra - Doutora Júlia - 14:50h - Sexta-feira- (29/09/2024)");
				    Console.WriteLine("C - Pediatra- Doutora Tabita - 12:20h - Segunda-feira- (01/10/2024)");
				    Console.WriteLine("D - Pediatra - Doutora Tabita - 16:00h - Terça-feira- (02/10/2024)"); 
				    Console.WriteLine("E- Cardiologísta - Doutor Anderson - 15:00h - Sexta-feira - (29/08/2024)");
				    Console.WriteLine("F- Cardiologísta - Doutor Anderson - 10:00h - Quarta-feira - (04/09/2024)");
				    Console.WriteLine("G- Clínico Geral- Doutora fátima - 15:00h - Quarta-feira - (04/09/2024)");
				    Console.WriteLine("H- Clínico Geral- Doutora fátima - 16:00h - Quinta-feira - (05/09/2024)");
				    Console.WriteLine("I- Cardiologísta - Doutora Angelina - 13:00h - Segunda-Feira - (09/10/2024)");
				    Console.WriteLine("J- Cardiologísta - Doutora Angelina - 15:00h - Terça-Feira - (10/10/2024)");
				    casoD= Console.ReadLine().ToUpper();
				    casoD=casoD.ToUpper();
				      switch(casoD){
						//Opção de remarcar consulta selecionada
				    	case"A":
						case"a":
				           Console.WriteLine("A - Geriatra - Doutora Ana Clara - 07:30h - Quarta-feira- (27/09/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"B":
				        case"b":
				           Console.WriteLine("B - Geriatra - Doutora Júlia - 14:50h - Sexta-feira- (29/09/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"C":
				        case"c":
				           Console.WriteLine("C - Pediatra- Doutora Tabita - 12:20h - Segunda-feira- (01/10/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"D":
				        case"d":
				           Console.WriteLine("D - Pediatra - Doutora Tabita - 16:00h - Terça-feira- (02/10/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"E":
				        case"e":
				           Console.WriteLine("E- Cardiologísta - Doutor Anderson - 15:00h - Sexta-feira - (29/08/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"F":
				        case"f":
				           Console.WriteLine("F- Cardiologísta - Doutor Anderson - 10:00h - Quarta-feira - (04/09/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"G":
				        case"g":
				           Console.WriteLine("G- Clínico Geral- Doutora Fátima - 15:00h - Quarta-feira - (04/09/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"H":
				        case"h":
				           Console.WriteLine("H- Clínico Geral- Doutora Fátima - 16:00h - Quinta-feira - (05/09/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"I":
				        case"i":
				           Console.WriteLine("I- Cardiologísta - Doutora Angelina - 13:00h - Segunda-Feira - (09/10/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Opção de remarcar consulta selecionada
				        case"J":
				        case"j":
				           Console.WriteLine("J- Cardiologísta - Doutora Angelina - 15:00h - Terça-Feira - (10/10/2024)");
				           Console.WriteLine("Sua consulta foi remarcada com sucesso !");
				        break;
				        //Outra opção digitada
					 default:
						Console.WriteLine("Você digitou algo de errado ");
						break;
				    }
				}
				break;
				// caso E Cancelar a Consulta
            	case "E":
				case "e":
            	Console.WriteLine("=======================================");
            	Console.WriteLine("|Voce deseja Cancelar a Consulta ?[s/n]|");
            	Console.WriteLine("=======================================");
				casoE=Console.ReadLine();
            	Console.WriteLine("*Digite apenas s ou n*");
            	//comando goto para voltar para o início
            	if(casoE=="S"||casoE=="s"){
					Console.WriteLine("Olhe no nosso site o cancelamento da consulta: BemEstar.com.mg.br");
					goto inicio;
            	}
            	break;
            	
				//caso F Fale Conosco contatos da clínica
				case "F":
				case "f":
            		Console.WriteLine("Você selecionou a opção Fale Conosco.");
            		Console.WriteLine("");
            		Console.Write("Esses são os meios de contato do Atendimento Online :");
            		Console.WriteLine("");
            		Console.WriteLine("=======================================================================================");
            		Console.WriteLine("Número de telefone para contato: (31)9876-5432");
            		Console.WriteLine("Gmail para contato: 	ClínicaBemEstar@gmail.com");
            		Console.WriteLine("Ou então entre no nosso site: BemEstar.com.mg.br");
            		Console.WriteLine("=======================================================================================");
            		Console.WriteLine("");
            		Console.WriteLine("=======================================================================================");
            		Console.WriteLine("Segunda Opinião Médica:");
            		Console.WriteLine("Envie seus exames ou relátorios médicos ao e-mail da clínica para uma segunda opinião");
            		Console.WriteLine("E-mail para contato: Clínicasegundaopinião@gmail.com");
            		Console.WriteLine("=======================================================================================");
            		Console.WriteLine("");
            		Console.WriteLine("=========================================================================================");
            		Console.WriteLine("Se deseja marcar uma Consulta Virtual entre no nosso site: BemEstar.com.mg.br");
            		Console.WriteLine("=========================================================================================");
            		Console.WriteLine("");
            		Console.WriteLine("===================================================================================================================");
            		Console.WriteLine("Se precisar de alguma Educação ou Orientação de Saúde tire dúvidas com nossos médicos no site: BemEstar.com.mg.br");
            		Console.WriteLine("===================================================================================================================");
            		Console.WriteLine("");
            		Console.WriteLine("==================================================================");
            		Console.WriteLine("Se precisar enviar algum exame envie para nosso site ou no Gmail:");
            		Console.WriteLine("Nosso site: BemEstar.com.mg.br");
            		Console.WriteLine("Nosso Gmail: ClínicaBemEstar@gmail.com");
            		Console.WriteLine("==================================================================");
            		Console.WriteLine("");
            		Console.WriteLine("=========================================================================================");
            		Console.WriteLine("Se tiver alguma crítica sobre nossa clínica manda ela pelo e-mail ou pelo nosso whatsApp");
            		Console.WriteLine("Nosso número:(31)9876-5432");
            		Console.WriteLine("Nosso e-mail:ClínicaBemEstar@gmail.com");
            		Console.WriteLine("=========================================================================================");
            		break;

            	//caso G Sobre regálias que a clínica apresenta
				case "G":
            	case "g":
            		Console.WriteLine("Sobre nossa clínica:");
            		Console.WriteLine("");
            		Console.WriteLine("=============================================================================================================================================================================================================================================");
            		Console.WriteLine("Clínica Saúde e Bem Estar, a clinica e um Coworking especialiado em profissionais de diversas áreas da saúde que busca surpreender seus pacientes com consúltorios de alto nível, sendo uma clinica altamente tecnologica com ótima localização é de fácil acesso.");
            		Console.WriteLine("=============================================================================================================================================================================================================================================");            		Console.WriteLine("");
            		Console.WriteLine("=============================================================================================================================================================================================================================================");
            		Console.WriteLine("Além disso, oferecemos um serviço de estacionamento gratuito dentro do próprio prédio para clientes da Clinica e desconto de 50% para pacientes, tammbém conseguindo acessar os seus dados de qualquer lugar, podendo baixo-lo via PDF ou Documento, além de aceitar diversos convênios como IPSM, HapVida, Amil, SulAmerica, Abertta Saúde, dentre outros, e por fim conseguindo remarcar uma consulta com uma atendente no nosso numero de telefone ou whatsapp");
            		Console.WriteLine("=============================================================================================================================================================================================================================================");
            		break;
            	//Caso H Orçamentos da clínica
                case "H":
            	case "h":
            	Console.WriteLine("Orçamentos");
				Console.WriteLine("Faça aqui seu orçamento selecione uma opção");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("   A - Plano Individual Mensal-R$250,00");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("   B - Plano Individual Anual-R$200,00");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("   C - Plano Família Anual-R$280,00");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("   D - Plano Família Mensal-R$250,00");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("   E - Consulta-R$380,00");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("   F - Exames de Imagem-R$300,00");
				Console.WriteLine("|=======================================|");
				Console.WriteLine("");
				Console.WriteLine("|=============================================|");
				Console.WriteLine("   G - Check-ups e Pacotes de Exames-R$850,00   " );
				Console.WriteLine("|=============================================|");
				M3 = Console.ReadLine().ToUpper();
				M3=M3.ToUpper();
				Console.Clear();
				//SubMneu caso H Orçamentos
				   switch(M3){
					
					   case "A":
						  	//Plano selecionado pelo usuário
						    Console.WriteLine("=================================================");
      						 Console.WriteLine("Você escolheu Plano Individual Mensal-R$230,00");
					   		Console.WriteLine("=================================================");
					   		Console.WriteLine("");
					   		Console.WriteLine("O que ele oferece: ");
					   		Console.WriteLine("==========================================================================================================================================");
					   		Console.WriteLine("Consultas médicas ilimitadas, Exames médicos completos, Atendimento personalizado, Atendimento 24 horas, Serviços adicionais de bem-estar");
					   		Console.WriteLine("==========================================================================================================================================");
					   		Console.WriteLine("Deseja esse plano ?[s/n]");
					   		inicio=Console.ReadLine();
					   		Console.Clear();
					   		//Comando goto
					   		if(inicio=="s"||inicio=="S"){
					   			Console.WriteLine("Plano slecionado com sucesso");
					   		}else if (inicio=="n"||inicio=="N") {
					   			  goto inicio;
					   			}
					   break;
					   //Plano selecionado pelo usuário
					   case "B":
						   Console.WriteLine("===============================================");
      					    Console.WriteLine("Você escolheu Plano Individual Anual-R$340,00");
      				   	   Console.WriteLine("===============================================");
      				   	   Console.WriteLine("");
      				   	   Console.WriteLine("O que ele oferece: ");
      				   	   Console.WriteLine("==============================================================================================================================================================================================================");
      				   	   Console.WriteLine("Pacotes de saúde executiva, Programas de gerenciamento de doenças crônicas, Acesso a tratamentos especializados, Programas de desintoxicação e rejuvenescimento, Acesso a medicamentos e suplementos premium");
      				   	   Console.WriteLine("==============================================================================================================================================================================================================");
      				   	   Console.WriteLine("Deseja esse plano ?[s/n]");
					   		inicio=Console.ReadLine();
					   		Console.Clear();
					   		//Comando goto
					   		if(inicio=="s"||inicio=="S"){
					   			Console.WriteLine("Plano slecionado com sucesso");
					   		}else if (inicio=="n"||inicio=="N") {
					   			  goto inicio;
					   			}
      				   break;
      				   //Plano selecionado pelo usuário
					   case "C":
						  Console.WriteLine("==============================================="); 
      				         Console.WriteLine("Você escolheu Plano Família Anual-R$280,00");
					   	  Console.WriteLine("==============================================="); 
      				   	  Console.WriteLine("");
      				   	  Console.WriteLine("O que ele oferece: ");
      				   	  Console.WriteLine("==============================================================================================================================================================================================================================================================================");
      				   	  Console.WriteLine("Coordenação de cuidados familiares contínuos, Coordenação de cuidados familiares contínuos, Serviços adicionais de bem-estar familiar, Consultas médicas ilimitadas para todos os membros da família, Exames médicos abrangentes, Serviços de concierge médico para a família");
      				      Console.WriteLine("==============================================================================================================================================================================================================================================================================");
      				      Console.WriteLine("Deseja esse plano ?[s/n]");
					   		inicio=Console.ReadLine();
					        Console.Clear();
					   		//Comando goto para voltar para o início do menu
					        if(inicio=="s"||inicio=="S"){
					   			Console.WriteLine("Plano slecionado com sucesso");
					   		}else if (inicio=="n"||inicio=="N") {
					   			  goto inicio;
					   			}
      				   	break;
					   case "D":
      				   	//Plano selecionado pelo usuário
						  Console.WriteLine("===============================================");    
      				        Console.WriteLine("Você escolheu Plano Família Mensal-R$250,00");
				       	  Console.WriteLine("==============================================="); 
				       	  Console.WriteLine("");
				       	  Console.WriteLine("O que ele oferece: ");
				       	  Console.WriteLine("==============================================================================================================================================================================================================");
				       	  Console.WriteLine("Serviços de oftalmologia e cuidados com a visão, Suporte em saúde sexual e reprodutiva, Avaliação da saúde da terceira idade, Serviços de fisioterapia e reabilitação, Monitoramento da saúde cardiovascular");
				          Console.WriteLine("==============================================================================================================================================================================================================");
				          Console.WriteLine("Deseja esse plano ?[s/n]");
					   	  inicio=Console.ReadLine();
					   	  Console.Clear();
					   	  //Comando goto para voltar para o início
					   	  if(inicio=="s"||inicio=="S"){
					   			Console.WriteLine("Plano slecionado com sucesso");
					   		}else if (inicio=="n"||inicio=="N") {
					   			  goto inicio;
					   			}
				       break;
				       //Plano selecionado pelo usuário
					   case "E":
						   Console.WriteLine("==============================================="); 
      				         Console.WriteLine("Consulta-R$380,00");
      				       Console.WriteLine("===============================================");
					   	   Console.WriteLine("Deseja esse plano ?[s/n]");
					   	   inicio=Console.ReadLine();
					   	   Console.Clear();
					   	   //Comando goto para voltar para o início
					   	   if(inicio=="s"||inicio=="S"){
					   	      Console.WriteLine("Plano slecionado com sucesso");
					   		}else if (inicio=="n"||inicio=="N") {
					   			  goto inicio;
					   			}
					   break;
					   //Plano selecionado pelo usuário
					   case "F":
						   Console.WriteLine("==============================================="); 
					          Console.WriteLine("Exame de imagens-R$300,00");
						   Console.WriteLine("==============================================="); 				   
					   	   Console.WriteLine("");
					   	   Console.WriteLine("O que ele oferece: ");
					   	   Console.WriteLine("========================================================================================================================================================================================================================");
					   	   Console.WriteLine("Exames contrastados, Acesso a tecnologias avançadas, Relatórios detalhados e interpretação por especialistas, Radiografia convencional, Mamografia digital, Ressonância magnética (RM), Tomografia computadorizada (TC)");
					       Console.WriteLine("========================================================================================================================================================================================================================");
					       Console.WriteLine("Deseja esse plano ?[s/n]");
					   	   inicio=Console.ReadLine();
					   	   Console.Clear();
					   	   //Comando goto para voltar para o inicio
					   	   if(inicio=="s"||inicio=="S"){
					   	      Console.WriteLine("Plano slecionado com sucesso");
					   		}else if (inicio=="n"||inicio=="N") {
					   			  goto inicio;
					   			}
					   break;
					   //Plano selecionado pelo usuário
					   case "G":
					      Console.WriteLine("|=============================================|");  
					         Console.WriteLine("Check-Ups e Pacotes de Exames-R$850,00");
					      Console.WriteLine("|=============================================|"); 
					      Console.WriteLine("");
					      Console.WriteLine("O que ele oferece: ");
					      Console.WriteLine("|============================================================================================================================================================================|");
					      Console.WriteLine("Relatório de saúde personalizado, Exames de densitometria óssea, Exames de rastreamento de câncer, Exames de imagem, Exames de sangue, Check-up abrangente, Consultas médicas");
					      Console.WriteLine("|============================================================================================================================================================================|");
					      Console.WriteLine("Deseja esse plano ?[s/n]");
					   	  inicio=Console.ReadLine();
					   	  Console.Clear();
					   	  //Comando goto para voltar para o início
					   	  if(inicio=="s"||inicio=="S"){
					   	     Console.WriteLine("Plano slecionado com sucesso");
					   		}else if (inicio=="n"||inicio=="N") {
					   			  goto inicio;
					   			}
					   break;
				  //Outra opção digitada
				  default:
				   Console.WriteLine("Você digitou alguma opção errada!");
            	break;    
				}
				break;    
				//Caso I Dúvidas Frequentes (populares)
			    case "I":
				Console.WriteLine("Dúvidas Frequenstes");
				Console.WriteLine("Digite uma opção entre A e E para saber a resposta");
				Console.WriteLine("A - Como lidar com alergias alimentares e intolerâncias?");
				Console.WriteLine("B - Quais são os procedimentos de primeiros socorros para situações de emergência, como parada cardíaca, engasgo, etc.?");
				Console.WriteLine("C - Quais são os sinais de problemas de saúde mental, como ansiedade, depressão e estresse?");
				Console.WriteLine("D - Onde procurar ajuda e tratamento para questões relacionadas à saúde mental?");
				Console.WriteLine("E - Como tratar a Febre");
				M4 = Console.ReadLine().ToUpper();
				M4=M4.ToUpper();
				Console.Clear();
    				//SubMenu caso I
			    	switch(M4){
    				   //Opção selecionado pelo usuário
				  	   case "A":
					  	  Console.WriteLine("====================================================================================================================================================================================================================");				   	     
				   	      Console.WriteLine("lidar com alergias alimentares e intolerâncias exige uma abordagem abrangente que envolve identificação precisa, prevenção, preparação para emergências e educação contínua. Com cuidado, atenção e apoio adequados");
				   	   	  Console.WriteLine("====================================================================================================================================================================================================================");				   	     
				   	   break;
				   	   //Opção selecionado pelo usuário
				       case "B":
				   	   	  Console.WriteLine("===================================================================================================================");   
				   	      Console.WriteLine("Na parada cardíaca, é essencial iniciar imediatamente a RCP (Ressuscitação Cardiopulmonar)");
						  Console.WriteLine("===================================================================================================================");				   	     
				   	      Console.WriteLine("");
				   	      Console.WriteLine("==================================================================================================================================================");				   	     
				   	      Console.WriteLine("Para engasgos, a manobra de Heimlich é a ação primária, realizada pressionando firmemente o abdômen da vítima para desalojar o objeto obstrutivo.");
				   	      Console.WriteLine("==================================================================================================================================================");
				   	      Console.WriteLine("");
				   	      Console.WriteLine("============================================================================================================");
				   	      Console.WriteLine("Em casos de convulsões, é fundamental proteger a cabeça da pessoa e afastar objetos perigosos ao redor.");
				   	      Console.WriteLine("============================================================================================================");
				   	      Console.WriteLine("");
				   	      Console.WriteLine("=========================================================================================================================================");
				   	      Console.WriteLine("E em situações de desmaio, a vítima deve ser colocada de costas com as pernas elevadas, enquanto se aguarda por uma possível recuperação.");
				   	   	  Console.WriteLine("=========================================================================================================================================");
				   	    break;
				   	   //Opção selecionado pelo usuário
				       case "C":
				          Console.WriteLine("====================================================================================================================================================================================================================================");
				   	      Console.WriteLine("Existem várias opções disponíveis para procurar ajuda e tratamento para questões relacionadas à saúde mental, incluindo profissionais de saúde mental, serviços comunitários, linhas de apoio telefônico e programas de autocuidado.");
				       	  Console.WriteLine("====================================================================================================================================================================================================================================");
				   	   break;
				   	  //Opção selecionado pelo usuário
				   	  case"D":
				          Console.WriteLine("========================================================================================================================================================================================================================================================");
				   	      Console.WriteLine("Há diversas maneiras de buscar ajuda para questões de saúde mental, variando de profissionais de saúde mental e centros especializados a redes de apoio e serviços online. O mais importante é dar o primeiro passo e procurar o recurso que melhor se adapta às suas necessidades, pois a saúde mental é fundamental para o bem-estar geral e uma vida equilibrada.");
				       	  Console.WriteLine("========================================================================================================================================================================================================================================================");
				   	   break;
				   	   //Opção selecionado pelo usuário
				       case "E":
				          Console.WriteLine("=============================================================================================================================================================================================================================================");
				   	      Console.WriteLine("tratar a febre envolve o uso de antipiréticos, hidratação adequada, descanso, manutenção de um ambiente fresco e monitoramento dos sintomas. Identificar e tratar a causa subjacente é essencial para a recuperação. Em casos de febre persistente, muito alta ou acompanhada de sintomas graves, buscar atendimento médico é fundamental para garantir um tratamento adequado e seguro.");
				          Console.WriteLine("=============================================================================================================================================================================================================================================");
				   	   break;
				  //Outra opção digitada pelo usuário
				  default:
				   Console.WriteLine("Você digitou alguma opção errda!");
            	break;    
    			}
				break;
			    
				//Sair do Menu
			    case "J":
				case "j":
				   Console.WriteLine("Sair do Menu");
				break;
			//Outra opção digitada
			default:
				Console.WriteLine("Você digitou alguma opção errada ");
				Console.WriteLine("Digite s ou n para voltar para o menu ou sair do pragrama");
				break;
			
			}
			
	    //Comando goto voltar para o início
	    Console.WriteLine("Digite s para continuar navegando no menu ou n para sair do menu");
	    Console.WriteLine("Deseja outra opção ?[s/n]: ");
		MP=Console.ReadLine();
		Console.Clear();
		if(MP=="s"|| MP=="S"){
			goto inicio;
		}else{
			//Programa Finalizado com sucesso
			Console.WriteLine("====================");
			Console.WriteLine("|Saindo do Programa|");
			Console.WriteLine("====================");
		}
			
		    Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}