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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String java.sql.DatabaseMetaData.getURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getURL", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.sql.DatabaseMetaData.isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "isReadOnly", "()Z", ref global::java.sql.DatabaseMetaData_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getAttributes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.sql.Connection java.sql.DatabaseMetaData.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::java.sql.DatabaseMetaData_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::java.sql.DatabaseMetaData_._m4) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String java.sql.DatabaseMetaData.getUserName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getUserName", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int java.sql.DatabaseMetaData.getResultSetHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getResultSetHoldability", "()I", ref global::java.sql.DatabaseMetaData_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool java.sql.DatabaseMetaData.allProceduresAreCallable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "allProceduresAreCallable", "()Z", ref global::java.sql.DatabaseMetaData_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool java.sql.DatabaseMetaData.allTablesAreSelectable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "allTablesAreSelectable", "()Z", ref global::java.sql.DatabaseMetaData_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool java.sql.DatabaseMetaData.nullsAreSortedHigh()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedHigh", "()Z", ref global::java.sql.DatabaseMetaData_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool java.sql.DatabaseMetaData.nullsAreSortedLow()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedLow", "()Z", ref global::java.sql.DatabaseMetaData_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.sql.DatabaseMetaData.nullsAreSortedAtStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtStart", "()Z", ref global::java.sql.DatabaseMetaData_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		bool java.sql.DatabaseMetaData.nullsAreSortedAtEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtEnd", "()Z", ref global::java.sql.DatabaseMetaData_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductName", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductVersion", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.String java.sql.DatabaseMetaData.getDriverName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverName", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.lang.String java.sql.DatabaseMetaData.getDriverVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverVersion", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		int java.sql.DatabaseMetaData.getDriverMajorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverMajorVersion", "()I", ref global::java.sql.DatabaseMetaData_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		int java.sql.DatabaseMetaData.getDriverMinorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDriverMinorVersion", "()I", ref global::java.sql.DatabaseMetaData_._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool java.sql.DatabaseMetaData.usesLocalFiles()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFiles", "()Z", ref global::java.sql.DatabaseMetaData_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool java.sql.DatabaseMetaData.usesLocalFilePerTable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFilePerTable", "()Z", ref global::java.sql.DatabaseMetaData_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool java.sql.DatabaseMetaData.supportsMixedCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool java.sql.DatabaseMetaData.storesUpperCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool java.sql.DatabaseMetaData.storesLowerCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		bool java.sql.DatabaseMetaData.storesMixedCaseIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		bool java.sql.DatabaseMetaData.supportsMixedCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		bool java.sql.DatabaseMetaData.storesUpperCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		bool java.sql.DatabaseMetaData.storesLowerCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		bool java.sql.DatabaseMetaData.storesMixedCaseQuotedIdentifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseQuotedIdentifiers", "()Z", ref global::java.sql.DatabaseMetaData_._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::java.lang.String java.sql.DatabaseMetaData.getIdentifierQuoteString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getIdentifierQuoteString", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m29) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::java.lang.String java.sql.DatabaseMetaData.getSQLKeywords()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSQLKeywords", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m30) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.lang.String java.sql.DatabaseMetaData.getNumericFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getNumericFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m31) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		global::java.lang.String java.sql.DatabaseMetaData.getStringFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getStringFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m32) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::java.lang.String java.sql.DatabaseMetaData.getSystemFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSystemFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m33) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		global::java.lang.String java.sql.DatabaseMetaData.getTimeDateFunctions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTimeDateFunctions", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m34) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::java.lang.String java.sql.DatabaseMetaData.getSearchStringEscape()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSearchStringEscape", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m35) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		global::java.lang.String java.sql.DatabaseMetaData.getExtraNameCharacters()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getExtraNameCharacters", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m36) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		bool java.sql.DatabaseMetaData.supportsAlterTableWithAddColumn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithAddColumn", "()Z", ref global::java.sql.DatabaseMetaData_._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		bool java.sql.DatabaseMetaData.supportsAlterTableWithDropColumn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithDropColumn", "()Z", ref global::java.sql.DatabaseMetaData_._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		bool java.sql.DatabaseMetaData.supportsColumnAliasing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsColumnAliasing", "()Z", ref global::java.sql.DatabaseMetaData_._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		bool java.sql.DatabaseMetaData.nullPlusNonNullIsNull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "nullPlusNonNullIsNull", "()Z", ref global::java.sql.DatabaseMetaData_._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		bool java.sql.DatabaseMetaData.supportsConvert(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "(II)Z", ref global::java.sql.DatabaseMetaData_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		bool java.sql.DatabaseMetaData.supportsConvert()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "()Z", ref global::java.sql.DatabaseMetaData_._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		bool java.sql.DatabaseMetaData.supportsTableCorrelationNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsTableCorrelationNames", "()Z", ref global::java.sql.DatabaseMetaData_._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		bool java.sql.DatabaseMetaData.supportsDifferentTableCorrelationNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsDifferentTableCorrelationNames", "()Z", ref global::java.sql.DatabaseMetaData_._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		bool java.sql.DatabaseMetaData.supportsExpressionsInOrderBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsExpressionsInOrderBy", "()Z", ref global::java.sql.DatabaseMetaData_._m45);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		bool java.sql.DatabaseMetaData.supportsOrderByUnrelated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOrderByUnrelated", "()Z", ref global::java.sql.DatabaseMetaData_._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		bool java.sql.DatabaseMetaData.supportsGroupBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupBy", "()Z", ref global::java.sql.DatabaseMetaData_._m47);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		bool java.sql.DatabaseMetaData.supportsGroupByUnrelated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByUnrelated", "()Z", ref global::java.sql.DatabaseMetaData_._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		bool java.sql.DatabaseMetaData.supportsGroupByBeyondSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByBeyondSelect", "()Z", ref global::java.sql.DatabaseMetaData_._m49);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		bool java.sql.DatabaseMetaData.supportsLikeEscapeClause()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsLikeEscapeClause", "()Z", ref global::java.sql.DatabaseMetaData_._m50);
		}
		private static global::MonoJavaBridge.MethodId _m51;
		bool java.sql.DatabaseMetaData.supportsMultipleResultSets()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleResultSets", "()Z", ref global::java.sql.DatabaseMetaData_._m51);
		}
		private static global::MonoJavaBridge.MethodId _m52;
		bool java.sql.DatabaseMetaData.supportsMultipleTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		bool java.sql.DatabaseMetaData.supportsNonNullableColumns()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsNonNullableColumns", "()Z", ref global::java.sql.DatabaseMetaData_._m53);
		}
		private static global::MonoJavaBridge.MethodId _m54;
		bool java.sql.DatabaseMetaData.supportsMinimumSQLGrammar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMinimumSQLGrammar", "()Z", ref global::java.sql.DatabaseMetaData_._m54);
		}
		private static global::MonoJavaBridge.MethodId _m55;
		bool java.sql.DatabaseMetaData.supportsCoreSQLGrammar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCoreSQLGrammar", "()Z", ref global::java.sql.DatabaseMetaData_._m55);
		}
		private static global::MonoJavaBridge.MethodId _m56;
		bool java.sql.DatabaseMetaData.supportsExtendedSQLGrammar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsExtendedSQLGrammar", "()Z", ref global::java.sql.DatabaseMetaData_._m56);
		}
		private static global::MonoJavaBridge.MethodId _m57;
		bool java.sql.DatabaseMetaData.supportsANSI92EntryLevelSQL()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92EntryLevelSQL", "()Z", ref global::java.sql.DatabaseMetaData_._m57);
		}
		private static global::MonoJavaBridge.MethodId _m58;
		bool java.sql.DatabaseMetaData.supportsANSI92IntermediateSQL()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92IntermediateSQL", "()Z", ref global::java.sql.DatabaseMetaData_._m58);
		}
		private static global::MonoJavaBridge.MethodId _m59;
		bool java.sql.DatabaseMetaData.supportsANSI92FullSQL()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92FullSQL", "()Z", ref global::java.sql.DatabaseMetaData_._m59);
		}
		private static global::MonoJavaBridge.MethodId _m60;
		bool java.sql.DatabaseMetaData.supportsIntegrityEnhancementFacility()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsIntegrityEnhancementFacility", "()Z", ref global::java.sql.DatabaseMetaData_._m60);
		}
		private static global::MonoJavaBridge.MethodId _m61;
		bool java.sql.DatabaseMetaData.supportsOuterJoins()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOuterJoins", "()Z", ref global::java.sql.DatabaseMetaData_._m61);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		bool java.sql.DatabaseMetaData.supportsFullOuterJoins()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsFullOuterJoins", "()Z", ref global::java.sql.DatabaseMetaData_._m62);
		}
		private static global::MonoJavaBridge.MethodId _m63;
		bool java.sql.DatabaseMetaData.supportsLimitedOuterJoins()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsLimitedOuterJoins", "()Z", ref global::java.sql.DatabaseMetaData_._m63);
		}
		private static global::MonoJavaBridge.MethodId _m64;
		global::java.lang.String java.sql.DatabaseMetaData.getSchemaTerm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSchemaTerm", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m64) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m65;
		global::java.lang.String java.sql.DatabaseMetaData.getProcedureTerm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getProcedureTerm", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m65) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m66;
		global::java.lang.String java.sql.DatabaseMetaData.getCatalogTerm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCatalogTerm", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m66) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m67;
		bool java.sql.DatabaseMetaData.isCatalogAtStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "isCatalogAtStart", "()Z", ref global::java.sql.DatabaseMetaData_._m67);
		}
		private static global::MonoJavaBridge.MethodId _m68;
		global::java.lang.String java.sql.DatabaseMetaData.getCatalogSeparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCatalogSeparator", "()Ljava/lang/String;", ref global::java.sql.DatabaseMetaData_._m68) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m69;
		bool java.sql.DatabaseMetaData.supportsSchemasInDataManipulation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInDataManipulation", "()Z", ref global::java.sql.DatabaseMetaData_._m69);
		}
		private static global::MonoJavaBridge.MethodId _m70;
		bool java.sql.DatabaseMetaData.supportsSchemasInProcedureCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInProcedureCalls", "()Z", ref global::java.sql.DatabaseMetaData_._m70);
		}
		private static global::MonoJavaBridge.MethodId _m71;
		bool java.sql.DatabaseMetaData.supportsSchemasInTableDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInTableDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._m71);
		}
		private static global::MonoJavaBridge.MethodId _m72;
		bool java.sql.DatabaseMetaData.supportsSchemasInIndexDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInIndexDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._m72);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		bool java.sql.DatabaseMetaData.supportsSchemasInPrivilegeDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInPrivilegeDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._m73);
		}
		private static global::MonoJavaBridge.MethodId _m74;
		bool java.sql.DatabaseMetaData.supportsCatalogsInDataManipulation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInDataManipulation", "()Z", ref global::java.sql.DatabaseMetaData_._m74);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		bool java.sql.DatabaseMetaData.supportsCatalogsInProcedureCalls()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInProcedureCalls", "()Z", ref global::java.sql.DatabaseMetaData_._m75);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		bool java.sql.DatabaseMetaData.supportsCatalogsInTableDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInTableDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._m76);
		}
		private static global::MonoJavaBridge.MethodId _m77;
		bool java.sql.DatabaseMetaData.supportsCatalogsInIndexDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInIndexDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._m77);
		}
		private static global::MonoJavaBridge.MethodId _m78;
		bool java.sql.DatabaseMetaData.supportsCatalogsInPrivilegeDefinitions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInPrivilegeDefinitions", "()Z", ref global::java.sql.DatabaseMetaData_._m78);
		}
		private static global::MonoJavaBridge.MethodId _m79;
		bool java.sql.DatabaseMetaData.supportsPositionedDelete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedDelete", "()Z", ref global::java.sql.DatabaseMetaData_._m79);
		}
		private static global::MonoJavaBridge.MethodId _m80;
		bool java.sql.DatabaseMetaData.supportsPositionedUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedUpdate", "()Z", ref global::java.sql.DatabaseMetaData_._m80);
		}
		private static global::MonoJavaBridge.MethodId _m81;
		bool java.sql.DatabaseMetaData.supportsSelectForUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSelectForUpdate", "()Z", ref global::java.sql.DatabaseMetaData_._m81);
		}
		private static global::MonoJavaBridge.MethodId _m82;
		bool java.sql.DatabaseMetaData.supportsStoredProcedures()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredProcedures", "()Z", ref global::java.sql.DatabaseMetaData_._m82);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInComparisons()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInComparisons", "()Z", ref global::java.sql.DatabaseMetaData_._m83);
		}
		private static global::MonoJavaBridge.MethodId _m84;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInExists()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInExists", "()Z", ref global::java.sql.DatabaseMetaData_._m84);
		}
		private static global::MonoJavaBridge.MethodId _m85;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInIns()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInIns", "()Z", ref global::java.sql.DatabaseMetaData_._m85);
		}
		private static global::MonoJavaBridge.MethodId _m86;
		bool java.sql.DatabaseMetaData.supportsSubqueriesInQuantifieds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInQuantifieds", "()Z", ref global::java.sql.DatabaseMetaData_._m86);
		}
		private static global::MonoJavaBridge.MethodId _m87;
		bool java.sql.DatabaseMetaData.supportsCorrelatedSubqueries()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsCorrelatedSubqueries", "()Z", ref global::java.sql.DatabaseMetaData_._m87);
		}
		private static global::MonoJavaBridge.MethodId _m88;
		bool java.sql.DatabaseMetaData.supportsUnion()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsUnion", "()Z", ref global::java.sql.DatabaseMetaData_._m88);
		}
		private static global::MonoJavaBridge.MethodId _m89;
		bool java.sql.DatabaseMetaData.supportsUnionAll()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsUnionAll", "()Z", ref global::java.sql.DatabaseMetaData_._m89);
		}
		private static global::MonoJavaBridge.MethodId _m90;
		bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossCommit", "()Z", ref global::java.sql.DatabaseMetaData_._m90);
		}
		private static global::MonoJavaBridge.MethodId _m91;
		bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossRollback()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossRollback", "()Z", ref global::java.sql.DatabaseMetaData_._m91);
		}
		private static global::MonoJavaBridge.MethodId _m92;
		bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossCommit", "()Z", ref global::java.sql.DatabaseMetaData_._m92);
		}
		private static global::MonoJavaBridge.MethodId _m93;
		bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossRollback()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossRollback", "()Z", ref global::java.sql.DatabaseMetaData_._m93);
		}
		private static global::MonoJavaBridge.MethodId _m94;
		int java.sql.DatabaseMetaData.getMaxBinaryLiteralLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxBinaryLiteralLength", "()I", ref global::java.sql.DatabaseMetaData_._m94);
		}
		private static global::MonoJavaBridge.MethodId _m95;
		int java.sql.DatabaseMetaData.getMaxCharLiteralLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxCharLiteralLength", "()I", ref global::java.sql.DatabaseMetaData_._m95);
		}
		private static global::MonoJavaBridge.MethodId _m96;
		int java.sql.DatabaseMetaData.getMaxColumnNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnNameLength", "()I", ref global::java.sql.DatabaseMetaData_._m96);
		}
		private static global::MonoJavaBridge.MethodId _m97;
		int java.sql.DatabaseMetaData.getMaxColumnsInGroupBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInGroupBy", "()I", ref global::java.sql.DatabaseMetaData_._m97);
		}
		private static global::MonoJavaBridge.MethodId _m98;
		int java.sql.DatabaseMetaData.getMaxColumnsInIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInIndex", "()I", ref global::java.sql.DatabaseMetaData_._m98);
		}
		private static global::MonoJavaBridge.MethodId _m99;
		int java.sql.DatabaseMetaData.getMaxColumnsInOrderBy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInOrderBy", "()I", ref global::java.sql.DatabaseMetaData_._m99);
		}
		private static global::MonoJavaBridge.MethodId _m100;
		int java.sql.DatabaseMetaData.getMaxColumnsInSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInSelect", "()I", ref global::java.sql.DatabaseMetaData_._m100);
		}
		private static global::MonoJavaBridge.MethodId _m101;
		int java.sql.DatabaseMetaData.getMaxColumnsInTable()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInTable", "()I", ref global::java.sql.DatabaseMetaData_._m101);
		}
		private static global::MonoJavaBridge.MethodId _m102;
		int java.sql.DatabaseMetaData.getMaxConnections()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxConnections", "()I", ref global::java.sql.DatabaseMetaData_._m102);
		}
		private static global::MonoJavaBridge.MethodId _m103;
		int java.sql.DatabaseMetaData.getMaxCursorNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxCursorNameLength", "()I", ref global::java.sql.DatabaseMetaData_._m103);
		}
		private static global::MonoJavaBridge.MethodId _m104;
		int java.sql.DatabaseMetaData.getMaxIndexLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxIndexLength", "()I", ref global::java.sql.DatabaseMetaData_._m104);
		}
		private static global::MonoJavaBridge.MethodId _m105;
		int java.sql.DatabaseMetaData.getMaxSchemaNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxSchemaNameLength", "()I", ref global::java.sql.DatabaseMetaData_._m105);
		}
		private static global::MonoJavaBridge.MethodId _m106;
		int java.sql.DatabaseMetaData.getMaxProcedureNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxProcedureNameLength", "()I", ref global::java.sql.DatabaseMetaData_._m106);
		}
		private static global::MonoJavaBridge.MethodId _m107;
		int java.sql.DatabaseMetaData.getMaxCatalogNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxCatalogNameLength", "()I", ref global::java.sql.DatabaseMetaData_._m107);
		}
		private static global::MonoJavaBridge.MethodId _m108;
		int java.sql.DatabaseMetaData.getMaxRowSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxRowSize", "()I", ref global::java.sql.DatabaseMetaData_._m108);
		}
		private static global::MonoJavaBridge.MethodId _m109;
		bool java.sql.DatabaseMetaData.doesMaxRowSizeIncludeBlobs()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "doesMaxRowSizeIncludeBlobs", "()Z", ref global::java.sql.DatabaseMetaData_._m109);
		}
		private static global::MonoJavaBridge.MethodId _m110;
		int java.sql.DatabaseMetaData.getMaxStatementLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatementLength", "()I", ref global::java.sql.DatabaseMetaData_._m110);
		}
		private static global::MonoJavaBridge.MethodId _m111;
		int java.sql.DatabaseMetaData.getMaxStatements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatements", "()I", ref global::java.sql.DatabaseMetaData_._m111);
		}
		private static global::MonoJavaBridge.MethodId _m112;
		int java.sql.DatabaseMetaData.getMaxTableNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxTableNameLength", "()I", ref global::java.sql.DatabaseMetaData_._m112);
		}
		private static global::MonoJavaBridge.MethodId _m113;
		int java.sql.DatabaseMetaData.getMaxTablesInSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxTablesInSelect", "()I", ref global::java.sql.DatabaseMetaData_._m113);
		}
		private static global::MonoJavaBridge.MethodId _m114;
		int java.sql.DatabaseMetaData.getMaxUserNameLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getMaxUserNameLength", "()I", ref global::java.sql.DatabaseMetaData_._m114);
		}
		private static global::MonoJavaBridge.MethodId _m115;
		int java.sql.DatabaseMetaData.getDefaultTransactionIsolation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDefaultTransactionIsolation", "()I", ref global::java.sql.DatabaseMetaData_._m115);
		}
		private static global::MonoJavaBridge.MethodId _m116;
		bool java.sql.DatabaseMetaData.supportsTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._m116);
		}
		private static global::MonoJavaBridge.MethodId _m117;
		bool java.sql.DatabaseMetaData.supportsTransactionIsolationLevel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactionIsolationLevel", "(I)Z", ref global::java.sql.DatabaseMetaData_._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		bool java.sql.DatabaseMetaData.supportsDataDefinitionAndDataManipulationTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsDataDefinitionAndDataManipulationTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._m118);
		}
		private static global::MonoJavaBridge.MethodId _m119;
		bool java.sql.DatabaseMetaData.supportsDataManipulationTransactionsOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsDataManipulationTransactionsOnly", "()Z", ref global::java.sql.DatabaseMetaData_._m119);
		}
		private static global::MonoJavaBridge.MethodId _m120;
		bool java.sql.DatabaseMetaData.dataDefinitionCausesTransactionCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionCausesTransactionCommit", "()Z", ref global::java.sql.DatabaseMetaData_._m120);
		}
		private static global::MonoJavaBridge.MethodId _m121;
		bool java.sql.DatabaseMetaData.dataDefinitionIgnoredInTransactions()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionIgnoredInTransactions", "()Z", ref global::java.sql.DatabaseMetaData_._m121);
		}
		private static global::MonoJavaBridge.MethodId _m122;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedures(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m123;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedureColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m124;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m124) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m125;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m126;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getCatalogs()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCatalogs", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m126) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m127;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTableTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTableTypes", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m127) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m128;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m129;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumnPrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m130;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTablePrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m131;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getBestRowIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, bool arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m132;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getVersionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m133;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getPrimaryKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m134;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getImportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m135;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getExportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m136;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getCrossReference(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m137;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getTypeInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getTypeInfo", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m137) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m138;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getIndexInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3, bool arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m139;
		bool java.sql.DatabaseMetaData.supportsResultSetType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetType", "(I)Z", ref global::java.sql.DatabaseMetaData_._m139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m140;
		bool java.sql.DatabaseMetaData.supportsResultSetConcurrency(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetConcurrency", "(II)Z", ref global::java.sql.DatabaseMetaData_._m140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m141;
		bool java.sql.DatabaseMetaData.ownUpdatesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "ownUpdatesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._m141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m142;
		bool java.sql.DatabaseMetaData.ownDeletesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "ownDeletesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._m142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m143;
		bool java.sql.DatabaseMetaData.ownInsertsAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "ownInsertsAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._m143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m144;
		bool java.sql.DatabaseMetaData.othersUpdatesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "othersUpdatesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._m144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m145;
		bool java.sql.DatabaseMetaData.othersDeletesAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "othersDeletesAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._m145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m146;
		bool java.sql.DatabaseMetaData.othersInsertsAreVisible(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "othersInsertsAreVisible", "(I)Z", ref global::java.sql.DatabaseMetaData_._m146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m147;
		bool java.sql.DatabaseMetaData.updatesAreDetected(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "updatesAreDetected", "(I)Z", ref global::java.sql.DatabaseMetaData_._m147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m148;
		bool java.sql.DatabaseMetaData.deletesAreDetected(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "deletesAreDetected", "(I)Z", ref global::java.sql.DatabaseMetaData_._m148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m149;
		bool java.sql.DatabaseMetaData.insertsAreDetected(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "insertsAreDetected", "(I)Z", ref global::java.sql.DatabaseMetaData_._m149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m150;
		bool java.sql.DatabaseMetaData.supportsBatchUpdates()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsBatchUpdates", "()Z", ref global::java.sql.DatabaseMetaData_._m150);
		}
		private static global::MonoJavaBridge.MethodId _m151;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getUDTs(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m152;
		bool java.sql.DatabaseMetaData.supportsSavepoints()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsSavepoints", "()Z", ref global::java.sql.DatabaseMetaData_._m152);
		}
		private static global::MonoJavaBridge.MethodId _m153;
		bool java.sql.DatabaseMetaData.supportsNamedParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsNamedParameters", "()Z", ref global::java.sql.DatabaseMetaData_._m153);
		}
		private static global::MonoJavaBridge.MethodId _m154;
		bool java.sql.DatabaseMetaData.supportsMultipleOpenResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleOpenResults", "()Z", ref global::java.sql.DatabaseMetaData_._m154);
		}
		private static global::MonoJavaBridge.MethodId _m155;
		bool java.sql.DatabaseMetaData.supportsGetGeneratedKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsGetGeneratedKeys", "()Z", ref global::java.sql.DatabaseMetaData_._m155);
		}
		private static global::MonoJavaBridge.MethodId _m156;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTypes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m157;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m158;
		bool java.sql.DatabaseMetaData.supportsResultSetHoldability(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetHoldability", "(I)Z", ref global::java.sql.DatabaseMetaData_._m158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m159;
		int java.sql.DatabaseMetaData.getDatabaseMajorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMajorVersion", "()I", ref global::java.sql.DatabaseMetaData_._m159);
		}
		private static global::MonoJavaBridge.MethodId _m160;
		int java.sql.DatabaseMetaData.getDatabaseMinorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMinorVersion", "()I", ref global::java.sql.DatabaseMetaData_._m160);
		}
		private static global::MonoJavaBridge.MethodId _m161;
		int java.sql.DatabaseMetaData.getJDBCMajorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMajorVersion", "()I", ref global::java.sql.DatabaseMetaData_._m161);
		}
		private static global::MonoJavaBridge.MethodId _m162;
		int java.sql.DatabaseMetaData.getJDBCMinorVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMinorVersion", "()I", ref global::java.sql.DatabaseMetaData_._m162);
		}
		private static global::MonoJavaBridge.MethodId _m163;
		int java.sql.DatabaseMetaData.getSQLStateType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "getSQLStateType", "()I", ref global::java.sql.DatabaseMetaData_._m163);
		}
		private static global::MonoJavaBridge.MethodId _m164;
		bool java.sql.DatabaseMetaData.locatorsUpdateCopy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "locatorsUpdateCopy", "()Z", ref global::java.sql.DatabaseMetaData_._m164);
		}
		private static global::MonoJavaBridge.MethodId _m165;
		bool java.sql.DatabaseMetaData.supportsStatementPooling()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsStatementPooling", "()Z", ref global::java.sql.DatabaseMetaData_._m165);
		}
		private static global::MonoJavaBridge.MethodId _m166;
		bool java.sql.DatabaseMetaData.supportsStoredFunctionsUsingCallSyntax()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredFunctionsUsingCallSyntax", "()Z", ref global::java.sql.DatabaseMetaData_._m166);
		}
		private static global::MonoJavaBridge.MethodId _m167;
		bool java.sql.DatabaseMetaData.autoCommitFailureClosesAllResultSets()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DatabaseMetaData_.staticClass, "autoCommitFailureClosesAllResultSets", "()Z", ref global::java.sql.DatabaseMetaData_._m167);
		}
		private static global::MonoJavaBridge.MethodId _m168;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getClientInfoProperties()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getClientInfoProperties", "()Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m168) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m169;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctions(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m170;
		global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.DatabaseMetaData_.staticClass, "getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.DatabaseMetaData_._m170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.ResultSet;
		}
		static DatabaseMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DatabaseMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DatabaseMetaData"));
		}
	}
}
