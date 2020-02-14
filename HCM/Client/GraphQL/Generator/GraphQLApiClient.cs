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

	/// <summary>Client employees Employee</summary>
	[GraphQLField("employees")]
	public List<GqlEmployee> Employees { get; set; }

	/// <summary>name of  Client</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlCountry
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Country employees Employee</summary>
	[GraphQLField("employees")]
	public List<GqlEmployee> Employees { get; set; }

	/// <summary>name of  Country</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlEmployee
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>_password of  Employee</summary>
	[GraphQLField("_password")]
	public string _password { get; set; }

	/// <summary>_user of  Employee</summary>
	[GraphQLField("_user")]
	public string _user { get; set; }

	/// <summary>dateOfBirth of  Employee</summary>
	[GraphQLField("dateOfBirth")]
	public DateTime? DateOfBirth { get; set; }

	/// <summary>email of  Employee</summary>
	[GraphQLField("email")]
	public string Email { get; set; }

	/// <summary>Employee experience Experience</summary>
	[GraphQLField("experience")]
	public List<GqlExperience> Experience { get; set; }

	/// <summary>gender of  Employee</summary>
	[GraphQLField("gender")]
	public string Gender { get; set; }

	/// <summary>image of  Employee</summary>
	[GraphQLField("image")]
	public string Image { get; set; }

	/// <summary>Employee isMemberOf Team</summary>
	[GraphQLField("isMemberOf")]
	public List<GqlTeam> IsMemberOf { get; set; }

	/// <summary>Employee is_from_ Events</summary>
	[GraphQLField("is_from_")]
	public List<GqlEvents> Is_from_ { get; set; }

	/// <summary>Employee livesIn Country</summary>
	[GraphQLField("livesIn")]
	public List<GqlCountry> LivesIn { get; set; }

	/// <summary>name of  Employee</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>phone of  Employee</summary>
	[GraphQLField("phone")]
	public string Phone { get; set; }

	/// <summary>Employee worksAs Role</summary>
	[GraphQLField("worksAs")]
	public List<GqlRole> WorksAs { get; set; }

	/// <summary>Employee worksFor Client</summary>
	[GraphQLField("worksFor")]
	public List<GqlClient> WorksFor { get; set; }

}

public partial class GqlEvents
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>date of  Events</summary>
	[GraphQLField("date")]
	public DateTime? Date { get; set; }

	/// <summary>description of  Events</summary>
	[GraphQLField("description")]
	public string Description { get; set; }

	/// <summary>Events event_of Project</summary>
	[GraphQLField("event_of")]
	public List<GqlProject> Event_of { get; set; }

	/// <summary>Events is_to Employee</summary>
	[GraphQLField("is_to")]
	public List<GqlEmployee> Is_to { get; set; }

	/// <summary>project of  Events</summary>
	[GraphQLField("project")]
	public string Project { get; set; }

	/// <summary>Events scopes Scope</summary>
	[GraphQLField("scopes")]
	public List<GqlScope> Scopes { get; set; }

	/// <summary>score of  Events</summary>
	[GraphQLField("score")]
	public int? Score { get; set; }

	/// <summary>subject of  Events</summary>
	[GraphQLField("subject")]
	public string Subject { get; set; }

}

public partial class GqlExperience
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Experience employees Employee</summary>
	[GraphQLField("employees")]
	public List<GqlEmployee> Employees { get; set; }

	/// <summary>name of  Experience</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlLearningItem
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>LearningItem content LearningPath</summary>
	[GraphQLField("content")]
	public List<GqlLearningPath> Content { get; set; }

	/// <summary>duration of  LearningItem</summary>
	[GraphQLField("duration")]
	public string Duration { get; set; }

	/// <summary>name of  LearningItem</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>LearningItem next LearningItem</summary>
	[GraphQLField("next")]
	public List<GqlLearningItem> Next { get; set; }

}

public partial class GqlLearningPath
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>description of  LearningPath</summary>
	[GraphQLField("description")]
	public string Description { get; set; }

	/// <summary>LearningPath learnings LearningItem</summary>
	[GraphQLField("learnings")]
	public List<GqlLearningItem> Learnings { get; set; }

	/// <summary>name of  LearningPath</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>LearningPath prerequisite LearningPath</summary>
	[GraphQLField("prerequisite")]
	public List<GqlLearningPath> Prerequisite { get; set; }

	/// <summary>LearningPath tags Tag</summary>
	[GraphQLField("tags")]
	public List<GqlTag> Tags { get; set; }

}

public partial class GqlProject
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>name of  Project</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>Project project Events</summary>
	[GraphQLField("project")]
	public List<GqlEvents> Project { get; set; }

}

public partial class GqlRole
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Role employees Employee</summary>
	[GraphQLField("employees")]
	public List<GqlEmployee> Employees { get; set; }

	/// <summary>Role isRequiredBy Team</summary>
	[GraphQLField("isRequiredBy")]
	public List<GqlTeam> IsRequiredBy { get; set; }

	/// <summary>name of  Role</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlScope
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Scope isScopeOf_ Events</summary>
	[GraphQLField("isScopeOf_")]
	public List<GqlEvents> IsScopeOf_ { get; set; }

	/// <summary>name of  Scope</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlTag
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Tag isTagOf LearningPath</summary>
	[GraphQLField("isTagOf")]
	public List<GqlLearningPath> IsTagOf { get; set; }

	/// <summary>name of  Tag</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

}

public partial class GqlTeam
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Team exp_requeres Experience</summary>
	[GraphQLField("exp_requeres")]
	public List<GqlExperience> Exp_requeres { get; set; }

	/// <summary>Team members Employee</summary>
	[GraphQLField("members")]
	public List<GqlEmployee> Members { get; set; }

	/// <summary>name of  Team</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>Team roles Role</summary>
	[GraphQLField("roles")]
	public List<GqlRole> Roles { get; set; }

}

