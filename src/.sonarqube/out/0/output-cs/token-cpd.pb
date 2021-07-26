Þ
SE:\Projetos\curso_jenkins\src\todobackend.CriacaoListaTarefas\Entities\Atividade.cs
	namespace 	
todobackend
 
. 
CriacaoListaTarefas )
.) *
Entities* 2
{ 
public 

class 
	Atividade 
{ 
public 
	Atividade 
( 
) 
{		 	
Tarefas

 
=

 
new

 
List

 
<

 
Tarefa

 %
>

% &
(

& '
)

' (
;

( )
} 	
public 
List 
< 
Tarefa 
> 
Tarefas #
{$ %
get& )
;) *
}* +
public 
void 
CriarNovaTarefa #
(# $
string$ *
	descricao+ 4
)4 5
=> 
Tarefas 
. 
Add 
( 
new 
Tarefa %
(% &
	descricao& /
)/ 0
)0 1
;1 2
} 
}  
PE:\Projetos\curso_jenkins\src\todobackend.CriacaoListaTarefas\Entities\Tarefa.cs
	namespace 	
todobackend
 
. 
CriacaoListaTarefas )
.) *
Entities* 2
{ 
public 

class 
Tarefa 
{ 
public 
Tarefa 
( 
string 
	descricao &
)& '
{ 	
	Descricao 
= 
	descricao !
;! "
} 	
public

 
string

 
	Descricao

 
{

  !
get

" %
;

% &
}

' (
} 
} 