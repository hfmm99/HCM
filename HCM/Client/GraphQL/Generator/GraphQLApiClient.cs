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

}

public partial class GqlCountry
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Country livesIn Employee</summary>
	[GraphQLField("livesIn")]
	public GqlEmployee LivesIn { get; set; }

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
	public GqlTeam IsMemberOf { get; set; }

	/// <summary>Employee livesIn Country</summary>
	[GraphQLField("livesIn")]
	public GqlCountry LivesIn { get; set; }

	/// <summary>Employee manages Employee</summary>
	[GraphQLField("manages")]
	public List<GqlEmployee> Manages { get; set; }

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

public partial class GqlLearningItem
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>LearningItem completed Employee</summary>
	[GraphQLField("completed")]
	public GqlEmployee Completed { get; set; }

	/// <summary>LearningItem content LearningPath</summary>
	[GraphQLField("content")]
	public GqlLearningPath Content { get; set; }

	/// <summary>duration of  LearningItem</summary>
	[GraphQLField("duration")]
	public string Duration { get; set; }

	/// <summary>name of  LearningItem</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>LearningItem next LearningItem</summary>
	[GraphQLField("next")]
	public GqlLearningItem Next { get; set; }

}

public partial class GqlLearningPath
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>LearningPath content LearningItem</summary>
	[GraphQLField("content")]
	public GqlLearningItem Content { get; set; }

	/// <summary>description of  LearningPath</summary>
	[GraphQLField("description")]
	public string Description { get; set; }

	/// <summary>LearningPath isPrerequisite LearningPath</summary>
	[GraphQLField("isPrerequisite")]
	public GqlLearningPath IsPrerequisite { get; set; }

	/// <summary>name of  LearningPath</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>LearningPath requires Role</summary>
	[GraphQLField("requires")]
	public GqlRole Requires { get; set; }

}

public partial class GqlRole
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>name of  Role</summary>
	[GraphQLField("name")]
	public string Name { get; set; }

	/// <summary>Role requires LearningPath</summary>
	[GraphQLField("requires")]
	public List<GqlLearningPath> Requires { get; set; }

	/// <summary>Role worksAs Employee</summary>
	[GraphQLField("worksAs")]
	public List<GqlEmployee> WorksAs { get; set; }

}

public partial class GqlTeam
{
	/// <summary>internal node id</summary>
	[GraphQLField("_id")]
	public long? _id { get; set; }

	/// <summary>Team isMemberOf Employee</summary>
	[GraphQLField("isMemberOf")]
	public List<GqlEmployee> IsMemberOf { get; set; }

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

