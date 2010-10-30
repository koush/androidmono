namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.DatabaseMetaData_))]
	public partial interface DatabaseMetaData  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getURL();
		bool isReadOnly();
		global::java.sql.ResultSet getAttributes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3);
		global::java.sql.Connection getConnection();
		global::java.lang.String getUserName();
		int getResultSetHoldability();
		bool allProceduresAreCallable();
		bool allTablesAreSelectable();
		bool nullsAreSortedHigh();
		bool nullsAreSortedLow();
		bool nullsAreSortedAtStart();
		bool nullsAreSortedAtEnd();
		global::java.lang.String getDatabaseProductName();
		global::java.lang.String getDatabaseProductVersion();
		global::java.lang.String getDriverName();
		global::java.lang.String getDriverVersion();
		int getDriverMajorVersion();
		int getDriverMinorVersion();
		bool usesLocalFiles();
		bool usesLocalFilePerTable();
		bool supportsMixedCaseIdentifiers();
		bool storesUpperCaseIdentifiers();
		bool storesLowerCaseIdentifiers();
		bool storesMixedCaseIdentifiers();
		bool supportsMixedCaseQuotedIdentifiers();
		bool storesUpperCaseQuotedIdentifiers();
		bool storesLowerCaseQuotedIdentifiers();
		bool storesMixedCaseQuotedIdentifiers();
		global::java.lang.String getIdentifierQuoteString();
		global::java.lang.String getSQLKeywords();
		global::java.lang.String getNumericFunctions();
		global::java.lang.String getStringFunctions();
		global::java.lang.String getSystemFunctions();
		global::java.lang.String getTimeDateFunctions();
		global::java.lang.String getSearchStringEscape();
		global::java.lang.String getExtraNameCharacters();
		bool supportsAlterTableWithAddColumn();
		bool supportsAlterTableWithDropColumn();
		bool supportsColumnAliasing();
		bool nullPlusNonNullIsNull();
		bool supportsConvert(int arg0, int arg1);
		bool supportsConvert();
		bool supportsTableCorrelationNames();
		bool supportsDifferentTableCorrelationNames();
		bool supportsExpressionsInOrderBy();
		bool supportsOrderByUnrelated();
		bool supportsGroupBy();
		bool supportsGroupByUnrelated();
		bool supportsGroupByBeyondSelect();
		bool supportsLikeEscapeClause();
		bool supportsMultipleResultSets();
		bool supportsMultipleTransactions();
		bool supportsNonNullableColumns();
		bool supportsMinimumSQLGrammar();
		bool supportsCoreSQLGrammar();
		bool supportsExtendedSQLGrammar();
		bool supportsANSI92EntryLevelSQL();
		bool supportsANSI92IntermediateSQL();
		bool supportsANSI92FullSQL();
		bool supportsIntegrityEnhancementFacility();
		bool supportsOuterJoins();
		bool supportsFullOuterJoins();
		bool supportsLimitedOuterJoins();
		global::java.lang.String getSchemaTerm();
		global::java.lang.String getProcedureTerm();
		global::java.lang.String getCatalogTerm();
		bool isCatalogAtStart();
		global::java.lang.String getCatalogSeparator();
		bool supportsSchemasInDataManipulation();
		bool supportsSchemasInProcedureCalls();
		bool supportsSchemasInTableDefinitions();
		bool supportsSchemasInIndexDefinitions();
		bool supportsSchemasInPrivilegeDefinitions();
		bool supportsCatalogsInDataManipulation();
		bool supportsCatalogsInProcedureCalls();
		bool supportsCatalogsInTableDefinitions();
		bool supportsCatalogsInIndexDefinitions();
		bool supportsCatalogsInPrivilegeDefinitions();
		bool supportsPositionedDelete();
		bool supportsPositionedUpdate();
		bool supportsSelectForUpdate();
		bool supportsStoredProcedures();
		bool supportsSubqueriesInComparisons();
		bool supportsSubqueriesInExists();
		bool supportsSubqueriesInIns();
		bool supportsSubqueriesInQuantifieds();
		bool supportsCorrelatedSubqueries();
		bool supportsUnion();
		bool supportsUnionAll();
		bool supportsOpenCursorsAcrossCommit();
		bool supportsOpenCursorsAcrossRollback();
		bool supportsOpenStatementsAcrossCommit();
		bool supportsOpenStatementsAcrossRollback();
		int getMaxBinaryLiteralLength();
		int getMaxCharLiteralLength();
		int getMaxColumnNameLength();
		int getMaxColumnsInGroupBy();
		int getMaxColumnsInIndex();
		int getMaxColumnsInOrderBy();
		int getMaxColumnsInSelect();
		int getMaxColumnsInTable();
		int getMaxConnections();
		int getMaxCursorNameLength();
		int getMaxIndexLength();
		int getMaxSchemaNameLength();
		int getMaxProcedureNameLength();
		int getMaxCatalogNameLength();
		int getMaxRowSize();
		bool doesMaxRowSizeIncludeBlobs();
		int getMaxStatementLength();
		int getMaxStatements();
		int getMaxTableNameLength();
		int getMaxTablesInSelect();
		int getMaxUserNameLength();
		int getDefaultTransactionIsolation();
		bool supportsTransactions();
		bool supportsTransactionIsolationLevel(int arg0);
		bool supportsDataDefinitionAndDataManipulationTransactions();
		bool supportsDataManipulationTransactionsOnly();
		bool dataDefinitionCausesTransactionCommit();
		bool dataDefinitionIgnoredInTransactions();
		global::java.sql.ResultSet getProcedures(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getProcedureColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getSchemas();
		global::java.sql.ResultSet getSchemas(java.lang.String arg0, java.lang.String arg1);
		global::java.sql.ResultSet getCatalogs();
		global::java.sql.ResultSet getTableTypes();
		global::java.sql.ResultSet getColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getColumnPrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getTablePrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getBestRowIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, bool arg4);
		global::java.sql.ResultSet getVersionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getPrimaryKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getImportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getExportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getCrossReference(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5);
		global::java.sql.ResultSet getTypeInfo();
		global::java.sql.ResultSet getIndexInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3, bool arg4);
		bool supportsResultSetType(int arg0);
		bool supportsResultSetConcurrency(int arg0, int arg1);
		bool ownUpdatesAreVisible(int arg0);
		bool ownDeletesAreVisible(int arg0);
		bool ownInsertsAreVisible(int arg0);
		bool othersUpdatesAreVisible(int arg0);
		bool othersDeletesAreVisible(int arg0);
		bool othersInsertsAreVisible(int arg0);
		bool updatesAreDetected(int arg0);
		bool deletesAreDetected(int arg0);
		bool insertsAreDetected(int arg0);
		bool supportsBatchUpdates();
		global::java.sql.ResultSet getUDTs(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int[] arg3);
		bool supportsSavepoints();
		bool supportsNamedParameters();
		bool supportsMultipleOpenResults();
		bool supportsGetGeneratedKeys();
		global::java.sql.ResultSet getSuperTypes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getSuperTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		bool supportsResultSetHoldability(int arg0);
		int getDatabaseMajorVersion();
		int getDatabaseMinorVersion();
		int getJDBCMajorVersion();
		int getJDBCMinorVersion();
		int getSQLStateType();
		bool locatorsUpdateCopy();
		bool supportsStatementPooling();
		bool supportsStoredFunctionsUsingCallSyntax();
		bool autoCommitFailureClosesAllResultSets();
		global::java.sql.ResultSet getClientInfoProperties();
		global::java.sql.ResultSet getFunctions(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getFunctionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.DatabaseMetaData))]
	internal sealed partial class DatabaseMetaData_ : java.lang.Object, DatabaseMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatabaseMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getURL24377;
		global::java.lang.String java.sql.DatabaseMetaData.getURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getURL", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getURL24377) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly24378;
		bool java.sql.DatabaseMetaData.isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "isReadOnly", "()Z", ref global::java.sql.DatabaseMetaData_._isReadOnly24378);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes24379;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getAttributes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getAttributes24379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTables24380;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getTables24380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24381;
		global::java.sql.Connection java.sql.DatabaseMetaData.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::java.sql.DatabaseMetaData_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::java.sql.DatabaseMetaData_._getConnection24381) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getUserName24382;
		global::java.lang.String java.sql.DatabaseMetaData.getUserName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getUserName", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getUserName24382) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24383;
		int java.sql.DatabaseMetaData.getResultSetHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getResultSetHoldability", "()I", ref global::java.sql.DatabaseMetaData_._getResultSetHoldability24383);
		}
		internal static global::MonoJavaBridge.MethodId _allProceduresAreCallable24384;
		bool java.sql.DatabaseMetaData.allProceduresAreCallable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "allProceduresAreCallable", "()Z", ref global::java.sql.DatabaseMetaData_._allProceduresAreCallable24384);
		}
		internal static global::MonoJavaBridge.MethodId _allTablesAreSelectable24385;
		bool java.sql.DatabaseMetaData.allTablesAreSelectable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "allTablesAreSelectable", "()Z", ref global::java.sql.DatabaseMetaData_._allTablesAreSelectable24385);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedHigh24386;
		bool java.sql.DatabaseMetaData.nullsAreSortedHigh()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedHigh", "()Z", ref global::java.sql.DatabaseMetaData_._nullsAreSortedHigh24386);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedLow24387;
		bool java.sql.DatabaseMetaData.nullsAreSortedLow()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedLow", "()Z", ref global::java.sql.DatabaseMetaData_._nullsAreSortedLow24387);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtStart24388;
		bool java.sql.DatabaseMetaData.nullsAreSortedAtStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtStart", "()Z", ref global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart24388);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtEnd24389;
		bool java.sql.DatabaseMetaData.nullsAreSortedAtEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtEnd", "()Z", ref global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd24389);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductName24390;
		global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductName", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getDatabaseProductName24390) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductVersion24391;
		global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductVersion", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getDatabaseProductVersion24391) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverName24392;
		global::java.lang.String java.sql.DatabaseMetaData.getDriverName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverName", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getDriverName24392) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverVersion24393;
		global::java.lang.String java.sql.DatabaseMetaData.getDriverVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverVersion", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getDriverVersion24393) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMajorVersion24394;
		int java.sql.DatabaseMetaData.getDriverMajorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverMajorVersion", "()I", ref global::java.sql.DatabaseMetaData_._getDriverMajorVersion24394);
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMinorVersion24395;
		int java.sql.DatabaseMetaData.getDriverMinorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverMinorVersion", "()I", ref global::java.sql.DatabaseMetaData_._getDriverMinorVersion24395);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFiles24396;
		bool java.sql.DatabaseMetaData.usesLocalFiles()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFiles", "()Z", ref global::java.sql.DatabaseMetaData_._usesLocalFiles24396);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFilePerTable24397;
		bool java.sql.DatabaseMetaData.usesLocalFilePerTable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFilePerTable", "()Z", ref global::java.sql.DatabaseMetaData_._usesLocalFilePerTable24397);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseIdentifiers24398;
		bool java.sql.DatabaseMetaData.supportsMixedCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers24398);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseIdentifiers24399;
		bool java.sql.DatabaseMetaData.storesUpperCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers24399);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseIdentifiers24400;
		bool java.sql.DatabaseMetaData.storesLowerCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers24400);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseIdentifiers24401;
		bool java.sql.DatabaseMetaData.storesMixedCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers24401);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseQuotedIdentifiers24402;
		bool java.sql.DatabaseMetaData.supportsMixedCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers24402);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseQuotedIdentifiers24403;
		bool java.sql.DatabaseMetaData.storesUpperCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers24403);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseQuotedIdentifiers24404;
		bool java.sql.DatabaseMetaData.storesLowerCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers24404);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseQuotedIdentifiers24405;
		bool java.sql.DatabaseMetaData.storesMixedCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers24405);
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifierQuoteString24406;
		global::java.lang.String java.sql.DatabaseMetaData.getIdentifierQuoteString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getIdentifierQuoteString", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getIdentifierQuoteString24406) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSQLKeywords24407;
		global::java.lang.String java.sql.DatabaseMetaData.getSQLKeywords()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSQLKeywords", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getSQLKeywords24407) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericFunctions24408;
		global::java.lang.String java.sql.DatabaseMetaData.getNumericFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getNumericFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getNumericFunctions24408) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStringFunctions24409;
		global::java.lang.String java.sql.DatabaseMetaData.getStringFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getStringFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getStringFunctions24409) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemFunctions24410;
		global::java.lang.String java.sql.DatabaseMetaData.getSystemFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSystemFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getSystemFunctions24410) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDateFunctions24411;
		global::java.lang.String java.sql.DatabaseMetaData.getTimeDateFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTimeDateFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getTimeDateFunctions24411) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSearchStringEscape24412;
		global::java.lang.String java.sql.DatabaseMetaData.getSearchStringEscape()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSearchStringEscape", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getSearchStringEscape24412) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExtraNameCharacters24413;
		global::java.lang.String java.sql.DatabaseMetaData.getExtraNameCharacters()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getExtraNameCharacters", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getExtraNameCharacters24413) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithAddColumn24414;
		bool java.sql.DatabaseMetaData.supportsAlterTableWithAddColumn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithAddColumn", "()Z", ref global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn24414);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithDropColumn24415;
		bool java.sql.DatabaseMetaData.supportsAlterTableWithDropColumn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithDropColumn", "()Z", ref global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn24415);
		}
		internal static global::MonoJavaBridge.MethodId _supportsColumnAliasing24416;
		bool java.sql.DatabaseMetaData.supportsColumnAliasing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsColumnAliasing", "()Z", ref global::java.sql.DatabaseMetaData_._supportsColumnAliasing24416);
		}
		internal static global::MonoJavaBridge.MethodId _nullPlusNonNullIsNull24417;
		bool java.sql.DatabaseMetaData.nullPlusNonNullIsNull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullPlusNonNullIsNull", "()Z", ref global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull24417);
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert24418;
		bool java.sql.DatabaseMetaData.supportsConvert(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "(II)Z", ref global::java.sql.DatabaseMetaData_._supportsConvert24418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert24419;
		bool java.sql.DatabaseMetaData.supportsConvert()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "()Z", ref global::java.sql.DatabaseMetaData_._supportsConvert24419);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTableCorrelationNames24420;
		bool java.sql.DatabaseMetaData.supportsTableCorrelationNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsTableCorrelationNames", "()Z", ref global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames24420);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDifferentTableCorrelationNames24421;
		bool java.sql.DatabaseMetaData.supportsDifferentTableCorrelationNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsDifferentTableCorrelationNames", "()Z", ref global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames24421);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExpressionsInOrderBy24422;
		bool java.sql.DatabaseMetaData.supportsExpressionsInOrderBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsExpressionsInOrderBy", "()Z", ref global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy24422);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOrderByUnrelated24423;
		bool java.sql.DatabaseMetaData.supportsOrderByUnrelated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOrderByUnrelated", "()Z", ref global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated24423);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupBy24424;
		bool java.sql.DatabaseMetaData.supportsGroupBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupBy", "()Z", ref global::java.sql.DatabaseMetaData_._supportsGroupBy24424);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByUnrelated24425;
		bool java.sql.DatabaseMetaData.supportsGroupByUnrelated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByUnrelated", "()Z", ref global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated24425);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByBeyondSelect24426;
		bool java.sql.DatabaseMetaData.supportsGroupByBeyondSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByBeyondSelect", "()Z", ref global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect24426);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLikeEscapeClause24427;
		bool java.sql.DatabaseMetaData.supportsLikeEscapeClause()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsLikeEscapeClause", "()Z", ref global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause24427);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleResultSets24428;
		bool java.sql.DatabaseMetaData.supportsMultipleResultSets()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleResultSets", "()Z", ref global::java.sql.DatabaseMetaData_._supportsMultipleResultSets24428);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleTransactions24429;
		bool java.sql.DatabaseMetaData.supportsMultipleTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsMultipleTransactions24429);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNonNullableColumns24430;
		bool java.sql.DatabaseMetaData.supportsNonNullableColumns()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsNonNullableColumns", "()Z", ref global::java.sql.DatabaseMetaData_._supportsNonNullableColumns24430);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMinimumSQLGrammar24431;
		bool java.sql.DatabaseMetaData.supportsMinimumSQLGrammar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMinimumSQLGrammar", "()Z", ref global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar24431);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCoreSQLGrammar24432;
		bool java.sql.DatabaseMetaData.supportsCoreSQLGrammar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCoreSQLGrammar", "()Z", ref global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar24432);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExtendedSQLGrammar24433;
		bool java.sql.DatabaseMetaData.supportsExtendedSQLGrammar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsExtendedSQLGrammar", "()Z", ref global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar24433);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92EntryLevelSQL24434;
		bool java.sql.DatabaseMetaData.supportsANSI92EntryLevelSQL()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92EntryLevelSQL", "()Z", ref global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL24434);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92IntermediateSQL24435;
		bool java.sql.DatabaseMetaData.supportsANSI92IntermediateSQL()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92IntermediateSQL", "()Z", ref global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL24435);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92FullSQL24436;
		bool java.sql.DatabaseMetaData.supportsANSI92FullSQL()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92FullSQL", "()Z", ref global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL24436);
		}
		internal static global::MonoJavaBridge.MethodId _supportsIntegrityEnhancementFacility24437;
		bool java.sql.DatabaseMetaData.supportsIntegrityEnhancementFacility()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsIntegrityEnhancementFacility", "()Z", ref global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility24437);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOuterJoins24438;
		bool java.sql.DatabaseMetaData.supportsOuterJoins()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOuterJoins", "()Z", ref global::java.sql.DatabaseMetaData_._supportsOuterJoins24438);
		}
		internal static global::MonoJavaBridge.MethodId _supportsFullOuterJoins24439;
		bool java.sql.DatabaseMetaData.supportsFullOuterJoins()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsFullOuterJoins", "()Z", ref global::java.sql.DatabaseMetaData_._supportsFullOuterJoins24439);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLimitedOuterJoins24440;
		bool java.sql.DatabaseMetaData.supportsLimitedOuterJoins()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsLimitedOuterJoins", "()Z", ref global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins24440);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTerm24441;
		global::java.lang.String java.sql.DatabaseMetaData.getSchemaTerm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSchemaTerm", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getSchemaTerm24441) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureTerm24442;
		global::java.lang.String java.sql.DatabaseMetaData.getProcedureTerm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getProcedureTerm", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getProcedureTerm24442) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogTerm24443;
		global::java.lang.String java.sql.DatabaseMetaData.getCatalogTerm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCatalogTerm", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getCatalogTerm24443) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isCatalogAtStart24444;
		bool java.sql.DatabaseMetaData.isCatalogAtStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "isCatalogAtStart", "()Z", ref global::java.sql.DatabaseMetaData_._isCatalogAtStart24444);
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogSeparator24445;
		global::java.lang.String java.sql.DatabaseMetaData.getCatalogSeparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCatalogSeparator", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._getCatalogSeparator24445) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInDataManipulation24446;
		bool java.sql.DatabaseMetaData.supportsSchemasInDataManipulation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInDataManipulation", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation24446);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInProcedureCalls24447;
		bool java.sql.DatabaseMetaData.supportsSchemasInProcedureCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInProcedureCalls", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls24447);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInTableDefinitions24448;
		bool java.sql.DatabaseMetaData.supportsSchemasInTableDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInTableDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions24448);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInIndexDefinitions24449;
		bool java.sql.DatabaseMetaData.supportsSchemasInIndexDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInIndexDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions24449);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInPrivilegeDefinitions24450;
		bool java.sql.DatabaseMetaData.supportsSchemasInPrivilegeDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInPrivilegeDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions24450);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInDataManipulation24451;
		bool java.sql.DatabaseMetaData.supportsCatalogsInDataManipulation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInDataManipulation", "()Z", ref global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation24451);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInProcedureCalls24452;
		bool java.sql.DatabaseMetaData.supportsCatalogsInProcedureCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInProcedureCalls", "()Z", ref global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls24452);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInTableDefinitions24453;
		bool java.sql.DatabaseMetaData.supportsCatalogsInTableDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInTableDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions24453);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInIndexDefinitions24454;
		bool java.sql.DatabaseMetaData.supportsCatalogsInIndexDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInIndexDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions24454);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInPrivilegeDefinitions24455;
		bool java.sql.DatabaseMetaData.supportsCatalogsInPrivilegeDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInPrivilegeDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions24455);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedDelete24456;
		bool java.sql.DatabaseMetaData.supportsPositionedDelete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedDelete", "()Z", ref global::java.sql.DatabaseMetaData_._supportsPositionedDelete24456);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedUpdate24457;
		bool java.sql.DatabaseMetaData.supportsPositionedUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedUpdate", "()Z", ref global::java.sql.DatabaseMetaData_._supportsPositionedUpdate24457);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSelectForUpdate24458;
		bool java.sql.DatabaseMetaData.supportsSelectForUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSelectForUpdate", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSelectForUpdate24458);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredProcedures24459;
		bool java.sql.DatabaseMetaData.supportsStoredProcedures()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredProcedures", "()Z", ref global::java.sql.DatabaseMetaData_._supportsStoredProcedures24459);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInComparisons24460;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInComparisons()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInComparisons", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons24460);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInExists24461;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInExists()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInExists", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists24461);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInIns24462;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInIns()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInIns", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns24462);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInQuantifieds24463;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInQuantifieds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInQuantifieds", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds24463);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCorrelatedSubqueries24464;
		bool java.sql.DatabaseMetaData.supportsCorrelatedSubqueries()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCorrelatedSubqueries", "()Z", ref global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries24464);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnion24465;
		bool java.sql.DatabaseMetaData.supportsUnion()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsUnion", "()Z", ref global::java.sql.DatabaseMetaData_._supportsUnion24465);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnionAll24466;
		bool java.sql.DatabaseMetaData.supportsUnionAll()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsUnionAll", "()Z", ref global::java.sql.DatabaseMetaData_._supportsUnionAll24466);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossCommit24467;
		bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossCommit", "()Z", ref global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit24467);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossRollback24468;
		bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossRollback()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossRollback", "()Z", ref global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback24468);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossCommit24469;
		bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossCommit", "()Z", ref global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit24469);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossRollback24470;
		bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossRollback()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossRollback", "()Z", ref global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback24470);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxBinaryLiteralLength24471;
		int java.sql.DatabaseMetaData.getMaxBinaryLiteralLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxBinaryLiteralLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength24471);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCharLiteralLength24472;
		int java.sql.DatabaseMetaData.getMaxCharLiteralLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxCharLiteralLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength24472);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnNameLength24473;
		int java.sql.DatabaseMetaData.getMaxColumnNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnNameLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxColumnNameLength24473);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInGroupBy24474;
		int java.sql.DatabaseMetaData.getMaxColumnsInGroupBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInGroupBy", "()I", ref global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy24474);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInIndex24475;
		int java.sql.DatabaseMetaData.getMaxColumnsInIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInIndex", "()I", ref global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex24475);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInOrderBy24476;
		int java.sql.DatabaseMetaData.getMaxColumnsInOrderBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInOrderBy", "()I", ref global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy24476);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInSelect24477;
		int java.sql.DatabaseMetaData.getMaxColumnsInSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInSelect", "()I", ref global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect24477);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInTable24478;
		int java.sql.DatabaseMetaData.getMaxColumnsInTable()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInTable", "()I", ref global::java.sql.DatabaseMetaData_._getMaxColumnsInTable24478);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxConnections24479;
		int java.sql.DatabaseMetaData.getMaxConnections()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxConnections", "()I", ref global::java.sql.DatabaseMetaData_._getMaxConnections24479);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCursorNameLength24480;
		int java.sql.DatabaseMetaData.getMaxCursorNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxCursorNameLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxCursorNameLength24480);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxIndexLength24481;
		int java.sql.DatabaseMetaData.getMaxIndexLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxIndexLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxIndexLength24481);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxSchemaNameLength24482;
		int java.sql.DatabaseMetaData.getMaxSchemaNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxSchemaNameLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength24482);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxProcedureNameLength24483;
		int java.sql.DatabaseMetaData.getMaxProcedureNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxProcedureNameLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength24483);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCatalogNameLength24484;
		int java.sql.DatabaseMetaData.getMaxCatalogNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxCatalogNameLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength24484);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRowSize24485;
		int java.sql.DatabaseMetaData.getMaxRowSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxRowSize", "()I", ref global::java.sql.DatabaseMetaData_._getMaxRowSize24485);
		}
		internal static global::MonoJavaBridge.MethodId _doesMaxRowSizeIncludeBlobs24486;
		bool java.sql.DatabaseMetaData.doesMaxRowSizeIncludeBlobs()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "doesMaxRowSizeIncludeBlobs", "()Z", ref global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs24486);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatementLength24487;
		int java.sql.DatabaseMetaData.getMaxStatementLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatementLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxStatementLength24487);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatements24488;
		int java.sql.DatabaseMetaData.getMaxStatements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatements", "()I", ref global::java.sql.DatabaseMetaData_._getMaxStatements24488);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTableNameLength24489;
		int java.sql.DatabaseMetaData.getMaxTableNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxTableNameLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxTableNameLength24489);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTablesInSelect24490;
		int java.sql.DatabaseMetaData.getMaxTablesInSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxTablesInSelect", "()I", ref global::java.sql.DatabaseMetaData_._getMaxTablesInSelect24490);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxUserNameLength24491;
		int java.sql.DatabaseMetaData.getMaxUserNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxUserNameLength", "()I", ref global::java.sql.DatabaseMetaData_._getMaxUserNameLength24491);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultTransactionIsolation24492;
		int java.sql.DatabaseMetaData.getDefaultTransactionIsolation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDefaultTransactionIsolation", "()I", ref global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation24492);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactions24493;
		bool java.sql.DatabaseMetaData.supportsTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsTransactions24493);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactionIsolationLevel24494;
		bool java.sql.DatabaseMetaData.supportsTransactionIsolationLevel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactionIsolationLevel", "(I)Z", ref global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel24494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataDefinitionAndDataManipulationTransactions24495;
		bool java.sql.DatabaseMetaData.supportsDataDefinitionAndDataManipulationTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsDataDefinitionAndDataManipulationTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions24495);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataManipulationTransactionsOnly24496;
		bool java.sql.DatabaseMetaData.supportsDataManipulationTransactionsOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsDataManipulationTransactionsOnly", "()Z", ref global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly24496);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionCausesTransactionCommit24497;
		bool java.sql.DatabaseMetaData.dataDefinitionCausesTransactionCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionCausesTransactionCommit", "()Z", ref global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit24497);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionIgnoredInTransactions24498;
		bool java.sql.DatabaseMetaData.dataDefinitionIgnoredInTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionIgnoredInTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions24498);
		}
		internal static global::MonoJavaBridge.MethodId _getProcedures24499;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedures(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getProcedures24499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureColumns24500;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedureColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getProcedureColumns24500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas24501;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getSchemas24501) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas24502;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getSchemas24502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogs24503;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getCatalogs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCatalogs", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getCatalogs24503) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTableTypes24504;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTableTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTableTypes", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getTableTypes24504) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumns24505;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getColumns24505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnPrivileges24506;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumnPrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getColumnPrivileges24506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTablePrivileges24507;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTablePrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getTablePrivileges24507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getBestRowIdentifier24508;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getBestRowIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, bool arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getBestRowIdentifier24508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionColumns24509;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getVersionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getVersionColumns24509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimaryKeys24510;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getPrimaryKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getPrimaryKeys24510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getImportedKeys24511;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getImportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getImportedKeys24511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getExportedKeys24512;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getExportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getExportedKeys24512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCrossReference24513;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getCrossReference(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getCrossReference24513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfo24514;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTypeInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTypeInfo", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getTypeInfo24514) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getIndexInfo24515;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getIndexInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3, bool arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getIndexInfo24515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetType24516;
		bool java.sql.DatabaseMetaData.supportsResultSetType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetType", "(I)Z", ref global::java.sql.DatabaseMetaData_._supportsResultSetType24516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetConcurrency24517;
		bool java.sql.DatabaseMetaData.supportsResultSetConcurrency(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetConcurrency", "(II)Z", ref global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency24517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ownUpdatesAreVisible24518;
		bool java.sql.DatabaseMetaData.ownUpdatesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "ownUpdatesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible24518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownDeletesAreVisible24519;
		bool java.sql.DatabaseMetaData.ownDeletesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "ownDeletesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._ownDeletesAreVisible24519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownInsertsAreVisible24520;
		bool java.sql.DatabaseMetaData.ownInsertsAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "ownInsertsAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._ownInsertsAreVisible24520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersUpdatesAreVisible24521;
		bool java.sql.DatabaseMetaData.othersUpdatesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "othersUpdatesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible24521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersDeletesAreVisible24522;
		bool java.sql.DatabaseMetaData.othersDeletesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "othersDeletesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._othersDeletesAreVisible24522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersInsertsAreVisible24523;
		bool java.sql.DatabaseMetaData.othersInsertsAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "othersInsertsAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._othersInsertsAreVisible24523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updatesAreDetected24524;
		bool java.sql.DatabaseMetaData.updatesAreDetected(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "updatesAreDetected", "(I)Z", ref global::java.sql.DatabaseMetaData_._updatesAreDetected24524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deletesAreDetected24525;
		bool java.sql.DatabaseMetaData.deletesAreDetected(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "deletesAreDetected", "(I)Z", ref global::java.sql.DatabaseMetaData_._deletesAreDetected24525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertsAreDetected24526;
		bool java.sql.DatabaseMetaData.insertsAreDetected(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "insertsAreDetected", "(I)Z", ref global::java.sql.DatabaseMetaData_._insertsAreDetected24526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsBatchUpdates24527;
		bool java.sql.DatabaseMetaData.supportsBatchUpdates()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsBatchUpdates", "()Z", ref global::java.sql.DatabaseMetaData_._supportsBatchUpdates24527);
		}
		internal static global::MonoJavaBridge.MethodId _getUDTs24528;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getUDTs(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getUDTs24528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSavepoints24529;
		bool java.sql.DatabaseMetaData.supportsSavepoints()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSavepoints", "()Z", ref global::java.sql.DatabaseMetaData_._supportsSavepoints24529);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNamedParameters24530;
		bool java.sql.DatabaseMetaData.supportsNamedParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsNamedParameters", "()Z", ref global::java.sql.DatabaseMetaData_._supportsNamedParameters24530);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleOpenResults24531;
		bool java.sql.DatabaseMetaData.supportsMultipleOpenResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleOpenResults", "()Z", ref global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults24531);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGetGeneratedKeys24532;
		bool java.sql.DatabaseMetaData.supportsGetGeneratedKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGetGeneratedKeys", "()Z", ref global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys24532);
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTypes24533;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTypes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getSuperTypes24533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTables24534;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getSuperTables24534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetHoldability24535;
		bool java.sql.DatabaseMetaData.supportsResultSetHoldability(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetHoldability", "(I)Z", ref global::java.sql.DatabaseMetaData_._supportsResultSetHoldability24535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMajorVersion24536;
		int java.sql.DatabaseMetaData.getDatabaseMajorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMajorVersion", "()I", ref global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion24536);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMinorVersion24537;
		int java.sql.DatabaseMetaData.getDatabaseMinorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMinorVersion", "()I", ref global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion24537);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMajorVersion24538;
		int java.sql.DatabaseMetaData.getJDBCMajorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMajorVersion", "()I", ref global::java.sql.DatabaseMetaData_._getJDBCMajorVersion24538);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMinorVersion24539;
		int java.sql.DatabaseMetaData.getJDBCMinorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMinorVersion", "()I", ref global::java.sql.DatabaseMetaData_._getJDBCMinorVersion24539);
		}
		internal static global::MonoJavaBridge.MethodId _getSQLStateType24540;
		int java.sql.DatabaseMetaData.getSQLStateType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getSQLStateType", "()I", ref global::java.sql.DatabaseMetaData_._getSQLStateType24540);
		}
		internal static global::MonoJavaBridge.MethodId _locatorsUpdateCopy24541;
		bool java.sql.DatabaseMetaData.locatorsUpdateCopy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "locatorsUpdateCopy", "()Z", ref global::java.sql.DatabaseMetaData_._locatorsUpdateCopy24541);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStatementPooling24542;
		bool java.sql.DatabaseMetaData.supportsStatementPooling()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsStatementPooling", "()Z", ref global::java.sql.DatabaseMetaData_._supportsStatementPooling24542);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredFunctionsUsingCallSyntax24543;
		bool java.sql.DatabaseMetaData.supportsStoredFunctionsUsingCallSyntax()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredFunctionsUsingCallSyntax", "()Z", ref global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax24543);
		}
		internal static global::MonoJavaBridge.MethodId _autoCommitFailureClosesAllResultSets24544;
		bool java.sql.DatabaseMetaData.autoCommitFailureClosesAllResultSets()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "autoCommitFailureClosesAllResultSets", "()Z", ref global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets24544);
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfoProperties24545;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getClientInfoProperties()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getClientInfoProperties", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getClientInfoProperties24545) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctions24546;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctions(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getFunctions24546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctionColumns24547;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._getFunctionColumns24547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		static DatabaseMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DatabaseMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DatabaseMetaData"));
		}
		internal static void InitJNI()
		{
		}
	}
}
