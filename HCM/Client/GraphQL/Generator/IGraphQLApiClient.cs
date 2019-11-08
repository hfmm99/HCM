using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using HCM.Client.GraphQL.Client;
using System.Threading.Tasks;

public interface IGraphQLApiClient
{
	/// <param name="name">name of Client</param>
	/// <param name="names">names is list variant of name of Client</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Client")]
	GraphQLQuery<GqlClient> Client (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ClientFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ClientOrdering[] orderBy = null, Func<GqlClient, GqlClient> fields = null );
	

	/// <param name="name">name of Country</param>
	/// <param name="names">names is list variant of name of Country</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Country")]
	GraphQLQuery<GqlCountry> Country (string sessionToken, long? _id = null, long?[] _ids = null, Gql_CountryFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_CountryOrdering[] orderBy = null, Func<GqlCountry, GqlCountry> fields = null );
	

	/// <param name="dateOfBirth">dateOfBirth of Employee</param>
	/// <param name="dateOfBirths">dateOfBirths is list variant of dateOfBirth of Employee</param>
	/// <param name="email">email of Employee</param>
	/// <param name="emails">emails is list variant of email of Employee</param>
	/// <param name="gender">gender of Employee</param>
	/// <param name="genders">genders is list variant of gender of Employee</param>
	/// <param name="name">name of Employee</param>
	/// <param name="names">names is list variant of name of Employee</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Employee")]
	GraphQLQuery<GqlEmployee> Employee (string sessionToken, long? _id = null, long?[] _ids = null, DateTime? dateOfBirth = null, DateTime?[] dateOfBirths = null, string email = null, string[] emails = null, Gql_EmployeeFilter filter = null, int? first = null, string gender = null, string[] genders = null, string name = null, string[] names = null, int? offset = null, Gql_EmployeeOrdering[] orderBy = null, Func<GqlEmployee, GqlEmployee> fields = null );
	

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("EmployeeCount")]
	GraphQLQuery<int?> EmployeeCount (string sessionToken, Func<int?, int?> fields = null );
	

	/// <param name="name">name of Role</param>
	/// <param name="names">names is list variant of name of Role</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Role")]
	GraphQLQuery<GqlRole> Role (string sessionToken, long? _id = null, long?[] _ids = null, Gql_RoleFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_RoleOrdering[] orderBy = null, Func<GqlRole, GqlRole> fields = null );
	

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("RoleCount")]
	GraphQLQuery<int?> RoleCount (string sessionToken, Func<int?, int?> fields = null );
	

	/// <param name="name">name of Team</param>
	/// <param name="names">names is list variant of name of Team</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Team")]
	GraphQLQuery<GqlTeam> Team (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TeamFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TeamOrdering[] orderBy = null, Func<GqlTeam, GqlTeam> fields = null );
	

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("TeamCount")]
	GraphQLQuery<int?> TeamCount (string sessionToken, Func<int?, int?> fields = null );
	

    
	/// <summary>Adds Employees to Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addClientEmployees")]
	GraphQLQuery<string> AddClientEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Employees to Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addCountryEmployees")]
	GraphQLQuery<string> AddCountryEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsMemberOf to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeIsMemberOf")]
	GraphQLQuery<string> AddEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null );
	

	/// <summary>Adds LivesIn to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeLivesIn")]
	GraphQLQuery<string> AddEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null );
	

	/// <summary>Adds WorksAs to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksAs")]
	GraphQLQuery<string> AddEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null );
	

	/// <summary>Adds WorksFor to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksFor")]
	GraphQLQuery<string> AddEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null );
	

	/// <summary>Adds Employees to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleEmployees")]
	GraphQLQuery<string> AddRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsRequiredBy to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleIsRequiredBy")]
	GraphQLQuery<string> AddRoleIsRequiredBy (string sessionToken, string[] isRequiredBy, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Members to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamMembers")]
	GraphQLQuery<string> AddTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Roles to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamRoles")]
	GraphQLQuery<string> AddTeamRoles (string sessionToken, string name, string[] roles, Func<string, string> fields = null );
	

	/// <summary>Creates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createClient")]
	GraphQLQuery<string> CreateClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createCountry")]
	GraphQLQuery<string> CreateCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createEmployee")]
	GraphQLQuery<string> CreateEmployee (string sessionToken, string name, DateTime? dateOfBirth = null, string email = null, string gender = null, Func<string, string> fields = null );
	

	/// <summary>Creates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createRole")]
	GraphQLQuery<string> CreateRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createTeam")]
	GraphQLQuery<string> CreateTeam (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClient")]
	GraphQLQuery<string> DeleteClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Employees from Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClientEmployees")]
	GraphQLQuery<string> DeleteClientEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountry")]
	GraphQLQuery<string> DeleteCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Employees from Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountryEmployees")]
	GraphQLQuery<string> DeleteCountryEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployee")]
	GraphQLQuery<string> DeleteEmployee (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsMemberOf from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeIsMemberOf")]
	GraphQLQuery<string> DeleteEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes LivesIn from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeLivesIn")]
	GraphQLQuery<string> DeleteEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes WorksAs from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksAs")]
	GraphQLQuery<string> DeleteEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null );
	

	/// <summary>Deletes WorksFor from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksFor")]
	GraphQLQuery<string> DeleteEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null );
	

	/// <summary>Deletes a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRole")]
	GraphQLQuery<string> DeleteRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Employees from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleEmployees")]
	GraphQLQuery<string> DeleteRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsRequiredBy from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleIsRequiredBy")]
	GraphQLQuery<string> DeleteRoleIsRequiredBy (string sessionToken, string[] isRequiredBy, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeam")]
	GraphQLQuery<string> DeleteTeam (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Members from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamMembers")]
	GraphQLQuery<string> DeleteTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Roles from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamRoles")]
	GraphQLQuery<string> DeleteTeamRoles (string sessionToken, string name, string[] roles, Func<string, string> fields = null );
	

	/// <summary>Merge a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeClient")]
	GraphQLQuery<string> MergeClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeCountry")]
	GraphQLQuery<string> MergeCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeEmployee")]
	GraphQLQuery<string> MergeEmployee (string sessionToken, string name, DateTime? dateOfBirth = null, string email = null, string gender = null, Func<string, string> fields = null );
	

	/// <summary>Merge a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeRole")]
	GraphQLQuery<string> MergeRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeTeam")]
	GraphQLQuery<string> MergeTeam (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateClient")]
	GraphQLQuery<string> UpdateClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateCountry")]
	GraphQLQuery<string> UpdateCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateEmployee")]
	GraphQLQuery<string> UpdateEmployee (string sessionToken, string name, DateTime? dateOfBirth = null, string email = null, string gender = null, Func<string, string> fields = null );
	

	/// <summary>Updates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateRole")]
	GraphQLQuery<string> UpdateRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateTeam")]
	GraphQLQuery<string> UpdateTeam (string sessionToken, string name, Func<string, string> fields = null );
	

    
}
