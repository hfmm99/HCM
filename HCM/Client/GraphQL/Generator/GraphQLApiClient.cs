using System;
using System.Collections.Generic;
using System.Reflection;
using System.Net.Http;
using Newtonsoft.Json;
using HCM.Client.GraphQL.Client;
using HCM.Client.GraphQL.Client.Http;
using System.Threading.Tasks;

public partial class GqlClient
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>name of  Client</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>Client worksFor Employee</summary>
	[GraphQLField("worksFor")]
	public List<GqlEmployee> WorksFor { get; set; }

}

public partial class GqlCountry
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Country livesIn Employee</summary>
	[GraphQLField("livesIn")]
	public List<GqlEmployee> LivesIn { get; set; }

	/// <summary>name of  Country</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlEmployee
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>email of  Employee</summary>
	[GraphQLField("email")]
	public string Email { get; set; }

	/// <summary>Employee isMemberOf Team</summary>
	[GraphQLField("isMemberOf")]
	public List<GqlTeam> IsMemberOf { get; set; }

	/// <summary>Employee livesIn Country</summary>
	[GraphQLField("livesIn")]
	public GqlCountry LivesIn { get; set; }

	/// <summary>name of  Employee</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>Employee worksAs Role</summary>
	[GraphQLField("worksAs")]
	public List<GqlRole> WorksAs { get; set; }

	/// <summary>Employee worksFor Client</summary>
	[GraphQLField("worksFor")]
	public GqlClient WorksFor { get; set; }

}

public partial class GqlRole
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Role employees Employee</summary>
	[GraphQLField("employees")]
	public List<GqlEmployee> Employees { get; set; }

	/// <summary>Role isRequired Team</summary>
	[GraphQLField("isRequired")]
	public List<GqlTeam> IsRequired { get; set; }

	/// <summary>name of  Role</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlTeam
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Team members Employee</summary>
	[GraphQLField("members")]
	public List<GqlEmployee> Members { get; set; }

	/// <summary>name of  Team</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>Team requires Role</summary>
	[GraphQLField("requires")]
	public List<GqlRole> Requires { get; set; }

}

