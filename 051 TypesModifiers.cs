//-----------------------------------------------------------------------------------------------
/*
	Access modifiers in C#.
	In c# there are 5 defferent modifiers.
	1) private
	2) public 
	3) protected
	4) internal
	5) public
	
	You can use all the 5 types of modifiers with type members, but types allows only internal and public access modifiers
	it is compile time error to use private, protected and protected internal access modifiers with types.
	
	Private :
		Only within the containing class (Default for type members)
	public : 
		Anywhere, No restriction
	protected : 
		with in the containing types and the types derive from the containing types
	internal :
		Anywhere within the containing assembly (Default for types)
	protected internal : 
		anywhere with in the containing assembly, and from within derived class in any anaother assembly.
*/
//-------------------------------------------------------------------------------------------------
