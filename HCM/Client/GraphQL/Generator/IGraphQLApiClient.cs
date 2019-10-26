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
	

	/// <param name="email">email of Employee</param>
	/// <param name="emails">emails is list variant of email of Employee</param>
	/// <param name="name">name of Employee</param>
	/// <param name="names">names is list variant of name of Employee</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Employee")]
	GraphQLQuery<GqlEmployee> Employee (string sessionToken, long? _id = null, long?[] _ids = null, string email = null, string[] emails = null, Gql_EmployeeFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_EmployeeOrdering[] orderBy = null, Func<GqlEmployee, GqlEmployee> fields = null );
	

	/// <param name="duration">duration of LearningItem</param>
	/// <param name="durations">durations is list variant of duration of LearningItem</param>
	/// <param name="name">name of LearningItem</param>
	/// <param name="names">names is list variant of name of LearningItem</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningItem")]
	GraphQLQuery<GqlLearningItem> LearningItem (string sessionToken, long? _id = null, long?[] _ids = null, string duration = null, string[] durations = null, Gql_LearningItemFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningItemOrdering[] orderBy = null, Func<GqlLearningItem, GqlLearningItem> fields = null );
	

	/// <param name="description">description of LearningPath</param>
	/// <param name="descriptions">descriptions is list variant of description of LearningPath</param>
	/// <param name="name">name of LearningPath</param>
	/// <param name="names">names is list variant of name of LearningPath</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningPath")]
	GraphQLQuery<GqlLearningPath> LearningPath (string sessionToken, long? _id = null, long?[] _ids = null, string description = null, string[] descriptions = null, Gql_LearningPathFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningPathOrdering[] orderBy = null, Func<GqlLearningPath, GqlLearningPath> fields = null );
	

	/// <param name="name">name of Role</param>
	/// <param name="names">names is list variant of name of Role</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Role")]
	GraphQLQuery<GqlRole> Role (string sessionToken, long? _id = null, long?[] _ids = null, Gql_RoleFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_RoleOrdering[] orderBy = null, Func<GqlRole, GqlRole> fields = null );
	

	/// <param name="name">name of Team</param>
	/// <param name="names">names is list variant of name of Team</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Team")]
	GraphQLQuery<GqlTeam> Team (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TeamFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TeamOrdering[] orderBy = null, Func<GqlTeam, GqlTeam> fields = null );
	

    
}