	/// <summary>livesIn_in</summary>
	[JsonProperty(PropertyName = "livesIn_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_in { get; set; }

	/// <summary>livesIn_not</summary>
	[JsonProperty(PropertyName = "livesIn_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_not { get; set; }

	/// <summary>livesIn_not_in</summary>
	[JsonProperty(PropertyName = "livesIn_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter LivesIn_not_in { get; set; }

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

	/// <summary>isMemberOf_in</summary>
	[JsonProperty(PropertyName = "isMemberOf_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_in { get; set; }

	/// <summary>isMemberOf_not</summary>
	[JsonProperty(PropertyName = "isMemberOf_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_not { get; set; }

	/// <summary>isMemberOf_not_in</summary>
	[JsonProperty(PropertyName = "isMemberOf_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_TeamFilter IsMemberOf_not_in { get; set; }

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

	/// <summary>manages</summary>
	[JsonProperty(PropertyName = "manages", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages { get; set; }

	/// <summary>manages_every</summary>
	[JsonProperty(PropertyName = "manages_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages_every { get; set; }

	/// <summary>manages_in</summary>
	[JsonProperty(PropertyName = "manages_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages_in { get; set; }

	/// <summary>manages_none</summary>
	[JsonProperty(PropertyName = "manages_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages_none { get; set; }

	/// <summary>manages_not</summary>
	[JsonProperty(PropertyName = "manages_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages_not { get; set; }

	/// <summary>manages_not_in</summary>
	[JsonProperty(PropertyName = "manages_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages_not_in { get; set; }

	/// <summary>manages_single</summary>
	[JsonProperty(PropertyName = "manages_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages_single { get; set; }

	/// <summary>manages_some</summary>
	[JsonProperty(PropertyName = "manages_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Manages_some { get; set; }

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

public class Gql_LearningItemFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_LearningItemFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_LearningItemFilter> OR { get; set; }

	/// <summary>completed</summary>
	[JsonProperty(PropertyName = "completed", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Completed { get; set; }

	/// <summary>completed_in</summary>
	[JsonProperty(PropertyName = "completed_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Completed_in { get; set; }

	/// <summary>completed_not</summary>
	[JsonProperty(PropertyName = "completed_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Completed_not { get; set; }

	/// <summary>completed_not_in</summary>
	[JsonProperty(PropertyName = "completed_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter Completed_not_in { get; set; }

	/// <summary>content</summary>
	[JsonProperty(PropertyName = "content", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content { get; set; }

	/// <summary>content_in</summary>
	[JsonProperty(PropertyName = "content_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_in { get; set; }

	/// <summary>content_not</summary>
	[JsonProperty(PropertyName = "content_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_not { get; set; }

	/// <summary>content_not_in</summary>
	[JsonProperty(PropertyName = "content_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Content_not_in { get; set; }

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

	/// <summary>next_in</summary>
	[JsonProperty(PropertyName = "next_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_in { get; set; }

	/// <summary>next_not</summary>
	[JsonProperty(PropertyName = "next_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_not { get; set; }

	/// <summary>next_not_in</summary>
	[JsonProperty(PropertyName = "next_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Next_not_in { get; set; }

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

	/// <summary>content</summary>
	[JsonProperty(PropertyName = "content", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Content { get; set; }

	/// <summary>content_in</summary>
	[JsonProperty(PropertyName = "content_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Content_in { get; set; }

	/// <summary>content_not</summary>
	[JsonProperty(PropertyName = "content_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Content_not { get; set; }

	/// <summary>content_not_in</summary>
	[JsonProperty(PropertyName = "content_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningItemFilter Content_not_in { get; set; }

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

	/// <summary>isPrerequisite</summary>
	[JsonProperty(PropertyName = "isPrerequisite", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsPrerequisite { get; set; }

	/// <summary>isPrerequisite_in</summary>
	[JsonProperty(PropertyName = "isPrerequisite_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsPrerequisite_in { get; set; }

	/// <summary>isPrerequisite_not</summary>
	[JsonProperty(PropertyName = "isPrerequisite_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsPrerequisite_not { get; set; }

	/// <summary>isPrerequisite_not_in</summary>
	[JsonProperty(PropertyName = "isPrerequisite_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter IsPrerequisite_not_in { get; set; }

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

	/// <summary>requires_in</summary>
	[JsonProperty(PropertyName = "requires_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_in { get; set; }

	/// <summary>requires_not</summary>
	[JsonProperty(PropertyName = "requires_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_not { get; set; }

	/// <summary>requires_not_in</summary>
	[JsonProperty(PropertyName = "requires_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_RoleFilter Requires_not_in { get; set; }

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

public class Gql_RoleFilter
{
	/// <summary>AND</summary>
	[JsonProperty(PropertyName = "AND", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_RoleFilter> AND { get; set; }

	/// <summary>OR</summary>
	[JsonProperty(PropertyName = "OR", NullValueHandling = NullValueHandling.Ignore)]
	public List<Gql_RoleFilter> OR { get; set; }

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
	public Gql_LearningPathFilter Requires { get; set; }

	/// <summary>requires_every</summary>
	[JsonProperty(PropertyName = "requires_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Requires_every { get; set; }

	/// <summary>requires_in</summary>
	[JsonProperty(PropertyName = "requires_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Requires_in { get; set; }

	/// <summary>requires_none</summary>
	[JsonProperty(PropertyName = "requires_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Requires_none { get; set; }

	/// <summary>requires_not</summary>
	[JsonProperty(PropertyName = "requires_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Requires_not { get; set; }

	/// <summary>requires_not_in</summary>
	[JsonProperty(PropertyName = "requires_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Requires_not_in { get; set; }

	/// <summary>requires_single</summary>
	[JsonProperty(PropertyName = "requires_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Requires_single { get; set; }

	/// <summary>requires_some</summary>
	[JsonProperty(PropertyName = "requires_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_LearningPathFilter Requires_some { get; set; }

	/// <summary>worksAs</summary>
	[JsonProperty(PropertyName = "worksAs", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs { get; set; }

	/// <summary>worksAs_every</summary>
	[JsonProperty(PropertyName = "worksAs_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs_every { get; set; }

	/// <summary>worksAs_in</summary>
	[JsonProperty(PropertyName = "worksAs_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs_in { get; set; }

	/// <summary>worksAs_none</summary>
	[JsonProperty(PropertyName = "worksAs_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs_none { get; set; }

	/// <summary>worksAs_not</summary>
	[JsonProperty(PropertyName = "worksAs_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs_not { get; set; }

	/// <summary>worksAs_not_in</summary>
	[JsonProperty(PropertyName = "worksAs_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs_not_in { get; set; }

	/// <summary>worksAs_single</summary>
	[JsonProperty(PropertyName = "worksAs_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs_single { get; set; }

	/// <summary>worksAs_some</summary>
	[JsonProperty(PropertyName = "worksAs_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter WorksAs_some { get; set; }

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

	/// <summary>isMemberOf</summary>
	[JsonProperty(PropertyName = "isMemberOf", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf { get; set; }

	/// <summary>isMemberOf_every</summary>
	[JsonProperty(PropertyName = "isMemberOf_every", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf_every { get; set; }

	/// <summary>isMemberOf_in</summary>
	[JsonProperty(PropertyName = "isMemberOf_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf_in { get; set; }

	/// <summary>isMemberOf_none</summary>
	[JsonProperty(PropertyName = "isMemberOf_none", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf_none { get; set; }

	/// <summary>isMemberOf_not</summary>
	[JsonProperty(PropertyName = "isMemberOf_not", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf_not { get; set; }

	/// <summary>isMemberOf_not_in</summary>
	[JsonProperty(PropertyName = "isMemberOf_not_in", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf_not_in { get; set; }

	/// <summary>isMemberOf_single</summary>
	[JsonProperty(PropertyName = "isMemberOf_single", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf_single { get; set; }

	/// <summary>isMemberOf_some</summary>
	[JsonProperty(PropertyName = "isMemberOf_some", NullValueHandling = NullValueHandling.Ignore)]
	public Gql_EmployeeFilter IsMemberOf_some { get; set; }

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
		return new GraphQLQuery<GqlClient>(_httpClient, _endpoint, true, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Country</param>
	/// <param name="names">names is list variant of name of Country</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Country")]
	public GraphQLQuery<GqlCountry> Country (string sessionToken, long? _id = null, long?[] _ids = null, Gql_CountryFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_CountryOrdering[] orderBy = null, Func<GqlCountry, GqlCountry> fields = null ) 
	{
		return new GraphQLQuery<GqlCountry>(_httpClient, _endpoint, true, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="email">email of Employee</param>
	/// <param name="emails">emails is list variant of email of Employee</param>
	/// <param name="name">name of Employee</param>
	/// <param name="names">names is list variant of name of Employee</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Employee")]
	public GraphQLQuery<GqlEmployee> Employee (string sessionToken, long? _id = null, long?[] _ids = null, string email = null, string[] emails = null, Gql_EmployeeFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_EmployeeOrdering[] orderBy = null, Func<GqlEmployee, GqlEmployee> fields = null ) 
	{
		return new GraphQLQuery<GqlEmployee>(_httpClient, _endpoint, true, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, email, emails, filter, first, name, names, offset, orderBy);
	}

	/// <param name="duration">duration of LearningItem</param>
	/// <param name="durations">durations is list variant of duration of LearningItem</param>
	/// <param name="name">name of LearningItem</param>
	/// <param name="names">names is list variant of name of LearningItem</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningItem")]
	public GraphQLQuery<GqlLearningItem> LearningItem (string sessionToken, long? _id = null, long?[] _ids = null, string duration = null, string[] durations = null, Gql_LearningItemFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningItemOrdering[] orderBy = null, Func<GqlLearningItem, GqlLearningItem> fields = null ) 
	{
		return new GraphQLQuery<GqlLearningItem>(_httpClient, _endpoint, true, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, duration, durations, filter, first, name, names, offset, orderBy);
	}

	/// <param name="description">description of LearningPath</param>
	/// <param name="descriptions">descriptions is list variant of description of LearningPath</param>
	/// <param name="name">name of LearningPath</param>
	/// <param name="names">names is list variant of name of LearningPath</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningPath")]
	public GraphQLQuery<GqlLearningPath> LearningPath (string sessionToken, long? _id = null, long?[] _ids = null, string description = null, string[] descriptions = null, Gql_LearningPathFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningPathOrdering[] orderBy = null, Func<GqlLearningPath, GqlLearningPath> fields = null ) 
	{
		return new GraphQLQuery<GqlLearningPath>(_httpClient, _endpoint, true, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, description, descriptions, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Role</param>
	/// <param name="names">names is list variant of name of Role</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Role")]
	public GraphQLQuery<GqlRole> Role (string sessionToken, long? _id = null, long?[] _ids = null, Gql_RoleFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_RoleOrdering[] orderBy = null, Func<GqlRole, GqlRole> fields = null ) 
	{
		return new GraphQLQuery<GqlRole>(_httpClient, _endpoint, true, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

	/// <param name="name">name of Team</param>
	/// <param name="names">names is list variant of name of Team</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Team")]
	public GraphQLQuery<GqlTeam> Team (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TeamFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TeamOrdering[] orderBy = null, Func<GqlTeam, GqlTeam> fields = null ) 
	{
		return new GraphQLQuery<GqlTeam>(_httpClient, _endpoint, true, MethodBase.GetCurrentMethod(), fields, sessionToken, _id, _ids, filter, first, name, names, offset, orderBy);
	}

    
}