public class Gql_ClientFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ClientFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ClientFilter> OR { get; set; }

	/// <summary>name</summary>
	[JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>name_contains</summary>
	[JsonProperty(PropertyName = "name_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_contains { get; set; }

	/// <summary>name_ends_with</summary>
	[JsonProperty(PropertyName = "name_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_ends_with { get; set; }

	/// <summary>name_gt</summary>
	[JsonProperty(PropertyName = "name_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gt { get; set; }

	/// <summary>name_gte</summary>
	[JsonProperty(PropertyName = "name_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gte { get; set; }

	/// <summary>name_in</summary>
	[JsonProperty(PropertyName = "name_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_in { get; set; }

	/// <summary>name_lt</summary>
	[JsonProperty(PropertyName = "name_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lt { get; set; }

	/// <summary>name_lte</summary>
	[JsonProperty(PropertyName = "name_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lte { get; set; }

	/// <summary>name_not</summary>
	[JsonProperty(PropertyName = "name_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not { get; set; }

	/// <summary>name_not_contains</summary>
	[JsonProperty(PropertyName = "name_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_contains { get; set; }

	/// <summary>name_not_ends_with</summary>
	[JsonProperty(PropertyName = "name_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_ends_with { get; set; }

	/// <summary>name_not_in</summary>
	[JsonProperty(PropertyName = "name_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_not_in { get; set; }

	/// <summary>name_not_starts_with</summary>
	[JsonProperty(PropertyName = "name_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_starts_with { get; set; }

	/// <summary>name_starts_with</summary>
	[JsonProperty(PropertyName = "name_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_starts_with { get; set; }

	/// <summary>worksFor</summary>
	[JsonProperty(PropertyName = "worksFor", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor { get; set; }

	/// <summary>worksFor_every</summary>
	[JsonProperty(PropertyName = "worksFor_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor_every { get; set; }

	/// <summary>worksFor_in</summary>
	[JsonProperty(PropertyName = "worksFor_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor_in { get; set; }

	/// <summary>worksFor_none</summary>
	[JsonProperty(PropertyName = "worksFor_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor_none { get; set; }

	/// <summary>worksFor_not</summary>
	[JsonProperty(PropertyName = "worksFor_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor_not { get; set; }

	/// <summary>worksFor_not_in</summary>
	[JsonProperty(PropertyName = "worksFor_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor_not_in { get; set; }

	/// <summary>worksFor_single</summary>
	[JsonProperty(PropertyName = "worksFor_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor_single { get; set; }

	/// <summary>worksFor_some</summary>
	[JsonProperty(PropertyName = "worksFor_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksFor_some { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_ClientOrdering
{
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_CountryFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_CountryFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_CountryFilter> OR { get; set; }

	/// <summary>livesIn</summary>
	[JsonProperty(PropertyName = "livesIn", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn { get; set; }

	/// <summary>livesIn_every</summary>
	[JsonProperty(PropertyName = "livesIn_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_every { get; set; }

	/// <summary>livesIn_in</summary>
	[JsonProperty(PropertyName = "livesIn_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_in { get; set; }

	/// <summary>livesIn_none</summary>
	[JsonProperty(PropertyName = "livesIn_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_none { get; set; }

	/// <summary>livesIn_not</summary>
	[JsonProperty(PropertyName = "livesIn_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_not { get; set; }

	/// <summary>livesIn_not_in</summary>
	[JsonProperty(PropertyName = "livesIn_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_not_in { get; set; }

	/// <summary>livesIn_single</summary>
	[JsonProperty(PropertyName = "livesIn_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_single { get; set; }

	/// <summary>livesIn_some</summary>
	[JsonProperty(PropertyName = "livesIn_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_some { get; set; }

	/// <summary>name</summary>
	[JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>name_contains</summary>
	[JsonProperty(PropertyName = "name_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_contains { get; set; }

	/// <summary>name_ends_with</summary>
	[JsonProperty(PropertyName = "name_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_ends_with { get; set; }

	/// <summary>name_gt</summary>
	[JsonProperty(PropertyName = "name_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gt { get; set; }

	/// <summary>name_gte</summary>
	[JsonProperty(PropertyName = "name_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gte { get; set; }

	/// <summary>name_in</summary>
	[JsonProperty(PropertyName = "name_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_in { get; set; }

	/// <summary>name_lt</summary>
	[JsonProperty(PropertyName = "name_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lt { get; set; }

	/// <summary>name_lte</summary>
	[JsonProperty(PropertyName = "name_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lte { get; set; }

	/// <summary>name_not</summary>
	[JsonProperty(PropertyName = "name_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not { get; set; }

	/// <summary>name_not_contains</summary>
	[JsonProperty(PropertyName = "name_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_contains { get; set; }

	/// <summary>name_not_ends_with</summary>
	[JsonProperty(PropertyName = "name_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_ends_with { get; set; }

	/// <summary>name_not_in</summary>
	[JsonProperty(PropertyName = "name_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_not_in { get; set; }

	/// <summary>name_not_starts_with</summary>
	[JsonProperty(PropertyName = "name_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_starts_with { get; set; }

	/// <summary>name_starts_with</summary>
	[JsonProperty(PropertyName = "name_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_starts_with { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_CountryOrdering
{
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_EmployeeFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_EmployeeFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_EmployeeFilter> OR { get; set; }

	/// <summary>email</summary>
	[JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore)]
	public string Email { get; set; }

	/// <summary>email_contains</summary>
	[JsonProperty(PropertyName = "email_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_contains { get; set; }

	/// <summary>email_ends_with</summary>
	[JsonProperty(PropertyName = "email_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_ends_with { get; set; }

	/// <summary>email_gt</summary>
	[JsonProperty(PropertyName = "email_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_gt { get; set; }

	/// <summary>email_gte</summary>
	[JsonProperty(PropertyName = "email_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_gte { get; set; }

	/// <summary>email_in</summary>
	[JsonProperty(PropertyName = "email_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Email_in { get; set; }

	/// <summary>email_lt</summary>
	[JsonProperty(PropertyName = "email_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_lt { get; set; }

	/// <summary>email_lte</summary>
	[JsonProperty(PropertyName = "email_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_lte { get; set; }

	/// <summary>email_not</summary>
	[JsonProperty(PropertyName = "email_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_not { get; set; }

	/// <summary>email_not_contains</summary>
	[JsonProperty(PropertyName = "email_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_not_contains { get; set; }

	/// <summary>email_not_ends_with</summary>
	[JsonProperty(PropertyName = "email_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_not_ends_with { get; set; }

	/// <summary>email_not_in</summary>
	[JsonProperty(PropertyName = "email_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Email_not_in { get; set; }

	/// <summary>email_not_starts_with</summary>
	[JsonProperty(PropertyName = "email_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_not_starts_with { get; set; }

	/// <summary>email_starts_with</summary>
	[JsonProperty(PropertyName = "email_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Email_starts_with { get; set; }

	/// <summary>isMemberOf</summary>
	[JsonProperty(PropertyName = "isMemberOf", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf { get; set; }

	/// <summary>isMemberOf_every</summary>
	[JsonProperty(PropertyName = "isMemberOf_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_every { get; set; }

	/// <summary>isMemberOf_in</summary>
	[JsonProperty(PropertyName = "isMemberOf_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_in { get; set; }

	/// <summary>isMemberOf_none</summary>
	[JsonProperty(PropertyName = "isMemberOf_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_none { get; set; }

	/// <summary>isMemberOf_not</summary>
	[JsonProperty(PropertyName = "isMemberOf_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_not { get; set; }

	/// <summary>isMemberOf_not_in</summary>
	[JsonProperty(PropertyName = "isMemberOf_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_not_in { get; set; }

	/// <summary>isMemberOf_single</summary>
	[JsonProperty(PropertyName = "isMemberOf_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_single { get; set; }

	/// <summary>isMemberOf_some</summary>
	[JsonProperty(PropertyName = "isMemberOf_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_some { get; set; }

	/// <summary>livesIn</summary>
	[JsonProperty(PropertyName = "livesIn", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn { get; set; }

	/// <summary>livesIn_in</summary>
	[JsonProperty(PropertyName = "livesIn_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_in { get; set; }

	/// <summary>livesIn_not</summary>
	[JsonProperty(PropertyName = "livesIn_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_not { get; set; }

	/// <summary>livesIn_not_in</summary>
	[JsonProperty(PropertyName = "livesIn_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_not_in { get; set; }

	/// <summary>name</summary>
	[JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>name_contains</summary>
	[JsonProperty(PropertyName = "name_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_contains { get; set; }

	/// <summary>name_ends_with</summary>
	[JsonProperty(PropertyName = "name_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_ends_with { get; set; }

	/// <summary>name_gt</summary>
	[JsonProperty(PropertyName = "name_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gt { get; set; }

	/// <summary>name_gte</summary>
	[JsonProperty(PropertyName = "name_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gte { get; set; }

	/// <summary>name_in</summary>
	[JsonProperty(PropertyName = "name_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_in { get; set; }

	/// <summary>name_lt</summary>
	[JsonProperty(PropertyName = "name_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lt { get; set; }

	/// <summary>name_lte</summary>
	[JsonProperty(PropertyName = "name_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lte { get; set; }

	/// <summary>name_not</summary>
	[JsonProperty(PropertyName = "name_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not { get; set; }

	/// <summary>name_not_contains</summary>
	[JsonProperty(PropertyName = "name_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_contains { get; set; }

	/// <summary>name_not_ends_with</summary>
	[JsonProperty(PropertyName = "name_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_ends_with { get; set; }

	/// <summary>name_not_in</summary>
	[JsonProperty(PropertyName = "name_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_not_in { get; set; }

	/// <summary>name_not_starts_with</summary>
	[JsonProperty(PropertyName = "name_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_starts_with { get; set; }

	/// <summary>name_starts_with</summary>
	[JsonProperty(PropertyName = "name_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_starts_with { get; set; }

	/// <summary>worksAs</summary>
	[JsonProperty(PropertyName = "worksAs", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs { get; set; }

	/// <summary>worksAs_every</summary>
	[JsonProperty(PropertyName = "worksAs_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs_every { get; set; }

	/// <summary>worksAs_in</summary>
	[JsonProperty(PropertyName = "worksAs_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs_in { get; set; }

	/// <summary>worksAs_none</summary>
	[JsonProperty(PropertyName = "worksAs_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs_none { get; set; }

	/// <summary>worksAs_not</summary>
	[JsonProperty(PropertyName = "worksAs_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs_not { get; set; }

	/// <summary>worksAs_not_in</summary>
	[JsonProperty(PropertyName = "worksAs_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs_not_in { get; set; }

	/// <summary>worksAs_single</summary>
	[JsonProperty(PropertyName = "worksAs_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs_single { get; set; }

	/// <summary>worksAs_some</summary>
	[JsonProperty(PropertyName = "worksAs_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter WorksAs_some { get; set; }

	/// <summary>worksFor</summary>
	[JsonProperty(PropertyName = "worksFor", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor { get; set; }

	/// <summary>worksFor_in</summary>
	[JsonProperty(PropertyName = "worksFor_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_in { get; set; }

	/// <summary>worksFor_not</summary>
	[JsonProperty(PropertyName = "worksFor_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_not { get; set; }

	/// <summary>worksFor_not_in</summary>
	[JsonProperty(PropertyName = "worksFor_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_not_in { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_EmployeeOrdering
{
	/// <summary>Ascending sort for email</summary>
	email_asc,
	/// <summary>Descending sort for email</summary>
	email_desc,
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_RoleFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_RoleFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_RoleFilter> OR { get; set; }

	/// <summary>employees</summary>
	[JsonProperty(PropertyName = "employees", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees { get; set; }

	/// <summary>employees_every</summary>
	[JsonProperty(PropertyName = "employees_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees_every { get; set; }

	/// <summary>employees_in</summary>
	[JsonProperty(PropertyName = "employees_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees_in { get; set; }

	/// <summary>employees_none</summary>
	[JsonProperty(PropertyName = "employees_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees_none { get; set; }

	/// <summary>employees_not</summary>
	[JsonProperty(PropertyName = "employees_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees_not { get; set; }

	/// <summary>employees_not_in</summary>
	[JsonProperty(PropertyName = "employees_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees_not_in { get; set; }

	/// <summary>employees_single</summary>
	[JsonProperty(PropertyName = "employees_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees_single { get; set; }

	/// <summary>employees_some</summary>
	[JsonProperty(PropertyName = "employees_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Employees_some { get; set; }

	/// <summary>isRequired</summary>
	[JsonProperty(PropertyName = "isRequired", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired { get; set; }

	/// <summary>isRequired_every</summary>
	[JsonProperty(PropertyName = "isRequired_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired_every { get; set; }

	/// <summary>isRequired_in</summary>
	[JsonProperty(PropertyName = "isRequired_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired_in { get; set; }

	/// <summary>isRequired_none</summary>
	[JsonProperty(PropertyName = "isRequired_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired_none { get; set; }

	/// <summary>isRequired_not</summary>
	[JsonProperty(PropertyName = "isRequired_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired_not { get; set; }

	/// <summary>isRequired_not_in</summary>
	[JsonProperty(PropertyName = "isRequired_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired_not_in { get; set; }

	/// <summary>isRequired_single</summary>
	[JsonProperty(PropertyName = "isRequired_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired_single { get; set; }

	/// <summary>isRequired_some</summary>
	[JsonProperty(PropertyName = "isRequired_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequired_some { get; set; }

	/// <summary>name</summary>
	[JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>name_contains</summary>
	[JsonProperty(PropertyName = "name_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_contains { get; set; }

	/// <summary>name_ends_with</summary>
	[JsonProperty(PropertyName = "name_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_ends_with { get; set; }

	/// <summary>name_gt</summary>
	[JsonProperty(PropertyName = "name_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gt { get; set; }

	/// <summary>name_gte</summary>
	[JsonProperty(PropertyName = "name_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gte { get; set; }

	/// <summary>name_in</summary>
	[JsonProperty(PropertyName = "name_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_in { get; set; }

	/// <summary>name_lt</summary>
	[JsonProperty(PropertyName = "name_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lt { get; set; }

	/// <summary>name_lte</summary>
	[JsonProperty(PropertyName = "name_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lte { get; set; }

	/// <summary>name_not</summary>
	[JsonProperty(PropertyName = "name_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not { get; set; }

	/// <summary>name_not_contains</summary>
	[JsonProperty(PropertyName = "name_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_contains { get; set; }

	/// <summary>name_not_ends_with</summary>
	[JsonProperty(PropertyName = "name_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_ends_with { get; set; }

	/// <summary>name_not_in</summary>
	[JsonProperty(PropertyName = "name_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_not_in { get; set; }

	/// <summary>name_not_starts_with</summary>
	[JsonProperty(PropertyName = "name_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_starts_with { get; set; }

	/// <summary>name_starts_with</summary>
	[JsonProperty(PropertyName = "name_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_starts_with { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_RoleOrdering
{
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_TeamFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_TeamFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_TeamFilter> OR { get; set; }

	/// <summary>members</summary>
	[JsonProperty(PropertyName = "members", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members { get; set; }

	/// <summary>members_every</summary>
	[JsonProperty(PropertyName = "members_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members_every { get; set; }

	/// <summary>members_in</summary>
	[JsonProperty(PropertyName = "members_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members_in { get; set; }

	/// <summary>members_none</summary>
	[JsonProperty(PropertyName = "members_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members_none { get; set; }

	/// <summary>members_not</summary>
	[JsonProperty(PropertyName = "members_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members_not { get; set; }

	/// <summary>members_not_in</summary>
	[JsonProperty(PropertyName = "members_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members_not_in { get; set; }

	/// <summary>members_single</summary>
	[JsonProperty(PropertyName = "members_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members_single { get; set; }

	/// <summary>members_some</summary>
	[JsonProperty(PropertyName = "members_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Members_some { get; set; }

	/// <summary>name</summary>
	[JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>name_contains</summary>
	[JsonProperty(PropertyName = "name_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_contains { get; set; }

	/// <summary>name_ends_with</summary>
	[JsonProperty(PropertyName = "name_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_ends_with { get; set; }

	/// <summary>name_gt</summary>
	[JsonProperty(PropertyName = "name_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gt { get; set; }

	/// <summary>name_gte</summary>
	[JsonProperty(PropertyName = "name_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_gte { get; set; }

	/// <summary>name_in</summary>
	[JsonProperty(PropertyName = "name_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_in { get; set; }

	/// <summary>name_lt</summary>
	[JsonProperty(PropertyName = "name_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lt { get; set; }

	/// <summary>name_lte</summary>
	[JsonProperty(PropertyName = "name_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_lte { get; set; }

	/// <summary>name_not</summary>
	[JsonProperty(PropertyName = "name_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not { get; set; }

	/// <summary>name_not_contains</summary>
	[JsonProperty(PropertyName = "name_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_contains { get; set; }

	/// <summary>name_not_ends_with</summary>
	[JsonProperty(PropertyName = "name_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_ends_with { get; set; }

	/// <summary>name_not_in</summary>
	[JsonProperty(PropertyName = "name_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Name_not_in { get; set; }

	/// <summary>name_not_starts_with</summary>
	[JsonProperty(PropertyName = "name_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_not_starts_with { get; set; }

	/// <summary>name_starts_with</summary>
	[JsonProperty(PropertyName = "name_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Name_starts_with { get; set; }

	/// <summary>requires</summary>
	[JsonProperty(PropertyName = "requires", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires { get; set; }

	/// <summary>requires_every</summary>
	[JsonProperty(PropertyName = "requires_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_every { get; set; }

	/// <summary>requires_in</summary>
	[JsonProperty(PropertyName = "requires_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_in { get; set; }

	/// <summary>requires_none</summary>
	[JsonProperty(PropertyName = "requires_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_none { get; set; }

	/// <summary>requires_not</summary>
	[JsonProperty(PropertyName = "requires_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_not { get; set; }

	/// <summary>requires_not_in</summary>
	[JsonProperty(PropertyName = "requires_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_not_in { get; set; }

	/// <summary>requires_single</summary>
	[JsonProperty(PropertyName = "requires_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_single { get; set; }

	/// <summary>requires_some</summary>
	[JsonProperty(PropertyName = "requires_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_some { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_TeamOrdering
{
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public sealed class GraphQLApiClient : IGraphQLApiClient
{
	private readonly IGraphQLClient _graphQlHttpClient;
	private readonly HttpClient _httpClient;
	private readonly string _endpoint;

	public GraphQLApiClient(HttpClient httpClient, string endpoint)
    {
		_httpClient = httpClient;
        _graphQlHttpClient = new GraphQLHttpClient(httpClient, endpoint);
		_endpoint = endpoint;
    }
	/// <param name="name">name of Client</param>
	/// <param name="names">names is list variant of name of Client</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Client")]
	public GraphQLQuery<GqlClient> Client (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ClientFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ClientOrdering[] orderBy = null, Func<GqlClient, GqlClient> fields = null ) 
	{
		return new GraphQLQuery<GqlClient>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Country</param>
	/// <param name="names">names is list variant of name of Country</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Country")]
	public GraphQLQuery<GqlCountry> Country (string sessionToken, long? _id = null, long?[] _ids = null, Gql_CountryFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_CountryOrdering[] orderBy = null, Func<GqlCountry, GqlCountry> fields = null ) 
	{
		return new GraphQLQuery<GqlCountry>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="email">email of Employee</param>
	/// <param name="emails">emails is list variant of email of Employee</param>
	/// <param name="name">name of Employee</param>
	/// <param name="names">names is list variant of name of Employee</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Employee")]
	public GraphQLQuery<GqlEmployee> Employee (string sessionToken, long? _id = null, long?[] _ids = null, string email = null, string[] emails = null, Gql_EmployeeFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_EmployeeOrdering[] orderBy = null, Func<GqlEmployee, GqlEmployee> fields = null ) 
	{
		return new GraphQLQuery<GqlEmployee>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, email, emails, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Role</param>
	/// <param name="names">names is list variant of name of Role</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Role")]
	public GraphQLQuery<GqlRole> Role (string sessionToken, long? _id = null, long?[] _ids = null, Gql_RoleFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_RoleOrdering[] orderBy = null, Func<GqlRole, GqlRole> fields = null ) 
	{
		return new GraphQLQuery<GqlRole>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Team</param>
	/// <param name="names">names is list variant of name of Team</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Team")]
	public GraphQLQuery<GqlTeam> Team (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TeamFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TeamOrdering[] orderBy = null, Func<GqlTeam, GqlTeam> fields = null ) 
	{
		return new GraphQLQuery<GqlTeam>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

    
	/// <summary>Adds WorksFor to Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addClientWorksFor")]
	public GraphQLQuery<string> AddClientWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, worksFor);
	}

	/// <summary>Adds LivesIn to Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addCountryLivesIn")]
	public GraphQLQuery<string> AddCountryLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, livesIn, name);
	}

	/// <summary>Adds IsMemberOf to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeIsMemberOf")]
	public GraphQLQuery<string> AddEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, isMemberOf, name);
	}

	/// <summary>Adds LivesIn to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeLivesIn")]
	public GraphQLQuery<string> AddEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, livesIn, name);
	}

	/// <summary>Adds WorksAs to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksAs")]
	public GraphQLQuery<string> AddEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, worksAs);
	}

	/// <summary>Adds WorksFor to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksFor")]
	public GraphQLQuery<string> AddEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, worksFor);
	}

	/// <summary>Adds Employees to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleEmployees")]
	public GraphQLQuery<string> AddRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, employees, name);
	}

	/// <summary>Adds IsRequired to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleIsRequired")]
	public GraphQLQuery<string> AddRoleIsRequired (string sessionToken, string[] isRequired, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, isRequired, name);
	}

	/// <summary>Adds Members to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamMembers")]
	public GraphQLQuery<string> AddTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, members, name);
	}

	/// <summary>Adds Requires to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamRequires")]
	public GraphQLQuery<string> AddTeamRequires (string sessionToken, string name, string[] requires, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, requires);
	}

	/// <summary>Creates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createClient")]
	public GraphQLQuery<string> CreateClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Creates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createCountry")]
	public GraphQLQuery<string> CreateCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Creates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createEmployee")]
	public GraphQLQuery<string> CreateEmployee (string sessionToken, string name, string email = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, email);
	}

	/// <summary>Creates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createRole")]
	public GraphQLQuery<string> CreateRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Creates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createTeam")]
	public GraphQLQuery<string> CreateTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Deletes a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClient")]
	public GraphQLQuery<string> DeleteClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Deletes WorksFor from Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClientWorksFor")]
	public GraphQLQuery<string> DeleteClientWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, worksFor);
	}

	/// <summary>Deletes a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountry")]
	public GraphQLQuery<string> DeleteCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Deletes LivesIn from Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountryLivesIn")]
	public GraphQLQuery<string> DeleteCountryLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, livesIn, name);
	}

	/// <summary>Deletes a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployee")]
	public GraphQLQuery<string> DeleteEmployee (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Deletes IsMemberOf from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeIsMemberOf")]
	public GraphQLQuery<string> DeleteEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, isMemberOf, name);
	}

	/// <summary>Deletes LivesIn from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeLivesIn")]
	public GraphQLQuery<string> DeleteEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, livesIn, name);
	}

	/// <summary>Deletes WorksAs from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksAs")]
	public GraphQLQuery<string> DeleteEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, worksAs);
	}

	/// <summary>Deletes WorksFor from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksFor")]
	public GraphQLQuery<string> DeleteEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, worksFor);
	}

	/// <summary>Deletes a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRole")]
	public GraphQLQuery<string> DeleteRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Deletes Employees from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleEmployees")]
	public GraphQLQuery<string> DeleteRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, employees, name);
	}

	/// <summary>Deletes IsRequired from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleIsRequired")]
	public GraphQLQuery<string> DeleteRoleIsRequired (string sessionToken, string[] isRequired, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, isRequired, name);
	}

	/// <summary>Deletes a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeam")]
	public GraphQLQuery<string> DeleteTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Deletes Members from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamMembers")]
	public GraphQLQuery<string> DeleteTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, members, name);
	}

	/// <summary>Deletes Requires from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamRequires")]
	public GraphQLQuery<string> DeleteTeamRequires (string sessionToken, string name, string[] requires, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, requires);
	}

	/// <summary>Merge a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeClient")]
	public GraphQLQuery<string> MergeClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Merge a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeCountry")]
	public GraphQLQuery<string> MergeCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Merge a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeEmployee")]
	public GraphQLQuery<string> MergeEmployee (string sessionToken, string name, string email = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, email);
	}

	/// <summary>Merge a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeRole")]
	public GraphQLQuery<string> MergeRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Merge a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeTeam")]
	public GraphQLQuery<string> MergeTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Updates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateClient")]
	public GraphQLQuery<string> UpdateClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Updates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateCountry")]
	public GraphQLQuery<string> UpdateCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Updates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateEmployee")]
	public GraphQLQuery<string> UpdateEmployee (string sessionToken, string name, string email = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name, email);
	}

	/// <summary>Updates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateRole")]
	public GraphQLQuery<string> UpdateRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

	/// <summary>Updates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateTeam")]
	public GraphQLQuery<string> UpdateTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, name);
	}

    
}
