®
SC:\Users\yoann\Source\Repos\WebConverter\WebConvertor\Controllers\HomeController.cs
	namespace		 	
WebConvertor		
 
.		 
Controllers		 "
{

 
public 

class 
HomeController 
:  !

Controller" ,
{ 
public 
IActionResult 
Index "
(" #
)# $
{ 	
return 
View 
( 
) 
; 
} 	
public 
IActionResult 
About "
(" #
)# $
{ 	
ViewData 
[ 
$str 
] 
=  !
$str" F
;F G
return 
View 
( 
) 
; 
} 	
public 
IActionResult 
Contact $
($ %
)% &
{ 	
ViewData 
[ 
$str 
] 
=  !
$str" 6
;6 7
return 
View 
( 
) 
; 
} 	
public   
IActionResult   
Error   "
(  " #
)  # $
{!! 	
return"" 
View"" 
("" 
new"" 
ErrorViewModel"" *
{""+ ,
	RequestId""- 6
=""7 8
Activity""9 A
.""A B
Current""B I
?""I J
.""J K
Id""K M
??""N P
HttpContext""Q \
.""\ ]
TraceIdentifier""] l
}""m n
)""n o
;""o p
}## 	
}$$ 
}%% œ
NC:\Users\yoann\Source\Repos\WebConverter\WebConvertor\Models\ErrorViewModel.cs
	namespace 	
WebConvertor
 
. 
Models 
{ 
public 

class 
ErrorViewModel 
{ 
public 
string 
	RequestId 
{  !
get" %
;% &
set' *
;* +
}, -
public		 
bool		 
ShowRequestId		 !
=>		" $
!		% &
string		& ,
.		, -
IsNullOrEmpty		- :
(		: ;
	RequestId		; D
)		D E
;		E F
}

 
} Ï
@C:\Users\yoann\Source\Repos\WebConverter\WebConvertor\Program.cs
	namespace 	
WebConvertor
 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
BuildWebHost 
( 
args 
) 
. 
Run "
(" #
)# $
;$ %
} 	
public 
static 
IWebHost 
BuildWebHost +
(+ ,
string, 2
[2 3
]3 4
args5 9
)9 :
=>; =
WebHost 
.  
CreateDefaultBuilder (
(( )
args) -
)- .
. 

UseStartup 
< 
Startup #
># $
($ %
)% &
. 
Build 
( 
) 
; 
} 
} „
@C:\Users\yoann\Source\Repos\WebConverter\WebConvertor\Startup.cs
	namespace

 	
WebConvertor


 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddMvc 
( 
) 
; 
} 	
public 
void 
	Configure 
( 
IApplicationBuilder 1
app2 5
,5 6
IHostingEnvironment7 J
envK N
)N O
{ 	
if 
( 
env 
. 
IsDevelopment !
(! "
)" #
)# $
{ 
app   
.   
UseBrowserLink   "
(  " #
)  # $
;  $ %
app!! 
.!! %
UseDeveloperExceptionPage!! -
(!!- .
)!!. /
;!!/ 0
}"" 
else## 
{$$ 
app%% 
.%% 
UseExceptionHandler%% '
(%%' (
$str%%( 5
)%%5 6
;%%6 7
}&& 
app(( 
.(( 
UseStaticFiles(( 
((( 
)((  
;((  !
app** 
.** 
UseMvc** 
(** 
routes** 
=>**  
{++ 
routes,, 
.,, 
MapRoute,, 
(,,  
name-- 
:-- 
$str-- #
,--# $
template.. 
:.. 
$str.. F
)..F G
;..G H
}// 
)// 
;// 
}00 	
}11 
}22 Û

KC:\Users\yoann\Source\Repos\WebConverter\WebConvertor\Test\TestConverter.cs
	namespace 	
WebConvertor
 
. 
Test 
{ 
public 

class 
TestConverter 
{		 
public 
double )
GivenConvertMilesToKilometers 3
(3 4
double4 :
miles; @
)@ A
{ 	
return 
miles 
* 
$num #
;# $
} 	
public 
double )
GivenConvertKilometersToMiles 3
(3 4
double4 :

kilometers; E
)E F
{ 	
return 

kilometers 
* 
$num  +
;+ ,
} 	
public 
double (
GivenConvertKilometersToInch 2
(2 3
double3 9

kilometers: D
)D E
{ 	
return 

kilometers 
* 
$num  0
;0 1
} 	
public 
double (
GivenConvertInchToKilometers 2
(2 3
double3 9
inch: >
)> ?
{ 	
return 
inch 
* 
$num #
;# $
} 	
} 
} 