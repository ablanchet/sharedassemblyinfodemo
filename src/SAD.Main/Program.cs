using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Main
{
    class Program
    {
        static void Main( string[] args )
        {
            ShowDetailsInformations( typeof( Program ) );
            ShowDetailsInformations( typeof( SAD.Core.CoreFeature ) );
            ShowDetailsInformations( typeof( SAD.Services.SuperUsefullWebServiceWrapper ) );

            Console.ReadKey();
        }

        static void ShowDetailsInformations( Type type )
        {
            Console.WriteLine( "====================" );

            string title = ((AssemblyTitleAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyTitleAttribute ), false )).Title;
            string description = ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyDescriptionAttribute ), false )).Description;
            string configuration = ((AssemblyConfigurationAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyConfigurationAttribute ), false )).Configuration;
            string company = ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyCompanyAttribute ), false )).Company;
            string product = ((AssemblyProductAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyProductAttribute ), false )).Product;
            string copyright = ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyCopyrightAttribute ), false )).Copyright;
            string trademark = ((AssemblyTrademarkAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyTrademarkAttribute ), false )).Trademark;
            string guid = ((GuidAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( GuidAttribute ), false )).Value;
            string version = type.Assembly.GetName().Version.ToString(4);
            string fileVersion = ((AssemblyFileVersionAttribute)Attribute.GetCustomAttribute( type.Assembly, typeof( AssemblyFileVersionAttribute ), false )).Version;

            Console.WriteLine( "Title : {0}", title );
            Console.WriteLine( "Description : {0}", description );
            Console.WriteLine( "Version : {0}", version );
            Console.WriteLine( "File Version : {0}", fileVersion );
            Console.WriteLine( "Configuration : {0}", configuration );
            Console.WriteLine( "Company : {0}", company );
            Console.WriteLine( "Product : {0}", product );
            Console.WriteLine( "Copyright : {0}", copyright );
            Console.WriteLine( "Trademark : {0}", trademark );
            Console.WriteLine( "GUID : {0}", guid );

            Console.WriteLine();
        }
    }
}
