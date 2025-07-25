using System.Reflection;

//namespace Microsoft.AspNetCore.Routing

//namespace razormy.MyMiddleware.Routing;

// <auto-generated>



namespace razormy.MyMiddleware.Routing
{
    internal static partial class MyResources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(MyResources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }
#if !NET20
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
#endif
        internal static string GetResourceString(string resourceKey, string defaultValue = null) => ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
            var value = GetResourceString(resourceKey);
            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }
            return value;
        }

        /// <summary>Value must be greater than or equal to {0}.</summary>
        internal static string @ArgumentMustBeGreaterThanOrEqualTo => GetResourceString("ArgumentMustBeGreaterThanOrEqualTo");
        /// <summary>Value must be greater than or equal to {0}.</summary>
        internal static string FormatArgumentMustBeGreaterThanOrEqualTo(object p0)
           => string.Format(Culture, GetResourceString("ArgumentMustBeGreaterThanOrEqualTo"), p0);

        /// <summary>The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.</summary>
        internal static string @RangeConstraint_MinShouldBeLessThanOrEqualToMax => GetResourceString("RangeConstraint_MinShouldBeLessThanOrEqualToMax");
        /// <summary>The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.</summary>
        internal static string FormatRangeConstraint_MinShouldBeLessThanOrEqualToMax(object p0, object p1)
           => string.Format(Culture, GetResourceString("RangeConstraint_MinShouldBeLessThanOrEqualToMax"), p0, p1);

        /// <summary>The '{0}' property of '{1}' must not be null.</summary>
        internal static string @PropertyOfTypeCannotBeNull => GetResourceString("PropertyOfTypeCannotBeNull");
        /// <summary>The '{0}' property of '{1}' must not be null.</summary>
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1)
           => string.Format(Culture, GetResourceString("PropertyOfTypeCannotBeNull"), p0, p1);

        /// <summary>The supplied route name '{0}' is ambiguous and matched more than one route.</summary>
        internal static string @NamedRoutes_AmbiguousRoutesFound => GetResourceString("NamedRoutes_AmbiguousRoutesFound");
        /// <summary>The supplied route name '{0}' is ambiguous and matched more than one route.</summary>
        internal static string FormatNamedRoutes_AmbiguousRoutesFound(object p0)
           => string.Format(Culture, GetResourceString("NamedRoutes_AmbiguousRoutesFound"), p0);

        /// <summary>A default handler must be set on the {0}.</summary>
        internal static string @DefaultHandler_MustBeSet => GetResourceString("DefaultHandler_MustBeSet");
        /// <summary>A default handler must be set on the {0}.</summary>
        internal static string FormatDefaultHandler_MustBeSet(object p0)
           => string.Format(Culture, GetResourceString("DefaultHandler_MustBeSet"), p0);

        /// <summary>The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.</summary>
        internal static string @DefaultInlineConstraintResolver_AmbiguousCtors => GetResourceString("DefaultInlineConstraintResolver_AmbiguousCtors");
        /// <summary>The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.</summary>
        internal static string FormatDefaultInlineConstraintResolver_AmbiguousCtors(object p0, object p1)
           => string.Format(Culture, GetResourceString("DefaultInlineConstraintResolver_AmbiguousCtors"), p0, p1);

        /// <summary>Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.</summary>
        internal static string @DefaultInlineConstraintResolver_CouldNotFindCtor => GetResourceString("DefaultInlineConstraintResolver_CouldNotFindCtor");
        /// <summary>Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.</summary>
        internal static string FormatDefaultInlineConstraintResolver_CouldNotFindCtor(object p0, object p1)
           => string.Format(Culture, GetResourceString("DefaultInlineConstraintResolver_CouldNotFindCtor"), p0, p1);

        /// <summary>The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.</summary>
        internal static string @DefaultInlineConstraintResolver_TypeNotConstraint => GetResourceString("DefaultInlineConstraintResolver_TypeNotConstraint");
        /// <summary>The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.</summary>
        internal static string FormatDefaultInlineConstraintResolver_TypeNotConstraint(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("DefaultInlineConstraintResolver_TypeNotConstraint"), p0, p1, p2);

        /// <summary>A path segment that contains more than one section, such as a literal section or a parameter, cannot contain a catch-all parameter.</summary>
        internal static string @TemplateRoute_CannotHaveCatchAllInMultiSegment => GetResourceString("TemplateRoute_CannotHaveCatchAllInMultiSegment");
        /// <summary>The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.</summary>
        internal static string @TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly => GetResourceString("TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly");
        /// <summary>The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.</summary>
        internal static string FormatTemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly(object p0)
           => string.Format(Culture, GetResourceString("TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly"), p0);

        /// <summary>A path segment cannot contain two consecutive parameters. They must be separated by a '/' or by a literal string.</summary>
        internal static string @TemplateRoute_CannotHaveConsecutiveParameters => GetResourceString("TemplateRoute_CannotHaveConsecutiveParameters");
        /// <summary>The route template separator character '/' cannot appear consecutively. It must be separated by either a parameter or a literal value.</summary>
        internal static string @TemplateRoute_CannotHaveConsecutiveSeparators => GetResourceString("TemplateRoute_CannotHaveConsecutiveSeparators");
        /// <summary>A catch-all parameter cannot be marked optional.</summary>
        internal static string @TemplateRoute_CatchAllCannotBeOptional => GetResourceString("TemplateRoute_CatchAllCannotBeOptional");
        /// <summary>An optional parameter cannot have default value.</summary>
        internal static string @TemplateRoute_OptionalCannotHaveDefaultValue => GetResourceString("TemplateRoute_OptionalCannotHaveDefaultValue");
        /// <summary>A catch-all parameter can only appear as the last segment of the route template.</summary>
        internal static string @TemplateRoute_CatchAllMustBeLast => GetResourceString("TemplateRoute_CatchAllMustBeLast");
        /// <summary>The literal section '{0}' is invalid. Literal sections cannot contain the '?' character.</summary>
        internal static string @TemplateRoute_InvalidLiteral => GetResourceString("TemplateRoute_InvalidLiteral");
        /// <summary>The literal section '{0}' is invalid. Literal sections cannot contain the '?' character.</summary>
        internal static string FormatTemplateRoute_InvalidLiteral(object p0)
           => string.Format(Culture, GetResourceString("TemplateRoute_InvalidLiteral"), p0);

        /// <summary>The route parameter name '{0}' is invalid. Route parameter names must be non-empty and cannot contain these characters: '{{', '}}', '/'. The '?' character marks a parameter as optional, and can occur only at the end of the parameter. The '*' character mark ...</summary>
        internal static string @TemplateRoute_InvalidParameterName => GetResourceString("TemplateRoute_InvalidParameterName");
        /// <summary>The route parameter name '{0}' is invalid. Route parameter names must be non-empty and cannot contain these characters: '{{', '}}', '/'. The '?' character marks a parameter as optional, and can occur only at the end of the parameter. The '*' character mark ...</summary>
        internal static string FormatTemplateRoute_InvalidParameterName(object p0)
           => string.Format(Culture, GetResourceString("TemplateRoute_InvalidParameterName"), p0);

        /// <summary>The route template cannot start with a '~' character unless followed by a '/'.</summary>
        internal static string @TemplateRoute_InvalidRouteTemplate => GetResourceString("TemplateRoute_InvalidRouteTemplate");
        /// <summary>There is an incomplete parameter in the route template. Check that each '{' character has a matching '}' character.</summary>
        internal static string @TemplateRoute_MismatchedParameter => GetResourceString("TemplateRoute_MismatchedParameter");
        /// <summary>The route parameter name '{0}' appears more than one time in the route template.</summary>
        internal static string @TemplateRoute_RepeatedParameter => GetResourceString("TemplateRoute_RepeatedParameter");
        /// <summary>The route parameter name '{0}' appears more than one time in the route template.</summary>
        internal static string FormatTemplateRoute_RepeatedParameter(object p0)
           => string.Format(Culture, GetResourceString("TemplateRoute_RepeatedParameter"), p0);

        /// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.</summary>
        internal static string @RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint => GetResourceString("RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint");
        /// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.</summary>
        internal static string FormatRouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint(object p0, object p1, object p2, object p3)
           => string.Format(Culture, GetResourceString("RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint"), p0, p1, p2, p3);

        /// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.</summary>
        internal static string @RouteConstraintBuilder_CouldNotResolveConstraint => GetResourceString("RouteConstraintBuilder_CouldNotResolveConstraint");
        /// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.</summary>
        internal static string FormatRouteConstraintBuilder_CouldNotResolveConstraint(object p0, object p1, object p2, object p3)
           => string.Format(Culture, GetResourceString("RouteConstraintBuilder_CouldNotResolveConstraint"), p0, p1, p2, p3);

        /// <summary>In a route parameter, '{' and '}' must be escaped with '{{' and '}}'.</summary>
        internal static string @TemplateRoute_UnescapedBrace => GetResourceString("TemplateRoute_UnescapedBrace");
        /// <summary>In the segment '{0}', the optional parameter '{1}' is preceded by an invalid segment '{2}'. Only a period (.) can precede an optional parameter.</summary>
        internal static string @TemplateRoute_OptionalParameterCanbBePrecededByPeriod => GetResourceString("TemplateRoute_OptionalParameterCanbBePrecededByPeriod");
        /// <summary>In the segment '{0}', the optional parameter '{1}' is preceded by an invalid segment '{2}'. Only a period (.) can precede an optional parameter.</summary>
        internal static string FormatTemplateRoute_OptionalParameterCanbBePrecededByPeriod(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("TemplateRoute_OptionalParameterCanbBePrecededByPeriod"), p0, p1, p2);

        /// <summary>An optional parameter must be at the end of the segment. In the segment '{0}', optional parameter '{1}' is followed by '{2}'.</summary>
        internal static string @TemplateRoute_OptionalParameterHasTobeTheLast => GetResourceString("TemplateRoute_OptionalParameterHasTobeTheLast");
        /// <summary>An optional parameter must be at the end of the segment. In the segment '{0}', optional parameter '{1}' is followed by '{2}'.</summary>
        internal static string FormatTemplateRoute_OptionalParameterHasTobeTheLast(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("TemplateRoute_OptionalParameterHasTobeTheLast"), p0, p1, p2);

        /// <summary>Two or more routes named '{0}' have different templates.</summary>
        internal static string @AttributeRoute_DifferentLinkGenerationEntries_SameName => GetResourceString("AttributeRoute_DifferentLinkGenerationEntries_SameName");
        /// <summary>Two or more routes named '{0}' have different templates.</summary>
        internal static string FormatAttributeRoute_DifferentLinkGenerationEntries_SameName(object p0)
           => string.Format(Culture, GetResourceString("AttributeRoute_DifferentLinkGenerationEntries_SameName"), p0);

        /// <summary>Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.</summary>
        internal static string @UnableToFindServices => GetResourceString("UnableToFindServices");
        /// <summary>Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.</summary>
        internal static string FormatUnableToFindServices(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("UnableToFindServices"), p0, p1, p2);

        /// <summary>An error occurred while creating the route with name '{0}' and template '{1}'.</summary>
        internal static string @TemplateRoute_Exception => GetResourceString("TemplateRoute_Exception");
        /// <summary>An error occurred while creating the route with name '{0}' and template '{1}'.</summary>
        internal static string FormatTemplateRoute_Exception(object p0, object p1)
           => string.Format(Culture, GetResourceString("TemplateRoute_Exception"), p0, p1);

        /// <summary>The request matched multiple endpoints. Matches: {0}{0}{1}</summary>
        internal static string @AmbiguousEndpoints => GetResourceString("AmbiguousEndpoints");
        /// <summary>The request matched multiple endpoints. Matches: {0}{0}{1}</summary>
        internal static string FormatAmbiguousEndpoints(object p0, object p1)
           => string.Format(Culture, GetResourceString("AmbiguousEndpoints"), p0, p1);

        /// <summary>The collection cannot be empty.</summary>
        internal static string @RoutePatternBuilder_CollectionCannotBeEmpty => GetResourceString("RoutePatternBuilder_CollectionCannotBeEmpty");
        /// <summary>The constraint entry '{0}' - '{1}' must have a string value or be of a type which implements '{2}'.</summary>
        internal static string @ConstraintMustBeStringOrConstraint => GetResourceString("ConstraintMustBeStringOrConstraint");
        /// <summary>The constraint entry '{0}' - '{1}' must have a string value or be of a type which implements '{2}'.</summary>
        internal static string FormatConstraintMustBeStringOrConstraint(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("ConstraintMustBeStringOrConstraint"), p0, p1, p2);

        /// <summary>Invalid constraint '{0}'. A constraint must be of type 'string' or '{1}'.</summary>
        internal static string @RoutePattern_InvalidConstraintReference => GetResourceString("RoutePattern_InvalidConstraintReference");
        /// <summary>Invalid constraint '{0}'. A constraint must be of type 'string' or '{1}'.</summary>
        internal static string FormatRoutePattern_InvalidConstraintReference(object p0, object p1)
           => string.Format(Culture, GetResourceString("RoutePattern_InvalidConstraintReference"), p0, p1);

        /// <summary>Invalid constraint '{0}' for parameter '{1}'. A constraint must be of type 'string', '{2}', or '{3}'.</summary>
        internal static string @RoutePattern_InvalidParameterConstraintReference => GetResourceString("RoutePattern_InvalidParameterConstraintReference");
        /// <summary>Invalid constraint '{0}' for parameter '{1}'. A constraint must be of type 'string', '{2}', or '{3}'.</summary>
        internal static string FormatRoutePattern_InvalidParameterConstraintReference(object p0, object p1, object p2, object p3)
           => string.Format(Culture, GetResourceString("RoutePattern_InvalidParameterConstraintReference"), p0, p1, p2, p3);

        /// <summary>The constraint reference '{0}' could not be resolved to a type. Register the constraint type with '{1}.{2}'.</summary>
        internal static string @RoutePattern_ConstraintReferenceNotFound => GetResourceString("RoutePattern_ConstraintReferenceNotFound");
        /// <summary>The constraint reference '{0}' could not be resolved to a type. Register the constraint type with '{1}.{2}'.</summary>
        internal static string FormatRoutePattern_ConstraintReferenceNotFound(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("RoutePattern_ConstraintReferenceNotFound"), p0, p1, p2);

        /// <summary>Invalid constraint type '{0}' registered as '{1}'. A constraint  type must either implement '{2}', or inherit from '{3}'.</summary>
        internal static string @RoutePattern_InvalidStringConstraintReference => GetResourceString("RoutePattern_InvalidStringConstraintReference");
        /// <summary>Invalid constraint type '{0}' registered as '{1}'. A constraint  type must either implement '{2}', or inherit from '{3}'.</summary>
        internal static string FormatRoutePattern_InvalidStringConstraintReference(object p0, object p1, object p2, object p3)
           => string.Format(Culture, GetResourceString("RoutePattern_InvalidStringConstraintReference"), p0, p1, p2, p3);

        /// <summary>Endpoints with endpoint name '{0}':</summary>
        internal static string @DuplicateEndpointNameEntry => GetResourceString("DuplicateEndpointNameEntry");
        /// <summary>Endpoints with endpoint name '{0}':</summary>
        internal static string FormatDuplicateEndpointNameEntry(object p0)
           => string.Format(Culture, GetResourceString("DuplicateEndpointNameEntry"), p0);

        /// <summary>The following endpoints with a duplicate endpoint name were found.</summary>
        internal static string @DuplicateEndpointNameHeader => GetResourceString("DuplicateEndpointNameHeader");
        /// <summary>No media type found for format '{0}'.</summary>
        internal static string @FormatterMapping_MediaTypeInvalid => GetResourceString("FormatterMapping_MediaTypeInvalid");
        /// <summary>No media type found for format '{0}'.</summary>
        internal static string FormatFormatterMapping_MediaTypeInvalid(object p0)
           => string.Format(Culture, GetResourceString("FormatterMapping_MediaTypeInvalid"), p0);

        /// <summary>MapGroup does not support mutating RouteEndpointBuilder.RoutePattern from '{0}' to '{1}' via conventions.</summary>
        internal static string @MapGroup_ChangingRoutePatternUnsupported => GetResourceString("MapGroup_ChangingRoutePatternUnsupported");
        /// <summary>MapGroup does not support mutating RouteEndpointBuilder.RoutePattern from '{0}' to '{1}' via conventions.</summary>
        internal static string FormatMapGroup_ChangingRoutePatternUnsupported(object p0, object p1)
           => string.Format(Culture, GetResourceString("MapGroup_ChangingRoutePatternUnsupported"), p0, p1);

        /// <summary>MapGroup does not support custom Endpoint type '{0}'. Only RouteEndpoints can be grouped.</summary>
        internal static string @MapGroup_CustomEndpointUnsupported => GetResourceString("MapGroup_CustomEndpointUnsupported");
        /// <summary>MapGroup does not support custom Endpoint type '{0}'. Only RouteEndpoints can be grouped.</summary>
        internal static string FormatMapGroup_CustomEndpointUnsupported(object p0)
           => string.Format(Culture, GetResourceString("MapGroup_CustomEndpointUnsupported"), p0);

        /// <summary>MapGroup cannot build a pattern for '{0}' because the 'RoutePattern.{1}' dictionary key '{2}' has multiple values.</summary>
        internal static string @MapGroup_RepeatedDictionaryEntry => GetResourceString("MapGroup_RepeatedDictionaryEntry");
        /// <summary>MapGroup cannot build a pattern for '{0}' because the 'RoutePattern.{1}' dictionary key '{2}' has multiple values.</summary>
        internal static string FormatMapGroup_RepeatedDictionaryEntry(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("MapGroup_RepeatedDictionaryEntry"), p0, p1, p2);

        /// <summary>Conventions cannot be added after building the endpoint.</summary>
        internal static string @RouteEndpointDataSource_ConventionsCannotBeModifiedAfterBuild => GetResourceString("RouteEndpointDataSource_ConventionsCannotBeModifiedAfterBuild");
        /// <summary>This RequestDelegate cannot be called before the final endpoint is built.</summary>
        internal static string @RouteEndpointDataSource_RequestDelegateCannotBeCalledBeforeBuild => GetResourceString("RouteEndpointDataSource_RequestDelegateCannotBeCalledBeforeBuild");
        /// <summary>A route parameter uses the regex constraint, which isn't registered. If this application was configured using CreateSlimBuilder(...) or AddRoutingCore(...) then this constraint is not registered by default. To use the regex constraint, configure route opti ...</summary>
        internal static string @RegexRouteContraint_NotConfigured => GetResourceString("RegexRouteContraint_NotConfigured");

    }
}