public class Gql_ClientFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ClientFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ClientFilter> OR { get; set; }

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

	/// <summary>_password</summary>
	[JsonProperty(PropertyName = "_password", NullValueHandling = NullValueHandling.Ignore)]
	public string _password { get; set; }

	/// <summary>_password_contains</summary>
	[JsonProperty(PropertyName = "_password_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_contains { get; set; }

	/// <summary>_password_ends_with</summary>
	[JsonProperty(PropertyName = "_password_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_ends_with { get; set; }

	/// <summary>_password_gt</summary>
	[JsonProperty(PropertyName = "_password_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_gt { get; set; }

	/// <summary>_password_gte</summary>
	[JsonProperty(PropertyName = "_password_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_gte { get; set; }

	/// <summary>_password_in</summary>
	[JsonProperty(PropertyName = "_password_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> _password_in { get; set; }

	/// <summary>_password_lt</summary>
	[JsonProperty(PropertyName = "_password_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_lt { get; set; }

	/// <summary>_password_lte</summary>
	[JsonProperty(PropertyName = "_password_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_lte { get; set; }

	/// <summary>_password_not</summary>
	[JsonProperty(PropertyName = "_password_not", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_not { get; set; }

	/// <summary>_password_not_contains</summary>
	[JsonProperty(PropertyName = "_password_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_not_contains { get; set; }

	/// <summary>_password_not_ends_with</summary>
	[JsonProperty(PropertyName = "_password_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_not_ends_with { get; set; }

	/// <summary>_password_not_in</summary>
	[JsonProperty(PropertyName = "_password_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> _password_not_in { get; set; }

	/// <summary>_password_not_starts_with</summary>
	[JsonProperty(PropertyName = "_password_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_not_starts_with { get; set; }

	/// <summary>_password_starts_with</summary>
	[JsonProperty(PropertyName = "_password_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _password_starts_with { get; set; }

	/// <summary>_user</summary>
	[JsonProperty(PropertyName = "_user", NullValueHandling = NullValueHandling.Ignore)]
	public string _user { get; set; }

	/// <summary>_user_contains</summary>
	[JsonProperty(PropertyName = "_user_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_contains { get; set; }

	/// <summary>_user_ends_with</summary>
	[JsonProperty(PropertyName = "_user_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_ends_with { get; set; }

	/// <summary>_user_gt</summary>
	[JsonProperty(PropertyName = "_user_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_gt { get; set; }

	/// <summary>_user_gte</summary>
	[JsonProperty(PropertyName = "_user_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_gte { get; set; }

	/// <summary>_user_in</summary>
	[JsonProperty(PropertyName = "_user_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> _user_in { get; set; }

	/// <summary>_user_lt</summary>
	[JsonProperty(PropertyName = "_user_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_lt { get; set; }

	/// <summary>_user_lte</summary>
	[JsonProperty(PropertyName = "_user_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_lte { get; set; }

	/// <summary>_user_not</summary>
	[JsonProperty(PropertyName = "_user_not", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_not { get; set; }

	/// <summary>_user_not_contains</summary>
	[JsonProperty(PropertyName = "_user_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_not_contains { get; set; }

	/// <summary>_user_not_ends_with</summary>
	[JsonProperty(PropertyName = "_user_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_not_ends_with { get; set; }

	/// <summary>_user_not_in</summary>
	[JsonProperty(PropertyName = "_user_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> _user_not_in { get; set; }

	/// <summary>_user_not_starts_with</summary>
	[JsonProperty(PropertyName = "_user_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_not_starts_with { get; set; }

	/// <summary>_user_starts_with</summary>
	[JsonProperty(PropertyName = "_user_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string _user_starts_with { get; set; }

	/// <summary>dateOfBirth</summary>
	[JsonProperty(PropertyName = "dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? DateOfBirth { get; set; }

	/// <summary>dateOfBirth_gt</summary>
	[JsonProperty(PropertyName = "dateOfBirth_gt", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? DateOfBirth_gt { get; set; }

	/// <summary>dateOfBirth_gte</summary>
	[JsonProperty(PropertyName = "dateOfBirth_gte", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? DateOfBirth_gte { get; set; }

	/// <summary>dateOfBirth_in</summary>
	[JsonProperty(PropertyName = "dateOfBirth_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<DateTime?> DateOfBirth_in { get; set; }

	/// <summary>dateOfBirth_lt</summary>
	[JsonProperty(PropertyName = "dateOfBirth_lt", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? DateOfBirth_lt { get; set; }

	/// <summary>dateOfBirth_lte</summary>
	[JsonProperty(PropertyName = "dateOfBirth_lte", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? DateOfBirth_lte { get; set; }

	/// <summary>dateOfBirth_not</summary>
	[JsonProperty(PropertyName = "dateOfBirth_not", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? DateOfBirth_not { get; set; }

	/// <summary>dateOfBirth_not_in</summary>
	[JsonProperty(PropertyName = "dateOfBirth_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<DateTime?> DateOfBirth_not_in { get; set; }

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

	/// <summary>experience</summary>
	[JsonProperty(PropertyName = "experience", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience { get; set; }

	/// <summary>experience_every</summary>
	[JsonProperty(PropertyName = "experience_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience_every { get; set; }

	/// <summary>experience_in</summary>
	[JsonProperty(PropertyName = "experience_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience_in { get; set; }

	/// <summary>experience_none</summary>
	[JsonProperty(PropertyName = "experience_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience_none { get; set; }

	/// <summary>experience_not</summary>
	[JsonProperty(PropertyName = "experience_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience_not { get; set; }

	/// <summary>experience_not_in</summary>
	[JsonProperty(PropertyName = "experience_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience_not_in { get; set; }

	/// <summary>experience_single</summary>
	[JsonProperty(PropertyName = "experience_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience_single { get; set; }

	/// <summary>experience_some</summary>
	[JsonProperty(PropertyName = "experience_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Experience_some { get; set; }

	/// <summary>gender</summary>
	[JsonProperty(PropertyName = "gender", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender { get; set; }

	/// <summary>gender_contains</summary>
	[JsonProperty(PropertyName = "gender_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_contains { get; set; }

	/// <summary>gender_ends_with</summary>
	[JsonProperty(PropertyName = "gender_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_ends_with { get; set; }

	/// <summary>gender_gt</summary>
	[JsonProperty(PropertyName = "gender_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_gt { get; set; }

	/// <summary>gender_gte</summary>
	[JsonProperty(PropertyName = "gender_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_gte { get; set; }

	/// <summary>gender_in</summary>
	[JsonProperty(PropertyName = "gender_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Gender_in { get; set; }

	/// <summary>gender_lt</summary>
	[JsonProperty(PropertyName = "gender_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_lt { get; set; }

	/// <summary>gender_lte</summary>
	[JsonProperty(PropertyName = "gender_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_lte { get; set; }

	/// <summary>gender_not</summary>
	[JsonProperty(PropertyName = "gender_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_not { get; set; }

	/// <summary>gender_not_contains</summary>
	[JsonProperty(PropertyName = "gender_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_not_contains { get; set; }

	/// <summary>gender_not_ends_with</summary>
	[JsonProperty(PropertyName = "gender_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_not_ends_with { get; set; }

	/// <summary>gender_not_in</summary>
	[JsonProperty(PropertyName = "gender_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Gender_not_in { get; set; }

	/// <summary>gender_not_starts_with</summary>
	[JsonProperty(PropertyName = "gender_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_not_starts_with { get; set; }

	/// <summary>gender_starts_with</summary>
	[JsonProperty(PropertyName = "gender_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Gender_starts_with { get; set; }

	/// <summary>image</summary>
	[JsonProperty(PropertyName = "image", NullValueHandling = NullValueHandling.Ignore)]
	public string Image { get; set; }

	/// <summary>image_contains</summary>
	[JsonProperty(PropertyName = "image_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_contains { get; set; }

	/// <summary>image_ends_with</summary>
	[JsonProperty(PropertyName = "image_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_ends_with { get; set; }

	/// <summary>image_gt</summary>
	[JsonProperty(PropertyName = "image_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_gt { get; set; }

	/// <summary>image_gte</summary>
	[JsonProperty(PropertyName = "image_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_gte { get; set; }

	/// <summary>image_in</summary>
	[JsonProperty(PropertyName = "image_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Image_in { get; set; }

	/// <summary>image_lt</summary>
	[JsonProperty(PropertyName = "image_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_lt { get; set; }

	/// <summary>image_lte</summary>
	[JsonProperty(PropertyName = "image_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_lte { get; set; }

	/// <summary>image_not</summary>
	[JsonProperty(PropertyName = "image_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_not { get; set; }

	/// <summary>image_not_contains</summary>
	[JsonProperty(PropertyName = "image_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_not_contains { get; set; }

	/// <summary>image_not_ends_with</summary>
	[JsonProperty(PropertyName = "image_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_not_ends_with { get; set; }

	/// <summary>image_not_in</summary>
	[JsonProperty(PropertyName = "image_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Image_not_in { get; set; }

	/// <summary>image_not_starts_with</summary>
	[JsonProperty(PropertyName = "image_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_not_starts_with { get; set; }

	/// <summary>image_starts_with</summary>
	[JsonProperty(PropertyName = "image_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Image_starts_with { get; set; }

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

	/// <summary>is_from_</summary>
	[JsonProperty(PropertyName = "is_from_", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from_ { get; set; }

	/// <summary>is_from__every</summary>
	[JsonProperty(PropertyName = "is_from__every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from__every { get; set; }

	/// <summary>is_from__in</summary>
	[JsonProperty(PropertyName = "is_from__in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from__in { get; set; }

	/// <summary>is_from__none</summary>
	[JsonProperty(PropertyName = "is_from__none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from__none { get; set; }

	/// <summary>is_from__not</summary>
	[JsonProperty(PropertyName = "is_from__not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from__not { get; set; }

	/// <summary>is_from__not_in</summary>
	[JsonProperty(PropertyName = "is_from__not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from__not_in { get; set; }

	/// <summary>is_from__single</summary>
	[JsonProperty(PropertyName = "is_from__single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from__single { get; set; }

	/// <summary>is_from__some</summary>
	[JsonProperty(PropertyName = "is_from__some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Is_from__some { get; set; }

	/// <summary>livesIn</summary>
	[JsonProperty(PropertyName = "livesIn", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn { get; set; }

	/// <summary>livesIn_every</summary>
	[JsonProperty(PropertyName = "livesIn_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_every { get; set; }

	/// <summary>livesIn_in</summary>
	[JsonProperty(PropertyName = "livesIn_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_in { get; set; }

	/// <summary>livesIn_none</summary>
	[JsonProperty(PropertyName = "livesIn_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_none { get; set; }

	/// <summary>livesIn_not</summary>
	[JsonProperty(PropertyName = "livesIn_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_not { get; set; }

	/// <summary>livesIn_not_in</summary>
	[JsonProperty(PropertyName = "livesIn_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_not_in { get; set; }

	/// <summary>livesIn_single</summary>
	[JsonProperty(PropertyName = "livesIn_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_single { get; set; }

	/// <summary>livesIn_some</summary>
	[JsonProperty(PropertyName = "livesIn_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_CountryFilter LivesIn_some { get; set; }

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

	/// <summary>phone</summary>
	[JsonProperty(PropertyName = "phone", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone { get; set; }

	/// <summary>phone_contains</summary>
	[JsonProperty(PropertyName = "phone_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_contains { get; set; }

	/// <summary>phone_ends_with</summary>
	[JsonProperty(PropertyName = "phone_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_ends_with { get; set; }

	/// <summary>phone_gt</summary>
	[JsonProperty(PropertyName = "phone_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_gt { get; set; }

	/// <summary>phone_gte</summary>
	[JsonProperty(PropertyName = "phone_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_gte { get; set; }

	/// <summary>phone_in</summary>
	[JsonProperty(PropertyName = "phone_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Phone_in { get; set; }

	/// <summary>phone_lt</summary>
	[JsonProperty(PropertyName = "phone_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_lt { get; set; }

	/// <summary>phone_lte</summary>
	[JsonProperty(PropertyName = "phone_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_lte { get; set; }

	/// <summary>phone_not</summary>
	[JsonProperty(PropertyName = "phone_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_not { get; set; }

	/// <summary>phone_not_contains</summary>
	[JsonProperty(PropertyName = "phone_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_not_contains { get; set; }

	/// <summary>phone_not_ends_with</summary>
	[JsonProperty(PropertyName = "phone_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_not_ends_with { get; set; }

	/// <summary>phone_not_in</summary>
	[JsonProperty(PropertyName = "phone_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Phone_not_in { get; set; }

	/// <summary>phone_not_starts_with</summary>
	[JsonProperty(PropertyName = "phone_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_not_starts_with { get; set; }

	/// <summary>phone_starts_with</summary>
	[JsonProperty(PropertyName = "phone_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Phone_starts_with { get; set; }

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

	/// <summary>worksFor_every</summary>
	[JsonProperty(PropertyName = "worksFor_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_every { get; set; }

	/// <summary>worksFor_in</summary>
	[JsonProperty(PropertyName = "worksFor_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_in { get; set; }

	/// <summary>worksFor_none</summary>
	[JsonProperty(PropertyName = "worksFor_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_none { get; set; }

	/// <summary>worksFor_not</summary>
	[JsonProperty(PropertyName = "worksFor_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_not { get; set; }

	/// <summary>worksFor_not_in</summary>
	[JsonProperty(PropertyName = "worksFor_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_not_in { get; set; }

	/// <summary>worksFor_single</summary>
	[JsonProperty(PropertyName = "worksFor_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_single { get; set; }

	/// <summary>worksFor_some</summary>
	[JsonProperty(PropertyName = "worksFor_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ClientFilter WorksFor_some { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_EmployeeOrdering
{
	/// <summary>Ascending sort for _password</summary>
	_password_asc,
	/// <summary>Descending sort for _password</summary>
	_password_desc,
	/// <summary>Ascending sort for _user</summary>
	_user_asc,
	/// <summary>Descending sort for _user</summary>
	_user_desc,
	/// <summary>Ascending sort for dateOfBirth</summary>
	dateOfBirth_asc,
	/// <summary>Descending sort for dateOfBirth</summary>
	dateOfBirth_desc,
	/// <summary>Ascending sort for email</summary>
	email_asc,
	/// <summary>Descending sort for email</summary>
	email_desc,
	/// <summary>Ascending sort for gender</summary>
	gender_asc,
	/// <summary>Descending sort for gender</summary>
	gender_desc,
	/// <summary>Ascending sort for image</summary>
	image_asc,
	/// <summary>Descending sort for image</summary>
	image_desc,
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc,
	/// <summary>Ascending sort for phone</summary>
	phone_asc,
	/// <summary>Descending sort for phone</summary>
	phone_desc
}

public class Gql_EventsFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_EventsFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_EventsFilter> OR { get; set; }

	/// <summary>date</summary>
	[JsonProperty(PropertyName = "date", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? Date { get; set; }

	/// <summary>date_gt</summary>
	[JsonProperty(PropertyName = "date_gt", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? Date_gt { get; set; }

	/// <summary>date_gte</summary>
	[JsonProperty(PropertyName = "date_gte", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? Date_gte { get; set; }

	/// <summary>date_in</summary>
	[JsonProperty(PropertyName = "date_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<DateTime?> Date_in { get; set; }

	/// <summary>date_lt</summary>
	[JsonProperty(PropertyName = "date_lt", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? Date_lt { get; set; }

	/// <summary>date_lte</summary>
	[JsonProperty(PropertyName = "date_lte", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? Date_lte { get; set; }

	/// <summary>date_not</summary>
	[JsonProperty(PropertyName = "date_not", NullValueHandling = NullValueHandling.Ignore)]
	public DateTime? Date_not { get; set; }

	/// <summary>date_not_in</summary>
	[JsonProperty(PropertyName = "date_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<DateTime?> Date_not_in { get; set; }

	/// <summary>description</summary>
	[JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
	public string Description { get; set; }

	/// <summary>description_contains</summary>
	[JsonProperty(PropertyName = "description_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_contains { get; set; }

	/// <summary>description_ends_with</summary>
	[JsonProperty(PropertyName = "description_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_ends_with { get; set; }

	/// <summary>description_gt</summary>
	[JsonProperty(PropertyName = "description_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_gt { get; set; }

	/// <summary>description_gte</summary>
	[JsonProperty(PropertyName = "description_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_gte { get; set; }

	/// <summary>description_in</summary>
	[JsonProperty(PropertyName = "description_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Description_in { get; set; }

	/// <summary>description_lt</summary>
	[JsonProperty(PropertyName = "description_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_lt { get; set; }

	/// <summary>description_lte</summary>
	[JsonProperty(PropertyName = "description_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_lte { get; set; }

	/// <summary>description_not</summary>
	[JsonProperty(PropertyName = "description_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not { get; set; }

	/// <summary>description_not_contains</summary>
	[JsonProperty(PropertyName = "description_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not_contains { get; set; }

	/// <summary>description_not_ends_with</summary>
	[JsonProperty(PropertyName = "description_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not_ends_with { get; set; }

	/// <summary>description_not_in</summary>
	[JsonProperty(PropertyName = "description_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Description_not_in { get; set; }

	/// <summary>description_not_starts_with</summary>
	[JsonProperty(PropertyName = "description_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not_starts_with { get; set; }

	/// <summary>description_starts_with</summary>
	[JsonProperty(PropertyName = "description_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_starts_with { get; set; }

	/// <summary>event_of</summary>
	[JsonProperty(PropertyName = "event_of", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of { get; set; }

	/// <summary>event_of_every</summary>
	[JsonProperty(PropertyName = "event_of_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of_every { get; set; }

	/// <summary>event_of_in</summary>
	[JsonProperty(PropertyName = "event_of_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of_in { get; set; }

	/// <summary>event_of_none</summary>
	[JsonProperty(PropertyName = "event_of_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of_none { get; set; }

	/// <summary>event_of_not</summary>
	[JsonProperty(PropertyName = "event_of_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of_not { get; set; }

	/// <summary>event_of_not_in</summary>
	[JsonProperty(PropertyName = "event_of_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of_not_in { get; set; }

	/// <summary>event_of_single</summary>
	[JsonProperty(PropertyName = "event_of_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of_single { get; set; }

	/// <summary>event_of_some</summary>
	[JsonProperty(PropertyName = "event_of_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ProjectFilter Event_of_some { get; set; }

	/// <summary>is_to</summary>
	[JsonProperty(PropertyName = "is_to", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to { get; set; }

	/// <summary>is_to_every</summary>
	[JsonProperty(PropertyName = "is_to_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to_every { get; set; }

	/// <summary>is_to_in</summary>
	[JsonProperty(PropertyName = "is_to_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to_in { get; set; }

	/// <summary>is_to_none</summary>
	[JsonProperty(PropertyName = "is_to_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to_none { get; set; }

	/// <summary>is_to_not</summary>
	[JsonProperty(PropertyName = "is_to_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to_not { get; set; }

	/// <summary>is_to_not_in</summary>
	[JsonProperty(PropertyName = "is_to_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to_not_in { get; set; }

	/// <summary>is_to_single</summary>
	[JsonProperty(PropertyName = "is_to_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to_single { get; set; }

	/// <summary>is_to_some</summary>
	[JsonProperty(PropertyName = "is_to_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Is_to_some { get; set; }

	/// <summary>project</summary>
	[JsonProperty(PropertyName = "project", NullValueHandling = NullValueHandling.Ignore)]
	public string Project { get; set; }

	/// <summary>project_contains</summary>
	[JsonProperty(PropertyName = "project_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_contains { get; set; }

	/// <summary>project_ends_with</summary>
	[JsonProperty(PropertyName = "project_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_ends_with { get; set; }

	/// <summary>project_gt</summary>
	[JsonProperty(PropertyName = "project_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_gt { get; set; }

	/// <summary>project_gte</summary>
	[JsonProperty(PropertyName = "project_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_gte { get; set; }

	/// <summary>project_in</summary>
	[JsonProperty(PropertyName = "project_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Project_in { get; set; }

	/// <summary>project_lt</summary>
	[JsonProperty(PropertyName = "project_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_lt { get; set; }

	/// <summary>project_lte</summary>
	[JsonProperty(PropertyName = "project_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_lte { get; set; }

	/// <summary>project_not</summary>
	[JsonProperty(PropertyName = "project_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_not { get; set; }

	/// <summary>project_not_contains</summary>
	[JsonProperty(PropertyName = "project_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_not_contains { get; set; }

	/// <summary>project_not_ends_with</summary>
	[JsonProperty(PropertyName = "project_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_not_ends_with { get; set; }

	/// <summary>project_not_in</summary>
	[JsonProperty(PropertyName = "project_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Project_not_in { get; set; }

	/// <summary>project_not_starts_with</summary>
	[JsonProperty(PropertyName = "project_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_not_starts_with { get; set; }

	/// <summary>project_starts_with</summary>
	[JsonProperty(PropertyName = "project_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Project_starts_with { get; set; }

	/// <summary>scopes</summary>
	[JsonProperty(PropertyName = "scopes", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes { get; set; }

	/// <summary>scopes_every</summary>
	[JsonProperty(PropertyName = "scopes_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes_every { get; set; }

	/// <summary>scopes_in</summary>
	[JsonProperty(PropertyName = "scopes_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes_in { get; set; }

	/// <summary>scopes_none</summary>
	[JsonProperty(PropertyName = "scopes_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes_none { get; set; }

	/// <summary>scopes_not</summary>
	[JsonProperty(PropertyName = "scopes_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes_not { get; set; }

	/// <summary>scopes_not_in</summary>
	[JsonProperty(PropertyName = "scopes_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes_not_in { get; set; }

	/// <summary>scopes_single</summary>
	[JsonProperty(PropertyName = "scopes_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes_single { get; set; }

	/// <summary>scopes_some</summary>
	[JsonProperty(PropertyName = "scopes_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ScopeFilter Scopes_some { get; set; }

	/// <summary>score</summary>
	[JsonProperty(PropertyName = "score", NullValueHandling = NullValueHandling.Ignore)]
	public int? Score { get; set; }

	/// <summary>score_gt</summary>
	[JsonProperty(PropertyName = "score_gt", NullValueHandling = NullValueHandling.Ignore)]
	public int? Score_gt { get; set; }

	/// <summary>score_gte</summary>
	[JsonProperty(PropertyName = "score_gte", NullValueHandling = NullValueHandling.Ignore)]
	public int? Score_gte { get; set; }

	/// <summary>score_in</summary>
	[JsonProperty(PropertyName = "score_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<int?> Score_in { get; set; }

	/// <summary>score_lt</summary>
	[JsonProperty(PropertyName = "score_lt", NullValueHandling = NullValueHandling.Ignore)]
	public int? Score_lt { get; set; }

	/// <summary>score_lte</summary>
	[JsonProperty(PropertyName = "score_lte", NullValueHandling = NullValueHandling.Ignore)]
	public int? Score_lte { get; set; }

	/// <summary>score_not</summary>
	[JsonProperty(PropertyName = "score_not", NullValueHandling = NullValueHandling.Ignore)]
	public int? Score_not { get; set; }

	/// <summary>score_not_in</summary>
	[JsonProperty(PropertyName = "score_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<int?> Score_not_in { get; set; }

	/// <summary>subject</summary>
	[JsonProperty(PropertyName = "subject", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject { get; set; }

	/// <summary>subject_contains</summary>
	[JsonProperty(PropertyName = "subject_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_contains { get; set; }

	/// <summary>subject_ends_with</summary>
	[JsonProperty(PropertyName = "subject_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_ends_with { get; set; }

	/// <summary>subject_gt</summary>
	[JsonProperty(PropertyName = "subject_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_gt { get; set; }

	/// <summary>subject_gte</summary>
	[JsonProperty(PropertyName = "subject_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_gte { get; set; }

	/// <summary>subject_in</summary>
	[JsonProperty(PropertyName = "subject_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Subject_in { get; set; }

	/// <summary>subject_lt</summary>
	[JsonProperty(PropertyName = "subject_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_lt { get; set; }

	/// <summary>subject_lte</summary>
	[JsonProperty(PropertyName = "subject_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_lte { get; set; }

	/// <summary>subject_not</summary>
	[JsonProperty(PropertyName = "subject_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_not { get; set; }

	/// <summary>subject_not_contains</summary>
	[JsonProperty(PropertyName = "subject_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_not_contains { get; set; }

	/// <summary>subject_not_ends_with</summary>
	[JsonProperty(PropertyName = "subject_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_not_ends_with { get; set; }

	/// <summary>subject_not_in</summary>
	[JsonProperty(PropertyName = "subject_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Subject_not_in { get; set; }

	/// <summary>subject_not_starts_with</summary>
	[JsonProperty(PropertyName = "subject_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_not_starts_with { get; set; }

	/// <summary>subject_starts_with</summary>
	[JsonProperty(PropertyName = "subject_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Subject_starts_with { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_EventsOrdering
{
	/// <summary>Ascending sort for date</summary>
	date_asc,
	/// <summary>Descending sort for date</summary>
	date_desc,
	/// <summary>Ascending sort for description</summary>
	description_asc,
	/// <summary>Descending sort for description</summary>
	description_desc,
	/// <summary>Ascending sort for project</summary>
	project_asc,
	/// <summary>Descending sort for project</summary>
	project_desc,
	/// <summary>Ascending sort for score</summary>
	score_asc,
	/// <summary>Descending sort for score</summary>
	score_desc,
	/// <summary>Ascending sort for subject</summary>
	subject_asc,
	/// <summary>Descending sort for subject</summary>
	subject_desc
}

public class Gql_ExperienceFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ExperienceFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ExperienceFilter> OR { get; set; }

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
public enum Gql_ExperienceOrdering
{
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_LearningItemFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_LearningItemFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_LearningItemFilter> OR { get; set; }

	/// <summary>content</summary>
	[JsonProperty(PropertyName = "content", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content { get; set; }

	/// <summary>content_every</summary>
	[JsonProperty(PropertyName = "content_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_every { get; set; }

	/// <summary>content_in</summary>
	[JsonProperty(PropertyName = "content_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_in { get; set; }

	/// <summary>content_none</summary>
	[JsonProperty(PropertyName = "content_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_none { get; set; }

	/// <summary>content_not</summary>
	[JsonProperty(PropertyName = "content_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_not { get; set; }

	/// <summary>content_not_in</summary>
	[JsonProperty(PropertyName = "content_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_not_in { get; set; }

	/// <summary>content_single</summary>
	[JsonProperty(PropertyName = "content_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_single { get; set; }

	/// <summary>content_some</summary>
	[JsonProperty(PropertyName = "content_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_some { get; set; }

	/// <summary>duration</summary>
	[JsonProperty(PropertyName = "duration", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration { get; set; }

	/// <summary>duration_contains</summary>
	[JsonProperty(PropertyName = "duration_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_contains { get; set; }

	/// <summary>duration_ends_with</summary>
	[JsonProperty(PropertyName = "duration_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_ends_with { get; set; }

	/// <summary>duration_gt</summary>
	[JsonProperty(PropertyName = "duration_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_gt { get; set; }

	/// <summary>duration_gte</summary>
	[JsonProperty(PropertyName = "duration_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_gte { get; set; }

	/// <summary>duration_in</summary>
	[JsonProperty(PropertyName = "duration_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Duration_in { get; set; }

	/// <summary>duration_lt</summary>
	[JsonProperty(PropertyName = "duration_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_lt { get; set; }

	/// <summary>duration_lte</summary>
	[JsonProperty(PropertyName = "duration_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_lte { get; set; }

	/// <summary>duration_not</summary>
	[JsonProperty(PropertyName = "duration_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_not { get; set; }

	/// <summary>duration_not_contains</summary>
	[JsonProperty(PropertyName = "duration_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_not_contains { get; set; }

	/// <summary>duration_not_ends_with</summary>
	[JsonProperty(PropertyName = "duration_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_not_ends_with { get; set; }

	/// <summary>duration_not_in</summary>
	[JsonProperty(PropertyName = "duration_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Duration_not_in { get; set; }

	/// <summary>duration_not_starts_with</summary>
	[JsonProperty(PropertyName = "duration_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_not_starts_with { get; set; }

	/// <summary>duration_starts_with</summary>
	[JsonProperty(PropertyName = "duration_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Duration_starts_with { get; set; }

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

	/// <summary>next</summary>
	[JsonProperty(PropertyName = "next", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next { get; set; }

	/// <summary>next_every</summary>
	[JsonProperty(PropertyName = "next_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_every { get; set; }

	/// <summary>next_in</summary>
	[JsonProperty(PropertyName = "next_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_in { get; set; }

	/// <summary>next_none</summary>
	[JsonProperty(PropertyName = "next_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_none { get; set; }

	/// <summary>next_not</summary>
	[JsonProperty(PropertyName = "next_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_not { get; set; }

	/// <summary>next_not_in</summary>
	[JsonProperty(PropertyName = "next_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_not_in { get; set; }

	/// <summary>next_single</summary>
	[JsonProperty(PropertyName = "next_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_single { get; set; }

	/// <summary>next_some</summary>
	[JsonProperty(PropertyName = "next_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_some { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_LearningItemOrdering
{
	/// <summary>Ascending sort for duration</summary>
	duration_asc,
	/// <summary>Descending sort for duration</summary>
	duration_desc,
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_LearningPathFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_LearningPathFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_LearningPathFilter> OR { get; set; }

	/// <summary>description</summary>
	[JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
	public string Description { get; set; }

	/// <summary>description_contains</summary>
	[JsonProperty(PropertyName = "description_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_contains { get; set; }

	/// <summary>description_ends_with</summary>
	[JsonProperty(PropertyName = "description_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_ends_with { get; set; }

	/// <summary>description_gt</summary>
	[JsonProperty(PropertyName = "description_gt", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_gt { get; set; }

	/// <summary>description_gte</summary>
	[JsonProperty(PropertyName = "description_gte", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_gte { get; set; }

	/// <summary>description_in</summary>
	[JsonProperty(PropertyName = "description_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Description_in { get; set; }

	/// <summary>description_lt</summary>
	[JsonProperty(PropertyName = "description_lt", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_lt { get; set; }

	/// <summary>description_lte</summary>
	[JsonProperty(PropertyName = "description_lte", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_lte { get; set; }

	/// <summary>description_not</summary>
	[JsonProperty(PropertyName = "description_not", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not { get; set; }

	/// <summary>description_not_contains</summary>
	[JsonProperty(PropertyName = "description_not_contains", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not_contains { get; set; }

	/// <summary>description_not_ends_with</summary>
	[JsonProperty(PropertyName = "description_not_ends_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not_ends_with { get; set; }

	/// <summary>description_not_in</summary>
	[JsonProperty(PropertyName = "description_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public List<string> Description_not_in { get; set; }

	/// <summary>description_not_starts_with</summary>
	[JsonProperty(PropertyName = "description_not_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_not_starts_with { get; set; }

	/// <summary>description_starts_with</summary>
	[JsonProperty(PropertyName = "description_starts_with", NullValueHandling = NullValueHandling.Ignore)]
	public string Description_starts_with { get; set; }

	/// <summary>learnings</summary>
	[JsonProperty(PropertyName = "learnings", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings { get; set; }

	/// <summary>learnings_every</summary>
	[JsonProperty(PropertyName = "learnings_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings_every { get; set; }

	/// <summary>learnings_in</summary>
	[JsonProperty(PropertyName = "learnings_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings_in { get; set; }

	/// <summary>learnings_none</summary>
	[JsonProperty(PropertyName = "learnings_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings_none { get; set; }

	/// <summary>learnings_not</summary>
	[JsonProperty(PropertyName = "learnings_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings_not { get; set; }

	/// <summary>learnings_not_in</summary>
	[JsonProperty(PropertyName = "learnings_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings_not_in { get; set; }

	/// <summary>learnings_single</summary>
	[JsonProperty(PropertyName = "learnings_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings_single { get; set; }

	/// <summary>learnings_some</summary>
	[JsonProperty(PropertyName = "learnings_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Learnings_some { get; set; }

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

	/// <summary>prerequisite</summary>
	[JsonProperty(PropertyName = "prerequisite", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite { get; set; }

	/// <summary>prerequisite_every</summary>
	[JsonProperty(PropertyName = "prerequisite_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite_every { get; set; }

	/// <summary>prerequisite_in</summary>
	[JsonProperty(PropertyName = "prerequisite_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite_in { get; set; }

	/// <summary>prerequisite_none</summary>
	[JsonProperty(PropertyName = "prerequisite_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite_none { get; set; }

	/// <summary>prerequisite_not</summary>
	[JsonProperty(PropertyName = "prerequisite_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite_not { get; set; }

	/// <summary>prerequisite_not_in</summary>
	[JsonProperty(PropertyName = "prerequisite_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite_not_in { get; set; }

	/// <summary>prerequisite_single</summary>
	[JsonProperty(PropertyName = "prerequisite_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite_single { get; set; }

	/// <summary>prerequisite_some</summary>
	[JsonProperty(PropertyName = "prerequisite_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Prerequisite_some { get; set; }

	/// <summary>tags</summary>
	[JsonProperty(PropertyName = "tags", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags { get; set; }

	/// <summary>tags_every</summary>
	[JsonProperty(PropertyName = "tags_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags_every { get; set; }

	/// <summary>tags_in</summary>
	[JsonProperty(PropertyName = "tags_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags_in { get; set; }

	/// <summary>tags_none</summary>
	[JsonProperty(PropertyName = "tags_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags_none { get; set; }

	/// <summary>tags_not</summary>
	[JsonProperty(PropertyName = "tags_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags_not { get; set; }

	/// <summary>tags_not_in</summary>
	[JsonProperty(PropertyName = "tags_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags_not_in { get; set; }

	/// <summary>tags_single</summary>
	[JsonProperty(PropertyName = "tags_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags_single { get; set; }

	/// <summary>tags_some</summary>
	[JsonProperty(PropertyName = "tags_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TagFilter Tags_some { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_LearningPathOrdering
{
	/// <summary>Ascending sort for description</summary>
	description_asc,
	/// <summary>Descending sort for description</summary>
	description_desc,
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_ProjectFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ProjectFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ProjectFilter> OR { get; set; }

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

	/// <summary>project</summary>
	[JsonProperty(PropertyName = "project", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project { get; set; }

	/// <summary>project_every</summary>
	[JsonProperty(PropertyName = "project_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project_every { get; set; }

	/// <summary>project_in</summary>
	[JsonProperty(PropertyName = "project_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project_in { get; set; }

	/// <summary>project_none</summary>
	[JsonProperty(PropertyName = "project_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project_none { get; set; }

	/// <summary>project_not</summary>
	[JsonProperty(PropertyName = "project_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project_not { get; set; }

	/// <summary>project_not_in</summary>
	[JsonProperty(PropertyName = "project_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project_not_in { get; set; }

	/// <summary>project_single</summary>
	[JsonProperty(PropertyName = "project_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project_single { get; set; }

	/// <summary>project_some</summary>
	[JsonProperty(PropertyName = "project_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter Project_some { get; set; }

}

[JsonConverter(typeof(GraphQLEnumConverter))]
public enum Gql_ProjectOrdering
{
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

	/// <summary>isRequiredBy</summary>
	[JsonProperty(PropertyName = "isRequiredBy", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy { get; set; }

	/// <summary>isRequiredBy_every</summary>
	[JsonProperty(PropertyName = "isRequiredBy_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy_every { get; set; }

	/// <summary>isRequiredBy_in</summary>
	[JsonProperty(PropertyName = "isRequiredBy_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy_in { get; set; }

	/// <summary>isRequiredBy_none</summary>
	[JsonProperty(PropertyName = "isRequiredBy_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy_none { get; set; }

	/// <summary>isRequiredBy_not</summary>
	[JsonProperty(PropertyName = "isRequiredBy_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy_not { get; set; }

	/// <summary>isRequiredBy_not_in</summary>
	[JsonProperty(PropertyName = "isRequiredBy_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy_not_in { get; set; }

	/// <summary>isRequiredBy_single</summary>
	[JsonProperty(PropertyName = "isRequiredBy_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy_single { get; set; }

	/// <summary>isRequiredBy_some</summary>
	[JsonProperty(PropertyName = "isRequiredBy_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsRequiredBy_some { get; set; }

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

public class Gql_ScopeFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ScopeFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_ScopeFilter> OR { get; set; }

	/// <summary>isScopeOf_</summary>
	[JsonProperty(PropertyName = "isScopeOf_", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf_ { get; set; }

	/// <summary>isScopeOf__every</summary>
	[JsonProperty(PropertyName = "isScopeOf__every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf__every { get; set; }

	/// <summary>isScopeOf__in</summary>
	[JsonProperty(PropertyName = "isScopeOf__in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf__in { get; set; }

	/// <summary>isScopeOf__none</summary>
	[JsonProperty(PropertyName = "isScopeOf__none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf__none { get; set; }

	/// <summary>isScopeOf__not</summary>
	[JsonProperty(PropertyName = "isScopeOf__not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf__not { get; set; }

	/// <summary>isScopeOf__not_in</summary>
	[JsonProperty(PropertyName = "isScopeOf__not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf__not_in { get; set; }

	/// <summary>isScopeOf__single</summary>
	[JsonProperty(PropertyName = "isScopeOf__single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf__single { get; set; }

	/// <summary>isScopeOf__some</summary>
	[JsonProperty(PropertyName = "isScopeOf__some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EventsFilter IsScopeOf__some { get; set; }

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
public enum Gql_ScopeOrdering
{
	/// <summary>Ascending sort for name</summary>
	name_asc,
	/// <summary>Descending sort for name</summary>
	name_desc
}

public class Gql_TagFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_TagFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_TagFilter> OR { get; set; }

	/// <summary>isTagOf</summary>
	[JsonProperty(PropertyName = "isTagOf", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf { get; set; }

	/// <summary>isTagOf_every</summary>
	[JsonProperty(PropertyName = "isTagOf_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf_every { get; set; }

	/// <summary>isTagOf_in</summary>
	[JsonProperty(PropertyName = "isTagOf_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf_in { get; set; }

	/// <summary>isTagOf_none</summary>
	[JsonProperty(PropertyName = "isTagOf_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf_none { get; set; }

	/// <summary>isTagOf_not</summary>
	[JsonProperty(PropertyName = "isTagOf_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf_not { get; set; }

	/// <summary>isTagOf_not_in</summary>
	[JsonProperty(PropertyName = "isTagOf_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf_not_in { get; set; }

	/// <summary>isTagOf_single</summary>
	[JsonProperty(PropertyName = "isTagOf_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf_single { get; set; }

	/// <summary>isTagOf_some</summary>
	[JsonProperty(PropertyName = "isTagOf_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsTagOf_some { get; set; }

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
public enum Gql_TagOrdering
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

	/// <summary>exp_requeres</summary>
	[JsonProperty(PropertyName = "exp_requeres", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres { get; set; }

	/// <summary>exp_requeres_every</summary>
	[JsonProperty(PropertyName = "exp_requeres_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres_every { get; set; }

	/// <summary>exp_requeres_in</summary>
	[JsonProperty(PropertyName = "exp_requeres_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres_in { get; set; }

	/// <summary>exp_requeres_none</summary>
	[JsonProperty(PropertyName = "exp_requeres_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres_none { get; set; }

	/// <summary>exp_requeres_not</summary>
	[JsonProperty(PropertyName = "exp_requeres_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres_not { get; set; }

	/// <summary>exp_requeres_not_in</summary>
	[JsonProperty(PropertyName = "exp_requeres_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres_not_in { get; set; }

	/// <summary>exp_requeres_single</summary>
	[JsonProperty(PropertyName = "exp_requeres_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres_single { get; set; }

	/// <summary>exp_requeres_some</summary>
	[JsonProperty(PropertyName = "exp_requeres_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_ExperienceFilter Exp_requeres_some { get; set; }

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

	/// <summary>roles</summary>
	[JsonProperty(PropertyName = "roles", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles { get; set; }

	/// <summary>roles_every</summary>
	[JsonProperty(PropertyName = "roles_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles_every { get; set; }

	/// <summary>roles_in</summary>
	[JsonProperty(PropertyName = "roles_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles_in { get; set; }

	/// <summary>roles_none</summary>
	[JsonProperty(PropertyName = "roles_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles_none { get; set; }

	/// <summary>roles_not</summary>
	[JsonProperty(PropertyName = "roles_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles_not { get; set; }

	/// <summary>roles_not_in</summary>
	[JsonProperty(PropertyName = "roles_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles_not_in { get; set; }

	/// <summary>roles_single</summary>
	[JsonProperty(PropertyName = "roles_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles_single { get; set; }

	/// <summary>roles_some</summary>
	[JsonProperty(PropertyName = "roles_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Roles_some { get; set; }

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
		return new GraphQLQuery<GqlClient>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Country</param>
	/// <param name="names">names is list variant of name of Country</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Country")]
	public GraphQLQuery<GqlCountry> Country (string sessionToken, long? _id = null, long?[] _ids = null, Gql_CountryFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_CountryOrdering[] orderBy = null, Func<GqlCountry, GqlCountry> fields = null ) 
	{
		return new GraphQLQuery<GqlCountry>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="_password">_password of Employee</param>
	/// <param name="_passwords">_passwords is list variant of _password of Employee</param>
	/// <param name="_user">_user of Employee</param>
	/// <param name="_users">_users is list variant of _user of Employee</param>
	/// <param name="dateOfBirth">dateOfBirth of Employee</param>
	/// <param name="dateOfBirths">dateOfBirths is list variant of dateOfBirth of Employee</param>
	/// <param name="email">email of Employee</param>
	/// <param name="emails">emails is list variant of email of Employee</param>
	/// <param name="gender">gender of Employee</param>
	/// <param name="genders">genders is list variant of gender of Employee</param>
	/// <param name="image">image of Employee</param>
	/// <param name="images">images is list variant of image of Employee</param>
	/// <param name="name">name of Employee</param>
	/// <param name="names">names is list variant of name of Employee</param>
	/// <param name="phone">phone of Employee</param>
	/// <param name="phones">phones is list variant of phone of Employee</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Employee")]
	public GraphQLQuery<GqlEmployee> Employee (string sessionToken, long? _id = null, long?[] _ids = null, string _password = null, string[] _passwords = null, string _user = null, string[] _users = null, DateTime? dateOfBirth = null, DateTime?[] dateOfBirths = null, string email = null, string[] emails = null, Gql_EmployeeFilter filter = null, int? first = null, string gender = null, string[] genders = null, string image = null, string[] images = null, string name = null, string[] names = null, int? offset = null, Gql_EmployeeOrdering[] orderBy = null, string phone = null, string[] phones = null, Func<GqlEmployee, GqlEmployee> fields = null ) 
	{
		return new GraphQLQuery<GqlEmployee>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, _password, _passwords, _user, _users, dateOfBirth, dateOfBirths, email, emails, filter, first, gender, genders, image, images, name, names, offset, orderBy, phone, phones);
	}

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("EmployeeCount")]
	public GraphQLQuery<int?> EmployeeCount (string sessionToken, Func<int?, int?> fields = null ) 
	{
		return new GraphQLQuery<int?>(_httpClient, _endpoint, false, false, MethodBase.GetCurrentMethod(), fields, sessionToken
);
	}

	/// <param name="date">date of Events</param>
	/// <param name="dates">dates is list variant of date of Events</param>
	/// <param name="description">description of Events</param>
	/// <param name="descriptions">descriptions is list variant of description of Events</param>
	/// <param name="project">project of Events</param>
	/// <param name="projects">projects is list variant of project of Events</param>
	/// <param name="score">score of Events</param>
	/// <param name="scores">scores is list variant of score of Events</param>
	/// <param name="subject">subject of Events</param>
	/// <param name="subjects">subjects is list variant of subject of Events</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Events")]
	public GraphQLQuery<GqlEvents> Events (string sessionToken, long? _id = null, long?[] _ids = null, DateTime? date = null, DateTime?[] dates = null, string description = null, string[] descriptions = null, Gql_EventsFilter filter = null, int? first = null, int? offset = null, Gql_EventsOrdering[] orderBy = null, string project = null, string[] projects = null, int? score = null, int?[] scores = null, string subject = null, string[] subjects = null, Func<GqlEvents, GqlEvents> fields = null ) 
	{
		return new GraphQLQuery<GqlEvents>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, date, dates, description, descriptions, filter, first, offset, orderBy, project, projects, score, scores, subject, subjects);
	}

	/// <param name="name">name of Experience</param>
	/// <param name="names">names is list variant of name of Experience</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Experience")]
	public GraphQLQuery<GqlExperience> Experience (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ExperienceFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ExperienceOrdering[] orderBy = null, Func<GqlExperience, GqlExperience> fields = null ) 
	{
		return new GraphQLQuery<GqlExperience>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="duration">duration of LearningItem</param>
	/// <param name="durations">durations is list variant of duration of LearningItem</param>
	/// <param name="name">name of LearningItem</param>
	/// <param name="names">names is list variant of name of LearningItem</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningItem")]
	public GraphQLQuery<GqlLearningItem> LearningItem (string sessionToken, long? _id = null, long?[] _ids = null, string duration = null, string[] durations = null, Gql_LearningItemFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningItemOrdering[] orderBy = null, Func<GqlLearningItem, GqlLearningItem> fields = null ) 
	{
		return new GraphQLQuery<GqlLearningItem>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, duration, durations, filter, first, name, names, offset, orderBy);
	}

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningItemsList")]
	public GraphQLQuery<GqlLearningItem> LearningItemsList (string sessionToken, Func<GqlLearningItem, GqlLearningItem> fields = null ) 
	{
		return new GraphQLQuery<GqlLearningItem>(_httpClient, _endpoint, false, false, MethodBase.GetCurrentMethod(), fields, sessionToken
);
	}

	/// <param name="description">description of LearningPath</param>
	/// <param name="descriptions">descriptions is list variant of description of LearningPath</param>
	/// <param name="name">name of LearningPath</param>
	/// <param name="names">names is list variant of name of LearningPath</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningPath")]
	public GraphQLQuery<GqlLearningPath> LearningPath (string sessionToken, long? _id = null, long?[] _ids = null, string description = null, string[] descriptions = null, Gql_LearningPathFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningPathOrdering[] orderBy = null, Func<GqlLearningPath, GqlLearningPath> fields = null ) 
	{
		return new GraphQLQuery<GqlLearningPath>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, description, descriptions, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Project</param>
	/// <param name="names">names is list variant of name of Project</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Project")]
	public GraphQLQuery<GqlProject> Project (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ProjectFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ProjectOrdering[] orderBy = null, Func<GqlProject, GqlProject> fields = null ) 
	{
		return new GraphQLQuery<GqlProject>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Role</param>
	/// <param name="names">names is list variant of name of Role</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Role")]
	public GraphQLQuery<GqlRole> Role (string sessionToken, long? _id = null, long?[] _ids = null, Gql_RoleFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_RoleOrdering[] orderBy = null, Func<GqlRole, GqlRole> fields = null ) 
	{
		return new GraphQLQuery<GqlRole>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("RoleCount")]
	public GraphQLQuery<int?> RoleCount (string sessionToken, Func<int?, int?> fields = null ) 
	{
		return new GraphQLQuery<int?>(_httpClient, _endpoint, false, false, MethodBase.GetCurrentMethod(), fields, sessionToken
);
	}

	/// <param name="name">name of Scope</param>
	/// <param name="names">names is list variant of name of Scope</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Scope")]
	public GraphQLQuery<GqlScope> Scope (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ScopeFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ScopeOrdering[] orderBy = null, Func<GqlScope, GqlScope> fields = null ) 
	{
		return new GraphQLQuery<GqlScope>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Tag</param>
	/// <param name="names">names is list variant of name of Tag</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Tag")]
	public GraphQLQuery<GqlTag> Tag (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TagFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TagOrdering[] orderBy = null, Func<GqlTag, GqlTag> fields = null ) 
	{
		return new GraphQLQuery<GqlTag>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Team</param>
	/// <param name="names">names is list variant of name of Team</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Team")]
	public GraphQLQuery<GqlTeam> Team (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TeamFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TeamOrdering[] orderBy = null, Func<GqlTeam, GqlTeam> fields = null ) 
	{
		return new GraphQLQuery<GqlTeam>(_httpClient, _endpoint, true, false, MethodBase.GetCurrentMethod(), fields, sessionToken, 
_id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("TeamCount")]
	public GraphQLQuery<int?> TeamCount (string sessionToken, Func<int?, int?> fields = null ) 
	{
		return new GraphQLQuery<int?>(_httpClient, _endpoint, false, false, MethodBase.GetCurrentMethod(), fields, sessionToken
);
	}

    
	/// <summary>Adds Employees to Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addClientEmployees")]
	public GraphQLQuery<string> AddClientEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Adds Employees to Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addCountryEmployees")]
	public GraphQLQuery<string> AddCountryEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Adds Experience to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeExperience")]
	public GraphQLQuery<string> AddEmployeeExperience (string sessionToken, string[] experience, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
experience, name);
	}

	/// <summary>Adds IsMemberOf to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeIsMemberOf")]
	public GraphQLQuery<string> AddEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isMemberOf, name);
	}

	/// <summary>Adds Is_from_ to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeIs_from_")]
	public GraphQLQuery<string> AddEmployeeIs_from_ (string sessionToken, string[] is_from_, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
is_from_, name);
	}

	/// <summary>Adds LivesIn to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeLivesIn")]
	public GraphQLQuery<string> AddEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
livesIn, name);
	}

	/// <summary>Adds WorksAs to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksAs")]
	public GraphQLQuery<string> AddEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, worksAs);
	}

	/// <summary>Adds WorksFor to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksFor")]
	public GraphQLQuery<string> AddEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, worksFor);
	}

	/// <summary>Adds Event_of to Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEventsEvent_of")]
	public GraphQLQuery<string> AddEventsEvent_of (string sessionToken, string[] event_of, string subject, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
event_of, subject);
	}

	/// <summary>Adds Is_to to Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEventsIs_to")]
	public GraphQLQuery<string> AddEventsIs_to (string sessionToken, string[] is_to, string subject, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
is_to, subject);
	}

	/// <summary>Adds Scopes to Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEventsScopes")]
	public GraphQLQuery<string> AddEventsScopes (string sessionToken, string[] scopes, string subject, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
scopes, subject);
	}

	/// <summary>Adds Employees to Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addExperienceEmployees")]
	public GraphQLQuery<string> AddExperienceEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Adds Content to LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningItemContent")]
	public GraphQLQuery<string> AddLearningItemContent (string sessionToken, string[] content, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
content, name);
	}

	/// <summary>Adds Next to LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningItemNext")]
	public GraphQLQuery<string> AddLearningItemNext (string sessionToken, string name, string[] next, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, next);
	}

	/// <summary>Adds Learnings to LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningPathLearnings")]
	public GraphQLQuery<string> AddLearningPathLearnings (string sessionToken, string[] learnings, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
learnings, name);
	}

	/// <summary>Adds Prerequisite to LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningPathPrerequisite")]
	public GraphQLQuery<string> AddLearningPathPrerequisite (string sessionToken, string name, string[] prerequisite, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, prerequisite);
	}

	/// <summary>Adds Tags to LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningPathTags")]
	public GraphQLQuery<string> AddLearningPathTags (string sessionToken, string name, string[] tags, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, tags);
	}

	/// <summary>Adds Project to Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addProjectProject")]
	public GraphQLQuery<string> AddProjectProject (string sessionToken, string name, string[] project, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, project);
	}

	/// <summary>Adds Employees to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleEmployees")]
	public GraphQLQuery<string> AddRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Adds IsRequiredBy to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleIsRequiredBy")]
	public GraphQLQuery<string> AddRoleIsRequiredBy (string sessionToken, string[] isRequiredBy, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isRequiredBy, name);
	}

	/// <summary>Adds IsScopeOf_ to Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addScopeIsScopeOf_")]
	public GraphQLQuery<string> AddScopeIsScopeOf_ (string sessionToken, string[] isScopeOf_, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isScopeOf_, name);
	}

	/// <summary>Adds IsTagOf to Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTagIsTagOf")]
	public GraphQLQuery<string> AddTagIsTagOf (string sessionToken, string[] isTagOf, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isTagOf, name);
	}

	/// <summary>Adds Exp_requeres to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamExp_requeres")]
	public GraphQLQuery<string> AddTeamExp_requeres (string sessionToken, string[] exp_requeres, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
exp_requeres, name);
	}

	/// <summary>Adds Members to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamMembers")]
	public GraphQLQuery<string> AddTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
members, name);
	}

	/// <summary>Adds Roles to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamRoles")]
	public GraphQLQuery<string> AddTeamRoles (string sessionToken, string name, string[] roles, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, roles);
	}

	/// <summary>Creates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createClient")]
	public GraphQLQuery<string> CreateClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Creates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createCountry")]
	public GraphQLQuery<string> CreateCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Creates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createEmployee")]
	public GraphQLQuery<string> CreateEmployee (string sessionToken, string name, string _password = null, string _user = null, DateTime? dateOfBirth = null, string email = null, string gender = null, string image = null, string phone = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, _password, _user, dateOfBirth, email, gender, image, phone);
	}

	/// <summary>Creates a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createEvents")]
	public GraphQLQuery<string> CreateEvents (string sessionToken, string subject, DateTime? date = null, string description = null, string project = null, int? score = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
subject, date, description, project, score);
	}

	/// <summary>Creates a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createExperience")]
	public GraphQLQuery<string> CreateExperience (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Creates a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createLearningItem")]
	public GraphQLQuery<string> CreateLearningItem (string sessionToken, string name, string duration = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, duration);
	}

	/// <summary>Creates a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createLearningPath")]
	public GraphQLQuery<string> CreateLearningPath (string sessionToken, string name, string description = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, description);
	}

	/// <summary>Creates a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createProject")]
	public GraphQLQuery<string> CreateProject (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Creates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createRole")]
	public GraphQLQuery<string> CreateRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Creates a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createScope")]
	public GraphQLQuery<string> CreateScope (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Creates a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createTag")]
	public GraphQLQuery<string> CreateTag (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Creates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createTeam")]
	public GraphQLQuery<string> CreateTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClient")]
	public GraphQLQuery<string> DeleteClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Employees from Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClientEmployees")]
	public GraphQLQuery<string> DeleteClientEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Deletes a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountry")]
	public GraphQLQuery<string> DeleteCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Employees from Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountryEmployees")]
	public GraphQLQuery<string> DeleteCountryEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Deletes a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployee")]
	public GraphQLQuery<string> DeleteEmployee (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Experience from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeExperience")]
	public GraphQLQuery<string> DeleteEmployeeExperience (string sessionToken, string[] experience, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
experience, name);
	}

	/// <summary>Deletes IsMemberOf from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeIsMemberOf")]
	public GraphQLQuery<string> DeleteEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isMemberOf, name);
	}

	/// <summary>Deletes Is_from_ from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeIs_from_")]
	public GraphQLQuery<string> DeleteEmployeeIs_from_ (string sessionToken, string[] is_from_, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
is_from_, name);
	}

	/// <summary>Deletes LivesIn from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeLivesIn")]
	public GraphQLQuery<string> DeleteEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
livesIn, name);
	}

	/// <summary>Deletes WorksAs from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksAs")]
	public GraphQLQuery<string> DeleteEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, worksAs);
	}

	/// <summary>Deletes WorksFor from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksFor")]
	public GraphQLQuery<string> DeleteEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, worksFor);
	}

	/// <summary>Deletes a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEvents")]
	public GraphQLQuery<string> DeleteEvents (string sessionToken, string subject, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
subject);
	}

	/// <summary>Deletes Event_of from Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEventsEvent_of")]
	public GraphQLQuery<string> DeleteEventsEvent_of (string sessionToken, string[] event_of, string subject, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
event_of, subject);
	}

	/// <summary>Deletes Is_to from Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEventsIs_to")]
	public GraphQLQuery<string> DeleteEventsIs_to (string sessionToken, string[] is_to, string subject, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
is_to, subject);
	}

	/// <summary>Deletes Scopes from Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEventsScopes")]
	public GraphQLQuery<string> DeleteEventsScopes (string sessionToken, string[] scopes, string subject, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
scopes, subject);
	}

	/// <summary>Deletes a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteExperience")]
	public GraphQLQuery<string> DeleteExperience (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Employees from Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteExperienceEmployees")]
	public GraphQLQuery<string> DeleteExperienceEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Deletes a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningItem")]
	public GraphQLQuery<string> DeleteLearningItem (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Content from LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningItemContent")]
	public GraphQLQuery<string> DeleteLearningItemContent (string sessionToken, string[] content, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
content, name);
	}

	/// <summary>Deletes Next from LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningItemNext")]
	public GraphQLQuery<string> DeleteLearningItemNext (string sessionToken, string name, string[] next, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, next);
	}

	/// <summary>Deletes a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPath")]
	public GraphQLQuery<string> DeleteLearningPath (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Learnings from LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPathLearnings")]
	public GraphQLQuery<string> DeleteLearningPathLearnings (string sessionToken, string[] learnings, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
learnings, name);
	}

	/// <summary>Deletes Prerequisite from LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPathPrerequisite")]
	public GraphQLQuery<string> DeleteLearningPathPrerequisite (string sessionToken, string name, string[] prerequisite, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, prerequisite);
	}

	/// <summary>Deletes Tags from LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPathTags")]
	public GraphQLQuery<string> DeleteLearningPathTags (string sessionToken, string name, string[] tags, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, tags);
	}

	/// <summary>Deletes a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteProject")]
	public GraphQLQuery<string> DeleteProject (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Project from Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteProjectProject")]
	public GraphQLQuery<string> DeleteProjectProject (string sessionToken, string name, string[] project, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, project);
	}

	/// <summary>Deletes a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRole")]
	public GraphQLQuery<string> DeleteRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Employees from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleEmployees")]
	public GraphQLQuery<string> DeleteRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
employees, name);
	}

	/// <summary>Deletes IsRequiredBy from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleIsRequiredBy")]
	public GraphQLQuery<string> DeleteRoleIsRequiredBy (string sessionToken, string[] isRequiredBy, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isRequiredBy, name);
	}

	/// <summary>Deletes a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteScope")]
	public GraphQLQuery<string> DeleteScope (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes IsScopeOf_ from Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteScopeIsScopeOf_")]
	public GraphQLQuery<string> DeleteScopeIsScopeOf_ (string sessionToken, string[] isScopeOf_, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isScopeOf_, name);
	}

	/// <summary>Deletes a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTag")]
	public GraphQLQuery<string> DeleteTag (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes IsTagOf from Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTagIsTagOf")]
	public GraphQLQuery<string> DeleteTagIsTagOf (string sessionToken, string[] isTagOf, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
isTagOf, name);
	}

	/// <summary>Deletes a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeam")]
	public GraphQLQuery<string> DeleteTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Deletes Exp_requeres from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamExp_requeres")]
	public GraphQLQuery<string> DeleteTeamExp_requeres (string sessionToken, string[] exp_requeres, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
exp_requeres, name);
	}

	/// <summary>Deletes Members from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamMembers")]
	public GraphQLQuery<string> DeleteTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
members, name);
	}

	/// <summary>Deletes Roles from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamRoles")]
	public GraphQLQuery<string> DeleteTeamRoles (string sessionToken, string name, string[] roles, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, roles);
	}

	/// <summary>Merge a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeClient")]
	public GraphQLQuery<string> MergeClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Merge a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeCountry")]
	public GraphQLQuery<string> MergeCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Merge a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeEmployee")]
	public GraphQLQuery<string> MergeEmployee (string sessionToken, string name, string _password = null, string _user = null, DateTime? dateOfBirth = null, string email = null, string gender = null, string image = null, string phone = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, _password, _user, dateOfBirth, email, gender, image, phone);
	}

	/// <summary>Merge a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeEvents")]
	public GraphQLQuery<string> MergeEvents (string sessionToken, string subject, DateTime? date = null, string description = null, string project = null, int? score = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
subject, date, description, project, score);
	}

	/// <summary>Merge a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeExperience")]
	public GraphQLQuery<string> MergeExperience (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Merge a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeLearningItem")]
	public GraphQLQuery<string> MergeLearningItem (string sessionToken, string name, string duration = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, duration);
	}

	/// <summary>Merge a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeLearningPath")]
	public GraphQLQuery<string> MergeLearningPath (string sessionToken, string name, string description = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, description);
	}

	/// <summary>Merge a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeProject")]
	public GraphQLQuery<string> MergeProject (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Merge a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeRole")]
	public GraphQLQuery<string> MergeRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Merge a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeScope")]
	public GraphQLQuery<string> MergeScope (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Merge a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeTag")]
	public GraphQLQuery<string> MergeTag (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Merge a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeTeam")]
	public GraphQLQuery<string> MergeTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateClient")]
	public GraphQLQuery<string> UpdateClient (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateCountry")]
	public GraphQLQuery<string> UpdateCountry (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateEmployee")]
	public GraphQLQuery<string> UpdateEmployee (string sessionToken, string name, string _password = null, string _user = null, DateTime? dateOfBirth = null, string email = null, string gender = null, string image = null, string phone = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, _password, _user, dateOfBirth, email, gender, image, phone);
	}

	/// <summary>Updates a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateEvents")]
	public GraphQLQuery<string> UpdateEvents (string sessionToken, string subject, DateTime? date = null, string description = null, string project = null, int? score = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
subject, date, description, project, score);
	}

	/// <summary>Updates a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateExperience")]
	public GraphQLQuery<string> UpdateExperience (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateLearningItem")]
	public GraphQLQuery<string> UpdateLearningItem (string sessionToken, string name, string duration = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, duration);
	}

	/// <summary>Updates a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateLearningPath")]
	public GraphQLQuery<string> UpdateLearningPath (string sessionToken, string name, string description = null, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name, description);
	}

	/// <summary>Updates a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateProject")]
	public GraphQLQuery<string> UpdateProject (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateRole")]
	public GraphQLQuery<string> UpdateRole (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateScope")]
	public GraphQLQuery<string> UpdateScope (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateTag")]
	public GraphQLQuery<string> UpdateTag (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

	/// <summary>Updates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateTeam")]
	public GraphQLQuery<string> UpdateTeam (string sessionToken, string name, Func<string, string> fields = null ) 
	{
		return new GraphQLQuery<string>(_httpClient, _endpoint, false, true, MethodBase.GetCurrentMethod(), fields, sessionToken, 
name);
	}

    
}
