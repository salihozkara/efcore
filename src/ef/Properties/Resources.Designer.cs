// <auto-generated />

using System.Resources;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Tools.Properties
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Tools.Properties.Resources", typeof(Resources).Assembly);

        /// <summary>
        ///     Don't forget to copy appsettings.json alongside your bundle if you need it to apply migrations.
        /// </summary>
        public static string AppSettingsTip
            => GetString("AppSettingsTip");

        /// <summary>
        ///     The assembly to use. Required.
        /// </summary>
        public static string AssemblyDescription
            => GetString("AssemblyDescription");

        /// <summary>
        ///     Build failed. Use --verbose to see errors.
        /// </summary>
        public static string BuildBundleFailed
            => GetString("BuildBundleFailed");

        /// <summary>
        ///     Building bundle...
        /// </summary>
        public static string BuildBundleStarted
            => GetString("BuildBundleStarted");

        /// <summary>
        ///     Done. Migrations Bundle: {path}
        /// </summary>
        public static string BuildBundleSucceeded(object? path)
            => string.Format(
                GetString("BuildBundleSucceeded", nameof(path)),
                path);

        /// <summary>
        ///     The connection string to the database.
        /// </summary>
        public static string ConnectionDescription
            => GetString("ConnectionDescription");

        /// <summary>
        ///     The DbContext to use.
        /// </summary>
        public static string ContextDescription
            => GetString("ContextDescription");

        /// <summary>
        ///     The directory to put the DbContext file in. Paths are relative to the project directory.
        /// </summary>
        public static string ContextDirDescription
            => GetString("ContextDirDescription");

        /// <summary>
        ///     The name of the DbContext. Defaults to the database name.
        /// </summary>
        public static string ContextNameDescription
            => GetString("ContextNameDescription");

        /// <summary>
        ///     The namespace of the DbContext class. Matches the directory by default.
        /// </summary>
        public static string ContextNamespaceDescription
            => GetString("ContextNamespaceDescription");

        /// <summary>
        ///     Use attributes to configure the model (where possible). If omitted, only the fluent API is used.
        /// </summary>
        public static string DataAnnotationsDescription
            => GetString("DataAnnotationsDescription");

        /// <summary>
        ///     Commands to manage the database.
        /// </summary>
        public static string DatabaseDescription
            => GetString("DatabaseDescription");

        /// <summary>
        ///     Drops the database.
        /// </summary>
        public static string DatabaseDropDescription
            => GetString("DatabaseDropDescription");

        /// <summary>
        ///     This would drop the database '{database}' on server '{dataSource}'.
        /// </summary>
        public static string DatabaseDropDryRun(object? database, object? dataSource)
            => string.Format(
                GetString("DatabaseDropDryRun", nameof(database), nameof(dataSource)),
                database, dataSource);

        /// <summary>
        ///     Show which database would be dropped, but don't drop it.
        /// </summary>
        public static string DatabaseDropDryRunDescription
            => GetString("DatabaseDropDryRunDescription");

        /// <summary>
        ///     Don't confirm.
        /// </summary>
        public static string DatabaseDropForceDescription
            => GetString("DatabaseDropForceDescription");

        /// <summary>
        ///     Are you sure you want to drop the database '{database}' on server '{dataSource}'? (y/N)
        /// </summary>
        public static string DatabaseDropPrompt(object? database, object? dataSource)
            => string.Format(
                GetString("DatabaseDropPrompt", nameof(database), nameof(dataSource)),
                database, dataSource);

        /// <summary>
        ///     Database name: {database}
        /// </summary>
        public static string DatabaseName(object? database)
            => string.Format(
                GetString("DatabaseName", nameof(database)),
                database);

        /// <summary>
        ///     Updates the database to a specified migration.
        /// </summary>
        public static string DatabaseUpdateDescription
            => GetString("DatabaseUpdateDescription");

        /// <summary>
        ///     The data directory.
        /// </summary>
        public static string DataDirDescription
            => GetString("DataDirDescription");

        /// <summary>
        ///     Data source: {dataSource}
        /// </summary>
        public static string DataSource(object? dataSource)
            => string.Format(
                GetString("DataSource", nameof(dataSource)),
                dataSource);

        /// <summary>
        ///     The connection string to the database. Defaults to the one specified in AddDbContext or OnConfiguring.
        /// </summary>
        public static string DbContextConnectionDescription
            => GetString("DbContextConnectionDescription");

        /// <summary>
        ///     Commands to manage DbContext types.
        /// </summary>
        public static string DbContextDescription
            => GetString("DbContextDescription");

        /// <summary>
        ///     Gets information about a DbContext type.
        /// </summary>
        public static string DbContextInfoDescription
            => GetString("DbContextInfoDescription");

        /// <summary>
        ///     Lists available DbContext types.
        /// </summary>
        public static string DbContextListDescription
            => GetString("DbContextListDescription");

        /// <summary>
        ///     Generates a compiled version of the model used by the DbContext.
        /// </summary>
        public static string DbContextOptimizeDescription
            => GetString("DbContextOptimizeDescription");

        /// <summary>
        ///     Scaffolds a DbContext and entity types for a database.
        /// </summary>
        public static string DbContextScaffoldDescription
            => GetString("DbContextScaffoldDescription");

        /// <summary>
        ///     Overwrite existing files.
        /// </summary>
        public static string DbContextScaffoldForceDescription
            => GetString("DbContextScaffoldForceDescription");

        /// <summary>
        ///     Generates a SQL script from the DbContext. Bypasses any migrations.
        /// </summary>
        public static string DbContextScriptDescription
            => GetString("DbContextScriptDescription");

        /// <summary>
        ///     Type: {type}
        /// </summary>
        public static string DbContextType(object? type)
            => string.Format(
                GetString("DbContextType", nameof(type)),
                type);

        /// <summary>
        ///     Your startup project '{startupProject}' doesn't reference Microsoft.EntityFrameworkCore.Design. This package is required for the Entity Framework Core Tools to work. Ensure your startup project is correct, install the package, and try again.
        /// </summary>
        public static string DesignNotFound(object? startupProject)
            => string.Format(
                GetString("DesignNotFound", nameof(startupProject)),
                startupProject);

        /// <summary>
        ///     Entity Framework Core Command-line Tools
        /// </summary>
        public static string EFFullName
            => GetString("EFFullName");

        /// <summary>
        ///     The file already exists: {path}. Use --force flag to overwrite it.
        /// </summary>
        public static string FileExists(object? path)
            => string.Format(
                GetString("FileExists", nameof(path)),
                path);

        /// <summary>
        ///     The target framework.
        /// </summary>
        public static string FrameworkDescription
            => GetString("FrameworkDescription");

        /// <summary>
        ///     Generate a script that can be used on a database at any migration.
        /// </summary>
        public static string IdempotentDescription
            => GetString("IdempotentDescription");

        /// <summary>
        ///     Show JSON output. Use with --prefix-output to parse programatically.
        /// </summary>
        public static string JsonDescription
            => GetString("JsonDescription");

        /// <summary>
        ///     The language. Defaults to 'C#'.
        /// </summary>
        public static string LanguageDescription
            => GetString("LanguageDescription");

        /// <summary>
        ///     The target migration. If '0', all migrations will be reverted. Defaults to the last migration.
        /// </summary>
        public static string MigrationDescription
            => GetString("MigrationDescription");

        /// <summary>
        ///     The starting migration. Defaults to '0' (the initial database).
        /// </summary>
        public static string MigrationFromDescription
            => GetString("MigrationFromDescription");

        /// <summary>
        ///     The name of the migration.
        /// </summary>
        public static string MigrationNameDescription
            => GetString("MigrationNameDescription");

        /// <summary>
        ///     Done. To undo this action, use 'ef migrations remove'
        /// </summary>
        public static string MigrationsAddCompleted
            => GetString("MigrationsAddCompleted");

        /// <summary>
        ///     Adds a new migration.
        /// </summary>
        public static string MigrationsAddDescription
            => GetString("MigrationsAddDescription");

        /// <summary>
        ///     The configuration to use for the bundle.
        /// </summary>
        public static string MigrationsBundleConfigurationDescription
            => GetString("MigrationsBundleConfigurationDescription");

        /// <summary>
        ///     Creates an executable to update the database.
        /// </summary>
        public static string MigrationsBundleDescription
            => GetString("MigrationsBundleDescription");

        /// <summary>
        ///     The path of executable file to create.
        /// </summary>
        public static string MigrationsBundleOutputDescription
            => GetString("MigrationsBundleOutputDescription");

        /// <summary>
        ///     The target runtime to bundle for.
        /// </summary>
        public static string MigrationsBundleRuntimeDescription
            => GetString("MigrationsBundleRuntimeDescription");

        /// <summary>
        ///     Commands to manage migrations.
        /// </summary>
        public static string MigrationsDescription
            => GetString("MigrationsDescription");

        /// <summary>
        ///     Lists available migrations.
        /// </summary>
        public static string MigrationsListDescription
            => GetString("MigrationsListDescription");

        /// <summary>
        ///     The namespace to use. Matches the directory by default.
        /// </summary>
        public static string MigrationsNamespaceDescription
            => GetString("MigrationsNamespaceDescription");

        /// <summary>
        ///     The directory to put files in. Paths are relative to the project directory. Defaults to "Migrations".
        /// </summary>
        public static string MigrationsOutputDirDescription
            => GetString("MigrationsOutputDirDescription");

        /// <summary>
        ///     Removes the last migration.
        /// </summary>
        public static string MigrationsRemoveDescription
            => GetString("MigrationsRemoveDescription");

        /// <summary>
        ///     Revert the migration if it has been applied to the database.
        /// </summary>
        public static string MigrationsRemoveForceDescription
            => GetString("MigrationsRemoveForceDescription");

        /// <summary>
        ///     Generates a SQL script from migrations.
        /// </summary>
        public static string MigrationsScriptDescription
            => GetString("MigrationsScriptDescription");

        /// <summary>
        ///     The target migration. Defaults to the last migration.
        /// </summary>
        public static string MigrationToDescription
            => GetString("MigrationToDescription");

        /// <summary>
        ///     Missing required argument '{arg}'.
        /// </summary>
        public static string MissingArgument(object? arg)
            => string.Format(
                GetString("MissingArgument", nameof(arg)),
                arg);

        /// <summary>
        ///     Missing required option '--{option}'.
        /// </summary>
        public static string MissingOption(object? option)
            => string.Format(
                GetString("MissingOption", nameof(option)),
                option);

        /// <summary>
        ///     The namespace to use. Matches the directory by default.
        /// </summary>
        public static string NamespaceDescription
            => GetString("NamespaceDescription");

        /// <summary>
        ///     Don't colorize output.
        /// </summary>
        public static string NoColorDescription
            => GetString("NoColorDescription");

        /// <summary>
        ///     Don't connect to the database.
        /// </summary>
        public static string NoConnectDescription
            => GetString("NoConnectDescription");

        /// <summary>
        ///     No DbContext was found.
        /// </summary>
        public static string NoDbContext
            => GetString("NoDbContext");

        /// <summary>
        ///     No migrations were found.
        /// </summary>
        public static string NoMigrations
            => GetString("NoMigrations");

        /// <summary>
        ///     Don't use the pluralizer.
        /// </summary>
        public static string NoPluralizeDescription
            => GetString("NoPluralizeDescription");

        /// <summary>
        ///     Don't generate SQL transaction statements.
        /// </summary>
        public static string NoTransactionsDescription
            => GetString("NoTransactionsDescription");

        /// <summary>
        ///     Enable nullable reference types.
        /// </summary>
        public static string NullableDescription
            => GetString("NullableDescription");

        /// <summary>
        ///     Options: {options}
        /// </summary>
        public static string Options(object? options)
            => string.Format(
                GetString("Options", nameof(options)),
                options);

        /// <summary>
        ///     The file to write the result to.
        /// </summary>
        public static string OutputDescription
            => GetString("OutputDescription");

        /// <summary>
        ///     The directory to put files in. Paths are relative to the project directory.
        /// </summary>
        public static string OutputDirDescription
            => GetString("OutputDirDescription");

        /// <summary>
        ///      (Pending)
        /// </summary>
        public static string Pending
            => GetString("Pending");

        /// <summary>
        ///     Prefix output with level.
        /// </summary>
        public static string PrefixDescription
            => GetString("PrefixDescription");

        /// <summary>
        ///     The path to the startup project file.
        /// </summary>
        public static string ProjectDescription
            => GetString("ProjectDescription");

        /// <summary>
        ///     The project directory. Defaults to the current working directory.
        /// </summary>
        public static string ProjectDirDescription
            => GetString("ProjectDirDescription");

        /// <summary>
        ///     The provider to use. (E.g. Microsoft.EntityFrameworkCore.SqlServer)
        /// </summary>
        public static string ProviderDescription
            => GetString("ProviderDescription");

        /// <summary>
        ///     Provider name: {provider}
        /// </summary>
        public static string ProviderName(object? provider)
            => string.Format(
                GetString("ProviderName", nameof(provider)),
                provider);

        /// <summary>
        ///     Remaining arguments: {remainingArguments}.
        /// </summary>
        public static string RemainingArguments(object? remainingArguments)
            => string.Format(
                GetString("RemainingArguments", nameof(remainingArguments)),
                remainingArguments);

        /// <summary>
        ///     The root namespace. Defaults to the target assembly name.
        /// </summary>
        public static string RootNamespaceDescription
            => GetString("RootNamespaceDescription");

        /// <summary>
        ///     The schemas of tables to generate entity types for.
        /// </summary>
        public static string SchemasDescription
            => GetString("SchemasDescription");

        /// <summary>
        ///     Also bundle the .NET runtime so it doesn't need to be installed on the machine.
        /// </summary>
        public static string SelfContainedDescription
            => GetString("SelfContainedDescription");

        /// <summary>
        ///     The startup assembly to use. Defaults to the target assembly.
        /// </summary>
        public static string StartupAssemblyDescription
            => GetString("StartupAssemblyDescription");

        /// <summary>
        ///     The path to the project file.
        /// </summary>
        public static string StartupProjectDescription
            => GetString("StartupProjectDescription");

        /// <summary>
        ///     Don't generate DbContext.OnConfiguring.
        /// </summary>
        public static string SuppressOnConfiguringDescription
            => GetString("SuppressOnConfiguringDescription");

        /// <summary>
        ///     The tables to generate entity types for.
        /// </summary>
        public static string TablesDescription
            => GetString("TablesDescription");

        /// <summary>
        ///     Use table and column names directly from the database.
        /// </summary>
        public static string UseDatabaseNamesDescription
            => GetString("UseDatabaseNamesDescription");

        /// <summary>
        ///     Using application base '{appBase}'.
        /// </summary>
        public static string UsingApplicationBase(object? appBase)
            => string.Format(
                GetString("UsingApplicationBase", nameof(appBase)),
                appBase);

        /// <summary>
        ///     Using assembly '{assembly}'.
        /// </summary>
        public static string UsingAssembly(object? assembly)
            => string.Format(
                GetString("UsingAssembly", nameof(assembly)),
                assembly);

        /// <summary>
        ///     Using configuration file '{config}'.
        /// </summary>
        public static string UsingConfigurationFile(object? config)
            => string.Format(
                GetString("UsingConfigurationFile", nameof(config)),
                config);

        /// <summary>
        ///     Using data directory '{dataDir}'.
        /// </summary>
        public static string UsingDataDir(object? dataDir)
            => string.Format(
                GetString("UsingDataDir", nameof(dataDir)),
                dataDir);

        /// <summary>
        ///     Using project directory '{projectDir}'.
        /// </summary>
        public static string UsingProjectDir(object? projectDir)
            => string.Format(
                GetString("UsingProjectDir", nameof(projectDir)),
                projectDir);

        /// <summary>
        ///     Using root namespace '{rootNamespace}'.
        /// </summary>
        public static string UsingRootNamespace(object? rootNamespace)
            => string.Format(
                GetString("UsingRootNamespace", nameof(rootNamespace)),
                rootNamespace);

        /// <summary>
        ///     Using startup assembly '{startupAssembly}'.
        /// </summary>
        public static string UsingStartupAssembly(object? startupAssembly)
            => string.Format(
                GetString("UsingStartupAssembly", nameof(startupAssembly)),
                startupAssembly);

        /// <summary>
        ///     Using working directory '{workingDirectory}'.
        /// </summary>
        public static string UsingWorkingDirectory(object? workingDirectory)
            => string.Format(
                GetString("UsingWorkingDirectory", nameof(workingDirectory)),
                workingDirectory);

        /// <summary>
        ///     Show verbose output.
        /// </summary>
        public static string VerboseDescription
            => GetString("VerboseDescription");

        /// <summary>
        ///     This feature requires Entity Framework Core {version} or higher.
        /// </summary>
        public static string VersionRequired(object? version)
            => string.Format(
                GetString("VersionRequired", nameof(version)),
                version);

        /// <summary>
        ///     The working directory of the tool invoking this command.
        /// </summary>
        public static string WorkingDirDescription
            => GetString("WorkingDirDescription");

        /// <summary>
        ///     Writing '{file}'...
        /// </summary>
        public static string WritingFile(object? file)
            => string.Format(
                GetString("WritingFile", nameof(file)),
                file);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name)!;
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

