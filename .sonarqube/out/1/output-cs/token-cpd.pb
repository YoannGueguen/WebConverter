ß

@C:\Users\yoann\Source\Repos\WebConverter\Dal\ConverterContext.cs
	namespace 	
Dal
 
{ 
public 

class 
ConverterContext !
:" #
	DbContext$ -
{ 
public		 
DbSet		 
<		 
	Converter		 
>		 

Converters		  *
{		+ ,
get		- 0
;		0 1
set		2 5
;		5 6
}		7 8
public 
ConverterContext 
(  
)  !
: 
base 
( 
) 
{ 	
} 	
public 
ConverterContext 
(  
DbContextOptions  0
options1 8
)8 9
: 
base 
( 
options 
) 
{ 	
} 	
	protected 
override 
void 
OnConfiguring  -
(- .#
DbContextOptionsBuilder. E
optionsBuilderF T
)T U
{ 	
optionsBuilder 
. 
UseSqlServer '
(' (
$str( +
)+ ,
;, -
base 
. 
OnConfiguring 
( 
optionsBuilder -
)- .
;. /
} 	
} 
}   ü
HC:\Users\yoann\Source\Repos\WebConverter\Dal\Mapping\ConverterMapping.cs
	namespace 	
Dal
 
. 
Mapping 
{		 
internal

 
class

 
ConverterMapping

 #
:

$ %$
IEntityTypeConfiguration

& >
<

> ?
	Converter

? H
>

H I
{ 
public 
void 
	Configure 
( 
EntityTypeBuilder /
</ 0
	Converter0 9
>9 :
builder; B
)B C
{ 	
builder 
. 
HasKey 
( 
c 
=> 
c  !
.! "
	ConvertId" +
)+ ,
. 
HasName 
( 
$str $
)$ %
;% &
builder 
. 
Property 
( 
c 
=> !
c" #
.# $
	ConvertId$ -
)- .
. &
UseSqlServerIdentityColumn +
(+ ,
), -
;- .
} 	
} 
} 