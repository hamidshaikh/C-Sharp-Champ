//-----------------------------------------------------------------------------------------------
/*
	Access modifiers in C#.
	
	internal and protected internal in C#.
	
	A member with internal access modifiers is available anywhere within the containing assembly. it's a 
	compile time error to access, an internal member from outside the containing assembly.
	
	Protected internal members can be accessed by any code in the assembly in which it is declared.
	or from within a derived class in anaother assembly. It is a combination of protected and internal.
	
	If you have understood protected nad internal this should be very easy to follow.
	
	1) Private : 
		Only within the containing class.
	2) Public :
		Anywhere, No restrictions
	3) Protected :
		Within the containing types and the types derived from the containging type.
	4) Internal : 
		Anywhere with in the containing assembly.
	5) protected Internal ; 
		Anywhere with in the containing assembly, and from within a derived class in any another asssembly.
*/
//-------------------------------------------------------------------------------------------------
