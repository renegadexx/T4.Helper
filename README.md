# T4.Helper

## T4.TemplateFileManager

Usually it is sufficient when transforming a T4 Template “example.tt” results in a single output file “example.cs”. But there are situation in which one would like to have multiple different output files like:
- Putting each generated data class into a single code file
- Creating a server and a client component based on a common model
- Distribute generated code to multiple projects within a solution

You can use the T4.TemplateFileManager via nuget if you run the following command in the Package Manager Console in Visual Studio:

`PM> Install-Package T4.TemplateFileManager`


### Limitations
- Only one instance of the T4.TemplateFileManager can be used per Template
- Projects and folders, where you place the output files, will not created automatically
