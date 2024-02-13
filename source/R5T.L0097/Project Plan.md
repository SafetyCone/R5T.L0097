# R5T.L0097
Code file generation context operations library.


## How this library works

Generally, all operations in this library should work for contexts at the intersection of:

* R5T.L0096.T000.IHasProjectFilePath
* R5T.L0096.T000.IHasNamespaceName


Operations start off in a context operations instance listing in one of the sub-libraries:

* O001 - Catch-all
* 


And are then forwarded to a complementary context operations instance listing in this library.


## Notes-Design

?: Where should TContext: IHasProjectFilePath, IHasNamespaceName code file generation operations be?
	A: Choose a new L#### library with O### sub-operations library.
	* An operations library?
	* A new library, with an operations sub-library?
	* An existing code file generation library?
		* R5T.O0003 - Common code file generation operations library.
		* R5T.O0004 - Rivet-specific code file generation operations library.
		* R5T.O0008 - Code file generation operations umbrella library.
		* R5T.L0037 - Code generation (repositories, solutions, projects, code files, and code elements).
